using Microsoft.EntityFrameworkCore;

using PetFamily.Domain;

namespace PetFamily.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<SocialNetwork> SocialNetwork { get; set; }
        public DbSet<Requisites> Requisites { get; set; }


    }
}
