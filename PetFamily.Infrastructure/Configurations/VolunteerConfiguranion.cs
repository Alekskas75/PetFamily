using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.Volunteer;
using PetFamily.Domain.Shared;

using System.Reflection.Metadata;

namespace PetFamily.Infrastructure.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public VolunteerConfiguration() { }

        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.ToTable("volunteer");
            builder.HasKey(v=> v.Id);
            builder.Property(v => v.Id)
                .HasConversion(
                id => id.Value, 
                value => VolunteerId.Create(new Guid()) );

            builder.Property(v => v.Description)
                .IsRequired(true)
                .HasMaxLength(Constants.MAX_MEDIUM_TEXT_LENGTH);

            builder.Property(v => v.Description)
               .IsRequired(false)
               .HasMaxLength(Constants.PHONE_NUMBER_MAX_LENGTH);

            builder.HasMany(v => v.Pets)
                .WithOne()
                .HasForeignKey("volunteer_id");
        }
    }
}
