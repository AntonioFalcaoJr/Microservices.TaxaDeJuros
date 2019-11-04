using CalculadoraDeJuros.Contratos.Errors.Hiper.Domain.Base.Errors;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microservices.TaxasDeJuros.Domain.Base
{
    public abstract class BaseEntity : BaseError
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}