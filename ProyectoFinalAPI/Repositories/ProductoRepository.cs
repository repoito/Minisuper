using ProyectoFinalAPI.Data;
using ProyectoFinalAPI.Models;
using ProyectoFinalAPI.Repositories.IRepository;

namespace ProyectoFinalAPI.Repositories
{

    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly AppDbContext _db;
        

        public ProductoRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public Task GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Producto> Update(Producto entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
