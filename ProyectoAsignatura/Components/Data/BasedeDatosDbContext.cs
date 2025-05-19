using Microsoft.EntityFrameworkCore;

namespace ProyectoAsignatura.Components.Data
{
    public class BasedeDatosDbContext : DbContext
    {
        public BasedeDatosDbContext(DbContextOptions<BasedeDatosDbContext> options) : base( options ) { }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}
