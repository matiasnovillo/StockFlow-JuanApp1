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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            try
            {
                //ClienteId
                entity.HasKey(e => e.ClienteId);
                entity.Property(e => e.ClienteId)
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

                //NombreDeCliente
                entity.Property(e => e.NombreDeCliente)
                    .HasColumnType("varchar(500)")
                    .IsRequired(true);

                //CodigoDeCliente
                entity.Property(e => e.CodigoDeCliente)
                    .HasColumnType("varchar(100)")
                    .IsRequired(true);

                //Domicilio
                entity.Property(e => e.Domicilio)
                    .HasColumnType("varchar(8000)")
                    .IsRequired(false);

                //Localidad
                entity.Property(e => e.Localidad)
                    .HasColumnType("varchar(1500)")
                    .IsRequired(false);

                //CUIT
                entity.Property(e => e.CUIT)
                    .HasColumnType("varchar(150)")
                    .IsRequired(true);

                //Telefono
                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(200)")
                    .IsRequired(false);

                //CodigoPostal
                entity.Property(e => e.CodigoPostal)
                    .HasColumnType("varchar(50)")
                    .IsRequired(false);

                //Provincia
                entity.Property(e => e.Provincia)
                    .HasColumnType("varchar(250)")
                    .IsRequired(false);

                
            }
            catch (Exception) { throw; }
        }
    }
}
