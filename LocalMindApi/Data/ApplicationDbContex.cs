using LocalMindApi.Models;
using LocalMindApi.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocalMindApi.Data
{
    public class ApplicationDbContex: DbContext
    {
        private readonly IConfiguration configuration;

        public ApplicationDbContex(
            DbContextOptions<ApplicationDbContex> options,
            IConfiguration configuration) :
            base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAdditionalDetails> UserAdditionalDetails { get; set; } 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}