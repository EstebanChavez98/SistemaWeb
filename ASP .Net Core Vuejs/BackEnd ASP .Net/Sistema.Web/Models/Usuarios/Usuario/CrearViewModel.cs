using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Usuarios.Usuario
{
    public class CrearViewModel
    {
        [Required]
        public int idrol { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre no debe tener menos de 3 caracteres ni mas de 100 caracteres")]
        public String nombre { get; set; }
        public String tipo_documento { get; set; }
        public String num_documento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        [Required] [EmailAddress]
        public String email { get; set; }
        [Required]
        public String password { get; set; }
    }
}
