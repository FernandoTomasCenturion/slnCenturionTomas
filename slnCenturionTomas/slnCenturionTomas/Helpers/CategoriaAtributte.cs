using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace slnCenturionTomas.Helpers
{
    public class CategoriaAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            if (value.ToString() != "Desayuno")
            {
                return new ValidationResult("Solo esta permitido ingresar la categoria desayuno");
            }

            return ValidationResult.Success;
        }
    }
}