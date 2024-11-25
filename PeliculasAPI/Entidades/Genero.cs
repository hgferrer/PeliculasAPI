using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Genero: IId
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El campo {0} es requerido")]
        [StringLength (10, ErrorMessage ="El campo {0} debe tener {1} caracteres o menos")]
        public required string Nombre { get; set; }
    }
}
