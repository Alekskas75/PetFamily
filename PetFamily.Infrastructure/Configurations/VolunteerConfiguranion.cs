using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.Volunteer;

namespace PetFamily.Infrastructure.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public VolunteerConfiguration() { }

        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable("volunteer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasConversion(
                id => id.Value, value => VolunteerId.Create(new Guid()) );

        }
    }
}
