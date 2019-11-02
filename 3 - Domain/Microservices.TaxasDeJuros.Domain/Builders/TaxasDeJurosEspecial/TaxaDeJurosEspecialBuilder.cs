using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosEspecial
{
    public class TaxaDeJurosEspecialBuilder : ITaxaDeJurosEspecialBuilder<ITaxaDeJurosEspecial>
    {
        private decimal _valor;

        public ITaxaDeJurosEspecial Build() => new TaxaDeJurosEspecial(_valor);

        public ITaxaDeJurosBuilder<ITaxaDeJurosEspecial> WithValor(decimal valor)
        {
            _valor = valor;
            return this;
        }
    }
}