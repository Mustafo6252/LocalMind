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
            modelBuilder.Entity<UserAdditionalDetails>()
                .HasOne(userAdditionalDetails => userAdditionalDetails.User)
                .WithOne(user => user.UserAdditionalDetails)
                .HasForeignKey<UserAdditionalDetails>(userAdditionalDetails => userAdditionalDetails.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            
              
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedNever(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}


