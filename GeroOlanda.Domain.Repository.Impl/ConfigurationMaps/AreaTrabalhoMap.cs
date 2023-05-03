using GeroOlanda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository.Impl.ConfigurationMaps
{
    public class AreaTrabalhoMap : IEntityTypeConfiguration<AreaTrabalho>
    {

        public void Configure(EntityTypeBuilder<AreaTrabalho> builder)
        {
            //primery key
            builder.HasKey(x => x.Id);

            //Atributos
            builder.Property(e => e.Width)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(e => e.Height)
              .HasMaxLength(255)
              .IsRequired();

            builder.Property(e => e.Description)
              .HasMaxLength(255)
              .IsRequired();

            builder.Property(e => e.Name)
              .HasMaxLength(255)
              .IsRequired();


            builder.Property(e => e.Type)
              .HasMaxLength(255)
              .IsRequired();

            builder.Property(e => e.Background)
              .HasMaxLength(255)
              .IsRequired();

            builder.Property(e => e.ImageUrl)
            .HasMaxLength(255)
            .IsRequired();

        }
    }
}
