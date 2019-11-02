using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain
{
    public class TaxaDeJurosPadrao : TaxaDeJuros, ITaxaDeJurosPadrao
    {
        public TaxaDeJurosPadrao(decimal valor) : base(valor)
        {
        }
    }
}