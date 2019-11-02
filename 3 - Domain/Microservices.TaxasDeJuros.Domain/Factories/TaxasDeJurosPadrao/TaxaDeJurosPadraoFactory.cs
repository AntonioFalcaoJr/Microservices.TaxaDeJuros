using CalculadoraDeJuros.Contratos.Domain;
using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;

namespace Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoFactory : ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>
    {
        private const decimal Valor = 0.01M;
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