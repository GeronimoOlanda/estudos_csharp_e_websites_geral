using GeroOlanda.Domain.Entities;
using GeroOlanda.Domain.Repository.Impl.ConfigurationMaps;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Getha;Trusted_Connection=True;", opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new HomeMap());

        }
    }
}
