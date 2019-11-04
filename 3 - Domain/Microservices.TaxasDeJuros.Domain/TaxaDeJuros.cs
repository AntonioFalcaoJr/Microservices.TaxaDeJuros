using CalculadoraDeJuros.Contratos.Domain;
using Microservices.TaxasDeJuros.Domain.Base;

namespace Microservices.TaxasDeJuros.Domain
{
    public class TaxaDeJuros : BaseEntity, ITaxaDeJuros
    {
        public TaxaDeJuros()
        {
        }

        public TaxaDeJuros(decimal valor)
        {
            SetValor(valor);
        }

        private decimal Valor { get; set; }

        public decimal Get() => Valor;

        private void SetValor(decimal valor) => Valor = valor;
    }
}