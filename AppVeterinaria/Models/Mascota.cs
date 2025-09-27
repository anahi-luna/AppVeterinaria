using System.ComponentModel.DataAnnotations;

namespace AppVeterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre no puede estar vacío")]
        public required string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad {  get; set; }
        public double Peso { get; set; }
        public Cliente ClienteId { get; set; }
    }
}
