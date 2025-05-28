using Microsoft.EntityFrameworkCore;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public class RepositorioAulas : IRepositorioAulas
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioAulas(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task<Aula> Add(Aula aula)
        {
            await _context.Aulas.AddAsync(aula);
            await _context.SaveChangesAsync();
            return aula;
        }

        public async Task Delete(int id)
        {
            var aula = await _context.Aulas.FindAsync(id);
            if (aula != null)
            {
                _context.Aulas.Remove(aula);
                await _context.SaveChangesAsync();
            }
        }

        public Task<Aula?> GetAula(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Aula?> Get(int id)
        {
            return await _context.Aulas.FindAsync(id);
        }

        public async Task<List<Aula>> GetAll()
        {
            return await _context.Aulas.ToListAsync();
        }

        public async Task Update(int id, Aula aula)
        {
            var existingAula = await _context.Aulas.FindAsync(id);
            if (existingAula != null)
            {
                existingAula.Nombre = aula.Nombre;
                existingAula.Capacidad = aula.Capacidad;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> SePuedeBorrar(int id)
        {
            bool estaEnUso = await _context.Asignaturas.AnyAsync(a => a.AulaId == id);
            return !estaEnUso;  
        }
    }
}

