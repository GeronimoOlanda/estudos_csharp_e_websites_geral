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
    public class LoginUserMap : IEntityTypeConfiguration<UserLogin>
    {
       
        public const string NomeTabela = "Home";
        public const string NomeColunaId = "id_home";

        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            //primery key
            builder.HasKey(x => x.Id_Usuario);

            //Atributos
            //builder.Property(e => e.).IsRequired();


        }
    }
}
