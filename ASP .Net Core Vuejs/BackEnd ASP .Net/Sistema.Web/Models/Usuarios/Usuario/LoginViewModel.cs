using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Usuarios.Usuario
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public String email { get; set; }
        [Required]
        public String password { get; set; }
    }
}
