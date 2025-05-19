using System.ComponentModel.DataAnnotations;
namespace ProyectoAsignatura.Components.Data
{
    public class Profesor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Profesor es obligatorio.")]
        [StringLength(100, ErrorMessage = "El Nombre no puede exceder de 100 espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del Correo no es válido.")]
        [StringLength(100, ErrorMessage = "El Correo no puede exceder de 100 espacios.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El Teléfono no es válido.")]
        [Length(10, 10, ErrorMessage = "El Teléfono no puede exceder los 10 espacios.")]
        public string? Teléfono { get; set; }

        //Propiedad de navegación EF
        virtual public ICollection<Asignatura>? Asignaturas { get; set; }
    }
}
