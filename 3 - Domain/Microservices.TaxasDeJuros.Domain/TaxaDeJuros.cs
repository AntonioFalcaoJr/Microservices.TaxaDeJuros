using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain
{
    public abstract class TaxaDeJuros : ITaxaDeJuros
    {
        protected TaxaDeJuros(decimal valor)
        {
            SetValor(valor);
        }

        private decimal Valor { get; set; }

        public decimal Get() => Valor;

        private void SetValor(decimal valor) => Valor = valor;
    }
}