using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DescargaExcel.Models
{
    public class PersonaViewModel
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Opciones { get; set; }
        public string Sexo { get; set; }
    }
}