using System.ComponentModel.DataAnnotations;

namespace Reservaciones.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del usuario es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El nombre del usuario no puede exceder 200 caracteres")]
        public string? Usuario { get; set; }
        public string? Salas { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Duracion { get; set; }
        [Required(ErrorMessage = "El departamento es obligatorio")]
        [RegularExpression("^(Efectivo|Tarjeta|Por pagar)$", ErrorMessage = "El Pago debe ser Efectivo, Tarjeta o Por pagar")]
        public string? Pago { get; set; }
    }
}
