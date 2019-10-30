namespace Microservices.TaxasDeJuros.Domain
{
    public abstract class TaxaDeJuros : ITaxaDeJuros
    {
        protected TaxaDeJuros(double valor)
        {
            SetValor(valor);
        }

        private double Valor { get; set; }

        public double Get() => Valor;

        private void SetValor(double valor) => Valor = valor;
    }
}