namespace fachaGym.Controllers
{
    using global::fachaGym.Models;
    using global::fachaGym.Service.IService.fachaGym.Services;
    using Microsoft.AspNetCore.Mvc;

    namespace fachaGym.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UsuarioController : ControllerBase
        {
            private readonly IUsuarioService _service;

            public UsuarioController(IUsuarioService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var usuarios = await _service.ObtenerTodos();
                return Ok(usuarios);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetById(int id)
            {
                var usuario = await _service.ObtenerPorId(id);
                if (usuario == null) return NotFound();
                return Ok(usuario);
            }

            [HttpPost]
            public async Task<IActionResult> Crear(Usuario usuario)
            {
                try
                {
                    usuario.FechaRegistro = usuario.FechaRegistro.UtcDateTime;
                    await _service.Crear(usuario);
                    return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear usuario: {ex.Message}");
                    return StatusCode(500, $"Error interno: {ex.Message}");
                }
            }


            [HttpPut("{id}")]
            public async Task<IActionResult> Actualizar(int id, Usuario usuario)
            {
                if (id != usuario.Id) return BadRequest();
                await _service.Actualizar(usuario);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Eliminar(int id)
            {
                await _service.Eliminar(id);
                return NoContent();
            }
        }
    }

}
