using dotenv.net;
using Microsoft.EntityFrameworkCore;

namespace DockerWorkshow.Models
{
  public class Context : DbContext
  {
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<InvoiceDetail> InvoiceDetails => Set<InvoiceDetail>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(DotEnv.Read()["CONNECTION_STRING"]).UseSnakeCaseNamingConvention();
    }
  }
}
