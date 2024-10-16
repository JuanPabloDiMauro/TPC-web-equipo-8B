using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class Entrenadores : persona
    {
        public int IdEntrenador { get; set; }
        public string Rol { get; set; }
        public string CategoriaAsignada { get; set; }
    }
}