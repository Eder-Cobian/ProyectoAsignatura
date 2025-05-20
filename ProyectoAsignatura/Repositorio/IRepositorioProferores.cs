using Microsoft.AspNetCore.Identity;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public interface IRepositorioProfesores
    {
        Task<List<Profesor>> GetAll();
        Task<Profesor?> Get(int id);
        Task<Profesor> Add(Profesor profesor);
        Task Update(int id, Profesor profesor);
        Task Delete(int id);
    }
}
