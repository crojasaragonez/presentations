using System.ComponentModel.DataAnnotations;

namespace DockerWorkshow.Models
{
  public class InvoiceDetail
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public int InvoiceId { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required]
    public double Quantity { get; set; } = 1;
    [Required]
    public double UnitPrice { get; set; } = 0;
    public Invoice Invoice { get; set; } = null!;
  }
}
