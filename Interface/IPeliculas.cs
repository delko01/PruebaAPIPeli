using Microsoft.AspNetCore.Mvc;
using pruebaVSCodeAPI.Controllers;
using pruebaVSCodeAPI.Models;

namespace pruebaVSCodeAPI.Interface {
    public interface IPeliculas {

        Task<ActionResult<IEnumerable<Pelicula>>> GetPeliculas();

        Task<ActionResult<Pelicula>> GetPelicula(int id);

        Task<bool> InsertPelicula(Pelicula pelicula);

        Task<bool> UpdatePelicula(Pelicula pelicula);

        Task<bool> DeletePelicula(int id);
    }
}
