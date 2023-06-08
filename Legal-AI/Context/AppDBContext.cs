using Legal_AI.Models;
using Microsoft.EntityFrameworkCore;

namespace Legal_AI.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-40JAMN6\\PROMACT;Initial Catalog=Legal_AI_DB;Integrated Security=True;TrustServerCertificate=True");


            }
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration code...
        }
        // Define DbSet properties for your entities
       
        // Add other DbSet properties as needed
    }
}
