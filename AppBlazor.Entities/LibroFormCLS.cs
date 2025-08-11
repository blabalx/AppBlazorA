using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class LibroFormCLS
    {
        [Required (ErrorMessage ="El id es requerido")]
        [Range(1, int.MaxValue, ErrorMessage ="El valor debe ser positivo")]
        public int idLibro { get; set; }
        [Required (ErrorMessage ="El titulo es requerido")]
        [MaxLength(100,ErrorMessage ="La longitud maxima es 100 caracteres")]
        public string titulo { get; set; } = null!;
        [Required (ErrorMessage ="El resumen es requerido")]
        [MinLength(20,ErrorMessage ="La longitud minima es 20 caracteres")]
        public string resumen { get; set; }=null!;

    }
}
