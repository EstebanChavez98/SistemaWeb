using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }
        [Required]
        public int idrol { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre no debe tener menos de 3 caracteres ni mas de 100 caracteres")]
        public String nombre { get; set; }
        public String tipo_documento { get; set; }
        public String num_documento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        [Required]
        public String email { get; set; }
        [Required]
        public byte[] password_hash { get; set; }
        [Required]
        public byte[] password_salt { get; set; }
        public bool condicion { get; set; }

        public Rol rol { get; set; }
    }
}
