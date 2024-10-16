using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dominio
{
    public class SesionesEntrenamiento
    {
        public int IdSesion { get; set; }
        public DateTime FechaHora { get; set; }
        public string Categoria { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    }
}