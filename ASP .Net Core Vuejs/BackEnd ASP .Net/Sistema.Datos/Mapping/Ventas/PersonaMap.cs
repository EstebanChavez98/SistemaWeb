using Microsoft.EntityFrameworkCore;
using Sistema.Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Mapping.Ventas
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona")
                .HasKey(p => p.idpersona);
        }
    }
}
