using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using PetFamily.Domain.Models;

namespace PetFamily.Api.Data
{
    public class AppDbContext(IConfiguration configuration) : DbContext
    {
        const string DATABASE = "DefaultConnection";
        // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Volunteer> Volunteer => Set<Volunteer>();
        public DbSet<Pet> Pet => Set<Pet>();
        //public DbSet<SocialNetwork> SocialNetwork => Set<SocialNetwork>();
        //public DbSet<Requisites> Requisites => Set<Requisites>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString(DATABASE));
            optionsBuilder.UseSnakeCaseNamingConvention();
            optionsBuilder.UseLoggerFactory(CreateLoggerFactory());
        }
        private ILoggerFactory CreateLoggerFactory() => LoggerFactory.Create(bilder => { bilder.AddConsole(); });
    }
}
