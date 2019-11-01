namespace Microservices.TaxasDeJuros.Domain.TaxasDeJurosPadrao
{
    public class TaxaDeJurosPadrao : TaxaDeJuros, ITaxaDeJurosPadrao
    {
        public TaxaDeJurosPadrao(decimal valor) : base(valor)
        {
        }
    }
}