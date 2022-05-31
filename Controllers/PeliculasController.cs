using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebaVSCodeAPI.Models;

namespace pruebaVSCodeAPI.Controllers {

    public class PeliculasController: ControllerBase {
        private readonly PeliculasContext _context;
        public PeliculasController(PeliculasContext context) {
            _context = context;
        }

        [HttpGet("peliculas")]
        public async Task<ActionResult<IEnumerable<Pelicula>>> Get() {
            var peliculas = await _context.Peliculas.ToListAsync<Pelicula>();

            if (peliculas == null) {
                return NotFound();
            }

            return peliculas;
        }
    }
}