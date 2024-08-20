using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models;

namespace PetFamily.Infrastructure.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public VolunteerConfiguration() { }

        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable(nameof(Volunteer));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasConversion(id => id, Value => VolunteerId.Create(new Guid()) );

        }
    }
}
