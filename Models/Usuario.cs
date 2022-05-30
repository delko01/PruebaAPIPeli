using System;
using System.Collections.Generic;

namespace pruebaVSCodeAPI.Models
{
    public partial class Usuario
    {
        public int Userid { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
    }
}
