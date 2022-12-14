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
    public class HomeMap : IEntityTypeConfiguration<Home>
    {
        public const string NomeTabela = "Home";
        public const string NomeColunaId = "id_home";

        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.HasKey(x => x.Id); 
            builder.ToTable(NomeTabela);
            builder.Property(e => e.Id)
                    .HasColumnName(NomeColunaId)
                    .IsRequired();
            builder.HasOne(e => e.Descricao);


        }
    }
}
