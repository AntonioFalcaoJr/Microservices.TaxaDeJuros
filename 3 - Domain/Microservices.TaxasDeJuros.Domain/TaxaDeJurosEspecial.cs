using CalculadoraDeJuros.Contratos.Domain;

namespace Microservices.TaxasDeJuros.Domain
{
    public class TaxaDeJurosEspecial : TaxaDeJuros, ITaxaDeJurosEspecial
    {
        public TaxaDeJurosEspecial(decimal valor) : base(valor)
        {
        }
    }
}