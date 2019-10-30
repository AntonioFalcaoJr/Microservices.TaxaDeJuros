using Microservices.TaxaDeJuros.Domain.Builders;
using Microservices.TaxaDeJuros.Domain.Taxas;

namespace Microservices.TaxaDeJuros.Services
{
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        private const double Valor = 1.0;

        public double GetValor()
        {
            var taxaDeJuros = GetTaxaDeJuros();
            return taxaDeJuros?.Valor ?? 0;
        }

        private Taxa GetTaxaDeJuros()
        {
            var taxaDeJuros = new TaxaDeJurosBuilder()
                .WithValor(Valor)
                .Build();

            return taxaDeJuros;
        }
    }
}
