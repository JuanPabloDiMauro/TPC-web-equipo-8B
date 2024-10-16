using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class jugadores : persona
    {
        public int IdJugador { get; set; }
        public string Disponibilidad { get; set; }
        public string Posicion { get; set; }
        public string Categoria { get; set; }
    }
}