using System.ComponentModel.DataAnnotations;

namespace SlnCrudASPnet7MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El movil es obligatorio")]
        public string Movil { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }



    }
}
