using Microservices.TaxasDeJuros.Domain.Factories;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Services.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoServices : ITaxaDeJurosPadraoServices
    {
        private readonly ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> _taxaDeJurosPadraoFactory;

        public TaxaDeJurosPadraoServices(ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> taxaDeJurosPadraoFactory)
        {
            _taxaDeJurosPadraoFactory = taxaDeJurosPadraoFactory;
        }

        public double GetValor()
        {
            var taxaDeJuros = _taxaDeJurosPadraoFactory.Create();
            return taxaDeJuros?.Get() ?? 0;
        }
    }
}