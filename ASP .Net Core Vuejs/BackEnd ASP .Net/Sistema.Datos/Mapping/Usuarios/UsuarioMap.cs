using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Sistema.Entidades.Usuarios;
using System.Text;

namespace Sistema.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario")
                .HasKey(u => u.idusuario);
        }
    }
}
