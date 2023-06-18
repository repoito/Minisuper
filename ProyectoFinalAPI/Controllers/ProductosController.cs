using Microsoft.AspNetCore.Mvc;
using ProyectoFinalAPI.Models;
using ProyectoFinalAPI.Repositories;
using ProyectoFinalAPI.Repositories.IRepository;

namespace ProyectoFinalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productos = await _productoRepository.GetAll();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var producto = await ProductoRepository.Get();
            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {
            await ProductoRepository.Add(producto);
            return CreatedAtAction(nameof(GetById), new { id = producto.IdProducto }, producto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Producto producto)
        {
            if (id != producto.IdProducto)
                return BadRequest();

            try
            {
                await _productoRepository.Update(producto);
                return NoContent();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var producto = await ProductoRepository.GetById(id);
            if (producto == null)
                return NotFound();

            await ProductoRepository.Delete(producto);
            return NoContent();
        }
    }

}
