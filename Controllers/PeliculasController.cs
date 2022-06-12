using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebaVSCodeAPI.Interface;
using pruebaVSCodeAPI.Models;

namespace pruebaVSCodeAPI.Controllers {

    public class PeliculasController: ControllerBase, IPeliculas {
        private readonly PeliculasContext _context;
        public PeliculasController(PeliculasContext context) {
            _context = context;
        }

        [HttpGet("peliculas")]
        public async Task<ActionResult<IEnumerable<Pelicula>>> GetPeliculas() {
            var peliculas = await _context.Peliculas.ToListAsync<Pelicula>();
      
            if (peliculas == null) {
                return NotFound();
            }

            var algo = peliculas.Where(p => p.IdPelicula == 2);

            return peliculas;
        }

        [HttpGet("pelicula/{id}")]
        public async Task<ActionResult<Pelicula>> GetPelicula(int id) {
            var pelicula = await _context.Peliculas.FindAsync(id);

            if (pelicula == null) {
                return NotFound();
            }

            return pelicula;
        }

        [HttpPost("DeletePelicula/{id}")]
        public async Task<bool> DeletePelicula(int id) {
            var pelicula = await _context.Peliculas.FindAsync(id);
            _context.Peliculas.Remove(pelicula);

            int filasAfect = await _context.SaveChangesAsync();
            
            return filasAfect > 0 ? true:false;
        }

        [HttpPost("AddPelicla")]
        public async Task<bool> InsertPelicula(Pelicula pelicula) {
            _context.Peliculas.Add(pelicula);
            int filasAfect = await _context.SaveChangesAsync();
            return filasAfect > 0 ? true : false;
        }

        [HttpPost("UpdatePelicula")]
        public async Task<bool> UpdatePelicula(Pelicula pelicula) {
            _context.Entry(pelicula).State = EntityState.Modified;
            int filasAfect = await _context.SaveChangesAsync();
            return filasAfect > 0 ? true : false;
        }
    }
}