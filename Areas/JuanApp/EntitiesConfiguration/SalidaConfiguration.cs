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
    public class SalidaConfiguration : IEntityTypeConfiguration<Salida>
    {
        public void Configure(EntityTypeBuilder<Salida> entity)
        {
            try
            {
                //SalidaId
                entity.HasKey(e => e.SalidaId);
                entity.Property(e => e.SalidaId)
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

                //CodigoDeCliente
                entity.Property(e => e.CodigoDeCliente)
                    .HasColumnType("varchar(500)")
                    .IsRequired(true);

                //NombreDeCliente
                entity.Property(e => e.NombreDeCliente)
                    .HasColumnType("varchar(1000)")
                    .IsRequired(true);

                //CodigoDeProducto
                entity.Property(e => e.CodigoDeProducto)
                    .HasColumnType("int")
                    .IsRequired(true);

                //NombreDeProducto
                entity.Property(e => e.NombreDeProducto)
                    .HasColumnType("varchar(1000)")
                    .IsRequired(true);

                //KilosReales
                entity.Property(e => e.KilosReales)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //Precio
                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //Subtotal
                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(18, 2)")
                    .IsRequired(true);

                //NroDePesaje
                entity.Property(e => e.NroDePesaje)
                    .HasColumnType("int")
                    .IsRequired(true);

                
            }
            catch (Exception) { throw; }
        }
    }
}
