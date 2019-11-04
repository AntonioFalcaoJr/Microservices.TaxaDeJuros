using System;

namespace Microservices.TaxasDeJuros.CrossCutting
{
    public static class TaxaDeJurosConstants
    {
        public const decimal ValorDaTaxaDeJurosEspecial = 0.005M;
        public const decimal ValorDaTaxaDeJurosPadrao = 0.01M;

        public static readonly Guid IdDaTaxaDeJurosEspecial = Guid.Parse("21b55dc0-4051-4a53-abdb-d9ef6f126f41");
        public static readonly Guid IdDaTaxaDeJurosPadrao = Guid.Parse("98fed592-621d-4705-9b32-c08dcdfd60ff");
    }
}