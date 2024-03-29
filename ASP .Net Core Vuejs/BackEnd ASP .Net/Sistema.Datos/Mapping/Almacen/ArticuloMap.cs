﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Sistema.Entidades.Almacen;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistema.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(a => a.idarticulo);
        }
    }
}
