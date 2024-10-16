using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class EstadoFisico
    {
        public int IdJugador { get; set; }
        public bool Disponibilidad { get; set; }
        public string GradoLesion { get; set; }
        public DateTime TiempoRecuperacion { get; set; }
    }
}