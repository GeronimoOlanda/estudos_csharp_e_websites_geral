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
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {

        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            //primery key
            builder.HasKey(x => x.Id_Agenda);

            //Atributos
            builder.Property(e => e.Titulo)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(e => e.Observacoes)
             .HasMaxLength(255)
             .IsRequired();
            builder.Property(e => e.Detalhes)
             .HasMaxLength(255)
             .IsRequired();
            builder.Property(e => e.flagExibir)
             .HasMaxLength(5)
             .IsRequired();



        }
    }
}
