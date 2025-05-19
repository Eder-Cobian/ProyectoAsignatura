using Microsoft.EntityFrameworkCore;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public class RepositorioAsignaturas : IRepositorioAsignaturas
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioAsignaturas(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task<Asignatura> Add(Asignatura asignatura)
        {
            await _context.Asignaturas.AddAsync(asignatura);
            await _context.SaveChangesAsync();
            return asignatura;
        }

        public async Task Delete(int id)
        {
            var asignatura = await _context.Asignaturas.FindAsync(id);
            if (asignatura != null)
            {
                _context.Asignaturas.Remove(asignatura);
                await _context.SaveChangesAsync();
            }
        }

        public Task<Asignatura?> GetAsignatura(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Asignatura?> Get(int id)
        {
            return await _context.Asignaturas.FindAsync(id);
        }

        public async Task<List<Asignatura>> GetAll()
        {
            return await _context.Asignaturas.ToListAsync();
        }

        public async Task<List<Aula>> GetAulas()
        {
            return await _context.Aulas.ToListAsync();
        }

        public async Task<List<Profesor>> GetProfesores()
        {
            return await _context.Profesores.ToListAsync();
        }

        public async Task Update(int id, Asignatura asignatura)
        {
            var existingAsignatura = await _context.Asignaturas.FindAsync(id);
            if (existingAsignatura != null)
            {
                existingAsignatura.Nombre = asignatura.Nombre;
                existingAsignatura.Horario = asignatura.Horario;
                await _context.SaveChangesAsync();
            }
        }
    }
}
