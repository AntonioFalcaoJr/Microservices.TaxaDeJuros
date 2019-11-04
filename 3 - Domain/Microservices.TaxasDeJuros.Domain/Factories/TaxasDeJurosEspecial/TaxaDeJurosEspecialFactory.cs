using CalculadoraDeJuros.Contratos.Domain;
using Microservices.TaxasDeJuros.CrossCutting;
using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosEspecial;

namespace Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosEspecial
{
    public class TaxaDeJurosEspecialFactory : ITaxaDeJurosEspecialFactory<ITaxaDeJurosEspecial>
    {
        private readonly ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial> _taxaDeJurosEspecialBuilder;

        public TaxaDeJurosEspecialFactory(ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial> taxaDeJurosEspecialBuilder)
        {
            _taxaDeJurosEspecialBuilder = taxaDeJurosEspecialBuilder;
        }

        public ITaxaDeJurosEspecial Create()
        {
            return _taxaDeJurosEspecialBuilder
                .WithValor(TaxaDeJurosConstants.ValorDaTaxaDeJurosEspecial)
                .Build();
        }
    }
}