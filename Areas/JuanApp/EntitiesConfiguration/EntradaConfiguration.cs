using JuanApp.Areas.JuanApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp.Areas.JuanApp.EntitiesConfiguration
{
    public class EntradaConfiguration : IEntityTypeConfiguration<Entrada>
    {
        public void Configure(EntityTypeBuilder<Entrada> entity)
        {
            try
            {
                //EntradaId
                entity.HasKey(e => e.EntradaId);
                entity.Property(e => e.EntradaId)
                    .ValueGeneratedOnAdd();

                //Active
                entity.Property(e => e.Active)
                    .HasColumnType("tinyint")
                    .IsRequired(true);

                //DateTimeCreation
                entity.Property(e => e.DateTimeCreation)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //DateTimeLastModification
                entity.Property(e => e.DateTimeLastModification)
                    .HasColumnType("datetime")
                    .IsRequired(true);

                //UserCreationId
                entity.Property(e => e.UserCreationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //UserLastModificationId
                entity.Property(e => e.UserLastModificationId)
                    .HasColumnType("int")
                    .IsRequired(true);

                //CodigoDeBarra
                entity.Property(e => e.CodigoDeBarra)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(true);

                //NroDePesaje
                entity.Property(e => e.NroDePesaje)
                    .HasColumnType("int")
                    .IsRequired(true);

                //CodigoDeProducto
                entity.Property(e => e.CodigoDeProducto)
                    .HasColumnType("varchar(2000)")
                    .IsRequired(true);

                //NombreDeProducto
                entity.Property(e => e.NombreDeProducto)
                    .HasColumnType("varchar(500)")
                    .IsRequired(false);

                //TexContenido
                entity.Property(e => e.TexContenido)
                    .HasColumnType("int")
                    .IsRequired(true);

                //Neto
                entity.Property(e => e.Neto)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
