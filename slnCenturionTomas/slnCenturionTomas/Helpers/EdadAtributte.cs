using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace slnCenturionTomas.Helpers
{
    public class EdadAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            int edad = (int)value;
            if(edad >= 18)
            {
                return new ValidationResult("Solo se aceptan personas con edad igual o mayor a 18");
            }

            return ValidationResult.Success;
        }


    }
}
