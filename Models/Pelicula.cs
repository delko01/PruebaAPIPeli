using System;
using System.Collections.Generic;

namespace pruebaVSCodeAPI.Models
{
    public partial class Pelicula
    {
        public int IdPelicula { get; set; }
        public string NombrePelicula { get; set; } = null!;
        public int IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
    }
}
