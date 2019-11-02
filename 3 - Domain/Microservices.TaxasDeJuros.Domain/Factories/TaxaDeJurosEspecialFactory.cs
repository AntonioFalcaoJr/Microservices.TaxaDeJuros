using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosEspecial;
using Microservices.TaxasDeJuros.Domain.TaxasDeJurosEspecial;

namespace Microservices.TaxasDeJuros.Domain.Factories
{
    public class TaxaDeJurosEspecialFactory : ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial>
    {
        private const decimal Valor = 0.005M;
        private readonly ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial> _taxaDeJurosEspecialBuilder;

        public TaxaDeJurosEspecialFactory(ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial> taxaDeJurosEspecialBuilder)
        {
            _taxaDeJurosEspecialBuilder = taxaDeJurosEspecialBuilder;
        }

        public ITaxaDeJurosEspecial Create()
        {
            return _taxaDeJurosEspecialBuilder
                .WithValor(Valor)
                .Build();
        }
    }
}