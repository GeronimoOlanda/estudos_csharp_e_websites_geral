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

        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            //primery key
            builder.HasKey(x => x.Id_Usuario);

            //Atributos
            builder.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.LoginUser)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.Password).IsRequired();
          
            builder.Property(e => e.Password_Encrypt).IsRequired();

            builder.Property(e => e.flag_UserAlive)
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(e => e.flag_Setor)
                .HasMaxLength(12)
                .IsRequired();

            //gerado pelo sistema, com base na hora atual
            builder.Property(e => e.Created_At).IsRequired(); ;
            builder.Property(e => e.Updated_At).IsRequired();


        }
    }
}
