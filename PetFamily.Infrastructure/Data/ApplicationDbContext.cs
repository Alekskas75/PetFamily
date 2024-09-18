using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using PetFamily.Domain.AnimalManagement.AggregateRoot;
using PetFamily.Domain.SpeciesManagement;

namespace PetFamily.Infrastructure.Data
{
    public class ApplicationDbContext(IConfiguration configuration) : DbContext
    {
        const string DATABASE = "DefaultConnection";
        public DbSet<Volunteer> Volunteer => Set<Volunteer>();
        public DbSet<Species> Species => Set<Species>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString(DATABASE));
            optionsBuilder.UseSnakeCaseNamingConvention();
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseLoggerFactory(CreateLoggerFactory());

            //optionsBuilder.AddInterceptors(new SoftDeleteInterceptor());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        private ILoggerFactory CreateLoggerFactory() =>
            LoggerFactory.Create(builder => { builder.AddConsole(); });
    }
}
