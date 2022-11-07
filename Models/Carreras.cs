using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Fase_1.Models
{
    public class Carreras
        
    {
        public int Id { get; set; } 
        public string Carrera { get; set; }
        public string escuela { get; set; }
        public int Asignaturas { get; set; }
        public string Duracion { get; set; }
        public string Descripcion { get; set; }
    }
}
