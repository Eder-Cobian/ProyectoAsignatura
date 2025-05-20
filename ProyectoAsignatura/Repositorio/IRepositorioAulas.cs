using Microsoft.AspNetCore.Identity;
using ProyectoAsignatura.Components.Data;

namespace ProyectoAsignatura.Repositorio
{
    public interface IRepositorioAulas
    {
        Task<List<Aula>> GetAll();
        Task<Aula?> Get(int id);
        Task<Aula> Add(Aula aula);
        Task Update(int id, Aula aula);
        Task Delete(int id);
    }
}
