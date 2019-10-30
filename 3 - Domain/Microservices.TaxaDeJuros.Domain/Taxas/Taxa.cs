namespace Microservices.TaxaDeJuros.Domain.Taxas
{
    public class Taxa
    {
        public double Valor { get; private set; }

        public Taxa(double valor)
        {
            SetValor(Valor);
        }

        private void SetValor(double valor) => Valor = valor;
    }
}
