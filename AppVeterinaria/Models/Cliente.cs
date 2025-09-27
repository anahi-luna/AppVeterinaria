using System.ComponentModel.DataAnnotations;

namespace AppVeterinaria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre no puede estar vacío")]
        public required string Nombre { get; set; }
        
        [Required(ErrorMessage = "El Email no puede estar vacío")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "El Telefono no puede estar vacío")]
        public required string Telefono { get; set; }
    }
}
