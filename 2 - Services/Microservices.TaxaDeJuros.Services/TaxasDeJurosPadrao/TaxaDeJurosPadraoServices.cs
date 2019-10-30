using Microservices.TaxasDeJuros.Domain;
using Microservices.TaxasDeJuros.Domain.Factories;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoServices : ITaxaDeJurosPadraoServices
    {
        private readonly ITaxaDeJurosPadraoFactory<ITaxaDeJuros> _taxaDeJurosPadraoFactory;

        public TaxaDeJurosPadraoServices(ITaxaDeJurosPadraoFactory<ITaxaDeJuros> taxaDeJurosPadraoFactory)
        {
            _taxaDeJurosPadraoFactory = taxaDeJurosPadraoFactory;
        }

        public double GetValor()
        {
            var taxaDeJuros = _taxaDeJurosPadraoFactory.Create();
            return taxaDeJuros?.GetValor() ?? 0;
        }
    }
}