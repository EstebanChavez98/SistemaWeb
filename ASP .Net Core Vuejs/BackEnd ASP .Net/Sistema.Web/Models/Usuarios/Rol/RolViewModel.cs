using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Usuarios.Rol
{
    public class RolViewModel
    {
        public int idrol { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public bool condicion { get; set; }
    }
}
