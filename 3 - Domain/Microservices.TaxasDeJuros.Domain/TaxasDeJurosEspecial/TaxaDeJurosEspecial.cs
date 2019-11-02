namespace Microservices.TaxasDeJuros.Domain.TaxasDeJurosEspecial
{
    public class TaxaDeJurosEspecial : TaxaDeJuros, ITaxaDeJurosEspecial
    {
        public TaxaDeJurosEspecial(decimal valor) : base(valor)
        {
        }
    }
}