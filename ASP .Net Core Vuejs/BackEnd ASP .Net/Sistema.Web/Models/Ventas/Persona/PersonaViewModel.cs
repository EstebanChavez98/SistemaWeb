using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Ventas.Persona
{
    public class PersonaViewModel
    {
        public int idpersona { get; set; }
        public String tipo_persona { get; set; }
        public String nombre { get; set; }
        public String tipo_documento { get; set; }
        public String num_documento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
    }
}
