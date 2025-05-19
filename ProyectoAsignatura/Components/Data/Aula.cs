using System.ComponentModel.DataAnnotations;
namespace ProyectoAsignatura.Components.Data

{
    public class Aula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Aula es obligatorio.")]
        [StringLength(100, ErrorMessage = "El aula no puede exceder de 100 espacios.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La Capacidad del Aula es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La Capacidad del Aula debe ser un número positivo.")]
        public int Capacidad { get; set; }

        //Propiedad de navegación EF
        virtual public ICollection<Asignatura>? Asignaturas { get; set; }
    }
}
