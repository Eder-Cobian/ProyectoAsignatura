using Microsoft.AspNetCore.Identity;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public interface IRepositorioAsignaturas
    {
        Task<List<Asignatura>> GetAll();
        Task<Asignatura?> Get(int id);
        Task<List<Aula>> GetAulas();
        Task<List<Profesor>> GetProfesores();
        Task<Asignatura> Add(Asignatura asignatura);
        Task Update(int id, Asignatura asignatura);
        Task Delete(int id);
    }
}
