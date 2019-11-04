using Microservices.TaxasDeJuros.Domain;
using Microsoft.EntityFrameworkCore;

namespace Microservices.TaxasDeJuros.Data
{
    public interface ITaxasDeJurosContext
    {
        DbSet<TaxaDeJuros> TaxasDeJuros { get; set; }

        int SaveChanges();
    }
}