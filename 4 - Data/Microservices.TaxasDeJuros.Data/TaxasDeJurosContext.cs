using Microservices.TaxasDeJuros.Domain;
using Microsoft.EntityFrameworkCore;

namespace Microservices.TaxasDeJuros.Data
{
    public class TaxasDeJurosContext : DbContext, ITaxasDeJurosContext
    {
        public TaxasDeJurosContext(DbContextOptions<TaxasDeJurosContext> options)
            : base(options)
        { }

        public DbSet<TaxaDeJuros> TaxasDeJuros { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}