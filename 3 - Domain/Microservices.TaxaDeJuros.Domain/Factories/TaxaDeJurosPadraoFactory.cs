using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public class TaxaDeJurosPadraoFactory : ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>
    {
        private const double Valor = 1.0;
        private readonly ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao> _taxaDeJurosPadraoBuilder;

        public TaxaDeJurosPadraoFactory(ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao> taxaDeJurosPadraoBuilder)
        {
            _taxaDeJurosPadraoBuilder = taxaDeJurosPadraoBuilder;
        }

        public ITaxaDeJurosPadrao Create()
        {
            return _taxaDeJurosPadraoBuilder
                 .WithValor(Valor)
                 .Build();
        }
    }
}