using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Usuarios.Usuario
{
    public class UsuarioViewModel
    {
        public int idusuario { get; set; }
        public int idrol { get; set; }
        public String rol { get; set; }
        public String nombre { get; set; }
        public String tipo_documento { get; set; }
        public String num_documento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public byte[] password_hash { get; set; }
        public bool condicion { get; set; }
    }
}
