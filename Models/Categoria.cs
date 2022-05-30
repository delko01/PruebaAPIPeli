using System;
using System.Collections.Generic;

namespace pruebaVSCodeAPI.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Peliculas = new HashSet<Pelicula>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Estado { get; set; }

        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
