// See https://aka.ms/new-console-template for more information
using DockerWorkshow.Models;
using dotenv.net;
using RabbitMQ.Client;
using DockerWorkshow.Mq;
using System.Text;

namespace DockerWorkshow
{
  internal class Program
  {
    static void Main(string[] args) {

      var envVars = DotEnv.Read();

      var factory = new ConnectionFactory() { HostName = envVars["RABBITMQ_HOST"]};

      AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
      Context context = new Context();

      var connection = factory.CreateConnection();
      var channel = connection.CreateModel();

      if (args.Length > 0 && args[0] == "worker")
      {
          var worker = new Worker(context);
          worker.Work(channel);
          return;
      }

      var invoice = new Invoice();
      invoice.Date = DateTime.Today;
      invoice.Total = 4000;

      var detail = new InvoiceDetail();
      detail.Description = "Articulo 1";
      detail.Quantity = 1;
      detail.UnitPrice = 4000;

      invoice.AddLine(detail);

      context.Invoices.Add(invoice);

      context.SaveChanges();

      channel.QueueDeclare(queue: envVars["QUEUE_NAME"],
                            durable: false,
                            exclusive: false,
                            autoDelete: false,
                            arguments: null);

      var body = Encoding.UTF8.GetBytes(invoice.Id.ToString());

      channel.BasicPublish(exchange: "",
                            routingKey: envVars["QUEUE_NAME"],
                            basicProperties: null,
                            body: body);
      Console.WriteLine(" [x] Sent {0}", invoice.Id);
      channel.Close();
      connection.Close();
    }
  }
}

