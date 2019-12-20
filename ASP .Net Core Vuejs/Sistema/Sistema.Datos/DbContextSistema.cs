using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Mapping.Almacen;
using Sistema.Entidades.Almacen;

namespace Sistema.Datos
{
    public class DbContextSistema : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        //Constructor
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {

        }
        //Metodo para mapear las indentidades de la BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Indicando a la clase padre que cuando cree el modelo,, que cree el modelBuilder
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ArticuloMap());
        }
    }
}
