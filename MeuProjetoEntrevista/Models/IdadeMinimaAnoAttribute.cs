using System;
using System.ComponentModel.DataAnnotations;

namespace MeuProjetoEntrevista.Models
{
    public class IdadeMinima : ValidationAttribute
    {
        int _idadeMinima;

        public IdadeMinima(int idadeMinima)
        {
            _idadeMinima = idadeMinima;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_idadeMinima) < DateTime.Now;
            }

            return false;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date;           


            if (DateTime.TryParse(value.ToString(), out date))
            {
                int Ano = date.Year;
                int AnoMinimo = DateTime.Now.Year - _idadeMinima;
                if (AnoMinimo <= Ano)
                    return new ValidationResult(string.Format("A idade mínima para realizar o cadastro é {0} anos",
                           _idadeMinima));
            }

            return null;
        }
    }
}