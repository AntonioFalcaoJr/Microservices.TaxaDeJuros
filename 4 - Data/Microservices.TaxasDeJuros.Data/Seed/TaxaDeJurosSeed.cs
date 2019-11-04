using Microservices.TaxasDeJuros.CrossCutting;
using Microservices.TaxasDeJuros.Domain;

namespace Microservices.TaxasDeJuros.Data.Seed
{
    public class TaxaDeJurosSeed : IEntitySeed
    {
        private readonly ITaxasDeJurosContext _taxasDeJurosContext;

        public TaxaDeJurosSeed(ITaxasDeJurosContext taxasDeJurosContext)
        {
            _taxasDeJurosContext = taxasDeJurosContext;
        }

        public void Execute()
        {
            var taxaDeJurosPadrao = new TaxaDeJurosPadrao(TaxaDeJurosConstants.ValorDaTaxaDeJurosPadrao);
            taxaDeJurosPadrao.Id = TaxaDeJurosConstants.IdDaTaxaDeJurosPadrao;
            _taxasDeJurosContext.TaxasDeJuros.Add(taxaDeJurosPadrao);

            var taxaDeJurosEspecial = new TaxaDeJurosEspecial(TaxaDeJurosConstants.ValorDaTaxaDeJurosEspecial);
            taxaDeJurosEspecial.Id = TaxaDeJurosConstants.IdDaTaxaDeJurosEspecial;
            _taxasDeJurosContext.TaxasDeJuros.Add(taxaDeJurosEspecial);

            _taxasDeJurosContext.SaveChanges();
        }
    }
}