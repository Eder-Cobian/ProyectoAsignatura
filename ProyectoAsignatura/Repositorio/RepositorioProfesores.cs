using Microsoft.EntityFrameworkCore;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public class RepositorioProfesores : IRepositorioProfesores
    {
        private readonly BasedeDatosDbContext _context;

        public RepositorioProfesores(BasedeDatosDbContext context)
        {
            _context = context;
        }

        public async Task<Profesor> Add(Profesor profesor)
        {
            await _context.Profesores.AddAsync(profesor);
            await _context.SaveChangesAsync();
            return profesor;
        }

        public async Task Delete(int id)
        {
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor != null)
            {
                _context.Profesores.Remove(profesor);
                await _context.SaveChangesAsync();
            }
        }

        public Task<Profesor?> GetAula(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Profesor?> Get(int id)
        {
            return await _context.Profesores.FindAsync(id);
        }

        public async Task<List<Profesor>> GetAll()
        {
            return await _context.Profesores.ToListAsync();
        }

        public async Task Update(int id, Profesor profesor)
        {
            var existingProfesor = await _context.Profesores.FindAsync(id);
            if (existingProfesor != null)
            {
                existingProfesor.Nombre = profesor.Nombre;
                existingProfesor.Correo = profesor.Correo;
                existingProfesor.Teléfono = profesor.Teléfono;
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> SePuedeBorrar(int id)
        {
            bool estaEnUso = await _context.Asignaturas.AnyAsync(a => a.ProfesorId == id);
            return !estaEnUso;
        }
    }
}


