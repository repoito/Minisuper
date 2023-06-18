using ProyectoFinalAPI.Models;

namespace ProyectoFinalAPI.Repositories.IRepository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task GetById(int id);
        Task<Producto> Update(Producto entity);
    }
}
