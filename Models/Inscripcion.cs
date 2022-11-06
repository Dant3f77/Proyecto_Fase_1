using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Fase_1.Models
{
    public class Inscripcion
    {
       public int id { get; set; }
        public string nombres { get; set; }
        public string apellidoP { get; set; }
        public string apellidoS { get; set; }
        public string carrera { get; set; }
        public string dui { get; set; }
        public string nit { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }

        public int idCarrera { get; set; }//esta va ser foranea key , id de la tabla carrera



    }
}