using System;
using Meucachorro.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Meucachorro.Models
{

 
    public class usuario 
    {
      
        [Required]
        public int idUsuario{get; set;}        
     
        [Required(ErrorMessage = "Email do Usuario Necessario",AllowEmptyStrings=false)]
        [Display(Name = "Informe o email do Usuario.")]
        public string emailUsuario{get; set;}
     
        [Required(ErrorMessage = "Login Usuario Necessario",AllowEmptyStrings=false)]
        [StringLength(30)]
        public string loginUsuario{ get; set;}
     
        [Required]
        public string senhaUsuario{ get; set;}
     
        [Required]
        public string tipoUsuario{get; set;}

        public DateTime  dtcadUsuario {get; set;}


    //   : IValidatableObject
    //    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //    {
    //        if (Genre == Genre.Classic && ReleaseDate.Year > _classicYear)
    //        {
    //               yield return new ValidationResult(
    //               $"Classic movies must have a release year no later than {_classicYear}.",
     //              new[] { nameof(ReleaseDate) });
    //        }
    //    }

    }
}