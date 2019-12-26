using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Usuarios
{
    public class Rol
    {
        public int idrol { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3, ErrorMessage ="El nombre no debe tener mas de 30 caracteres, ni menos de 3 caracteres")]
        public String nombre { get; set; }
        [StringLength(256)]
        public String descripcion { get; set; }
        public bool condicion { get; set; }
        public ICollection<Usuario> usuarios { get; set; }
    }
}
