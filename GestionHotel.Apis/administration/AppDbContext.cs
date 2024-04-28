using GestionHotel.Apis.admin;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GestionHotel.Apis.administration
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserAPP> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Ajoutez ici des configurations supplémentaires si nécessaire
        }
    }
}
