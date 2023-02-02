using slnCenturionTomas.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Titulo { get; set; }

        [CategoriaAtributte]
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Nombre Autor")]
        public string NombreAutor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Display(Name = "Apellido Autor")]
        public string ApellidoAutor { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [EdadAtributte]
        [Display(Name = "Edad Autor")]
        public int EdadAutor { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Es necesario ingresar un mail")]
        public string EmailAutor { get; set; }
    }
}
