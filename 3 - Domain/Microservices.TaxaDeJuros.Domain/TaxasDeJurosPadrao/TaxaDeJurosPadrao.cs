namespace Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadrao : TaxaDeJuros, ITaxaDeJurosPadrao
    {
        public TaxaDeJurosPadrao(double valor) : base(valor)
        {
        }
    }
}