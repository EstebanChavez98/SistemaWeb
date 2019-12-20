using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Almacen
{
    public class Articulo
    {
        public bool condicion;

        public int idarticulo { get; set; }
        [Required]
        public int idcategoria { get; set; }
        public String codigo { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe de tener mas de 50 caracteres ni menos de 3 caracteres")]
        public String nombre { get; set; }
        [Required]
        public decimal precio_venta { get; set; }
        [Required]
        public int stock { get; set; }
        public String descripcion { get; set; }
        public Categoria categoria { get; set; }
    }
}
