using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Repository.Impl.ConfigurationMaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeroOlanda.Domain.Repository.Impl.GeroDbContext
{
    public class GeroOlandaDbContext : DbContext
    {
        public DbSet<Home> Home { get; set; }

        public GeroOlandaDbContext(DbContextOptions<GeroOlandaDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            //primery key
            builder.HasKey(x => x.id_home);

            //Atributos
            builder.HasOne(e => e.Descricao);


        }
        //builder.ApplyConfiguration(new HomeMap());

    }
}
