namespace Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadraoBuilder : ITaxaDeJurosPadraoBuilder<TaxaDeJurosPadrao>
    {
        private double _valor;

        public TaxaDeJurosPadrao Build() => new TaxaDeJurosPadrao(_valor);

        public ITaxaDeJurosBuilder<TaxaDeJurosPadrao> WithValor(double valor)
        {
            _valor = valor;
            return this;
        }
    }
}