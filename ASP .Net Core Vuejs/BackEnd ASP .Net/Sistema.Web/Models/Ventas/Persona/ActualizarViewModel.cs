using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Ventas.Persona
{
    public class ActualizarViewModel
    {
        [Required]
        public int idpersona { get; set; }
        [Required]
        public String tipo_persona { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre de la persona debe tener más de 3 caracteres y menos de 100 caracteres")]
        public String nombre { get; set; }
        public String tipo_documento { get; set; }
        public String num_documento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
    }
}
