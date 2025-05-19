using System.ComponentModel.DataAnnotations;

namespace ProyectoAsignatura.Components.Data
{
    public class Asignatura
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la asignatura es obligatorio.")]
        [StringLength(100, ErrorMessage = "La asignatura no puede exceder de 100 espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El Horario es obligatorio.")]
        [StringLength(30, ErrorMessage = "El Horario no puede exceder de 15 espacios.")]
        public string? Horario { get; set; }
       
        //Propiedades de navegación EF
        public int ProfesorId { get; set; }
        virtual public Profesor? Profesor { get; set; }

        public int AulaId { get; set; }
        virtual public Aula? Aula { get; set; }
    }
}
