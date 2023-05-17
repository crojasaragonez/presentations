using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using DockerWorkshow.Models;
using dotenv.net;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Net.Mail;
using System.Text;

namespace DockerWorkshow.Mq
{
  public class Worker
  {
    private Context context;
    private IDictionary<string, string> env = DotEnv.Read();
    public Worker(Context context)
    {
      this.context = context;
    }

    public void Work(IModel channel) {

      channel.QueueDeclare(queue: this.env["QUEUE_NAME"], durable: false, exclusive: false, autoDelete: false, arguments: null);
      var consumer = new EventingBasicConsumer(channel);
      consumer.Received += (model, ea) =>
            {
              var body = ea.Body.ToArray();
              int id = Convert.ToInt32(Encoding.UTF8.GetString(body));
              var invoice = context.Invoices.Include(invoice => invoice.Details).Where((invoice) => invoice.Id.Equals(id)).First();
              if (invoice != null)
              {
                  var file = invoice.toHTML();
                  this.SendEmail(file);
                  this.UploadFile(file);
              }
              Console.WriteLine(" [x] Received {0}", id);
            };
      channel.BasicConsume(queue: this.env["QUEUE_NAME"], autoAck: true, consumer: consumer);
      Console.WriteLine(" Press [enter] to exit.");
      Console.ReadLine();
      channel.Close();
    }

    private void UploadFile(string file) {
      IAmazonS3 s3Client = s3Client = new AmazonS3Client(this.env["AWS_ACCESS_KEY_ID"], this.env["AWS_SECRET_ACCESS_KEY"], new AmazonS3Config
      {
        RegionEndpoint = RegionEndpoint.GetBySystemName(this.env["AWS_REGION"]),
        ServiceURL = this.env["S3_ENDPOINT"],
        ForcePathStyle = true
      });
      new TransferUtility(s3Client).Upload(file, this.env["AWS_BUCKET"]);
    }

    private void SendEmail(String file) {
      MailMessage mail = new MailMessage();
      mail.From = new MailAddress(this.env["MAIL_FROM"]);
      mail.To.Add(this.env["MAIL_TO"]);
      mail.Subject = "Email with HTML attachment";
      mail.Body = "Hello, please find the attached HTML file.";
      Attachment attachment = new Attachment(file, "text/html");
      mail.Attachments.Add(attachment);
      SmtpClient smtpClient = new SmtpClient(this.env["MAIL_HOST"], Convert.ToInt32(this.env["MAIL_PORT"]));
      smtpClient.UseDefaultCredentials = false;
      smtpClient.Send(mail);
    }
  }
}
