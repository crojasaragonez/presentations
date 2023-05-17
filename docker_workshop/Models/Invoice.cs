using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DockerWorkshow.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public ICollection<InvoiceDetail> Details { get; } = new List<InvoiceDetail>();
        public void AddLine(InvoiceDetail line) {
            this.Details.Add(line);
        }

        public String toHTML() {
            var filename = string.Format("{0}.html", this.Id);
            var builder = new StringBuilder();
            builder.Append("<html><body>");
            builder.Append($"<h1>Invoice ID: {this.Id}</h1>");
            builder.Append($"<p>Invoice Date: {this.Date.ToShortDateString()}</p>");
            builder.Append($"<p>Total Amount: {this.Total:C}</p>");
            builder.Append("<table border='1'>");
            builder.Append("<tr><th>Item Name</th><th>Quantity</th><th>Price</th></tr>");
            foreach (var detail in this.Details)
            {
                builder.Append("<tr>");
                builder.Append($"<td>{detail.Description}</td>");
                builder.Append($"<td>{detail.Quantity}</td>");
                builder.Append($"<td>{detail.UnitPrice:C}</td>");
                builder.Append("</tr>");
            }

            builder.Append("</table>");
            builder.Append("</body></html>");
            File.WriteAllText(filename, builder.ToString());
            return filename;
        }
    }
}
