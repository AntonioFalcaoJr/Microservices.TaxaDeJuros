using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public class TaxaDeJurosPadraoFactory : ITaxaDeJurosPadraoFactory<ITaxaDeJuros>
    {
        private const double Valor = 1.0;
        private readonly ITaxaDeJurosPadraoBuilder<ITaxaDeJuros> _taxaDeJurosPadraoBuilder;

        public TaxaDeJurosPadraoFactory(ITaxaDeJurosPadraoBuilder<ITaxaDeJuros> taxaDeJurosPadraoBuilder)
        {
            _taxaDeJurosPadraoBuilder = taxaDeJurosPadraoBuilder;
        }

        public ITaxaDeJuros Create()
        {
            return _taxaDeJurosPadraoBuilder
                 .WithValor(Valor)
                 .Build();
        }
    }
}