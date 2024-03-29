﻿using System.ComponentModel.DataAnnotations;
namespace Sistema.Web.Models.Almacen.Articulo
{
    public class CrearViewModel
    {
        [Required]
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener mas de 50 caracteres, ni menos de 3 caracteres")]
        public string nombre { get; set; }
        [Required]
        public decimal precio_venta { get; set; }
        [Required]
        public int stock { get; set; }
        public string descripcion { get; set; }
    }
}
