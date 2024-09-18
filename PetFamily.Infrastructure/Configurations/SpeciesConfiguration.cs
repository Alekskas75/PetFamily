using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetFamily.Domain.SpeciesManagement;
using PetFamily.Domain.Shared;
using PetFamily.Domain.SpeciesManagement.IDs;

namespace PetFamily.Infrastructure.Configurations
{
    public class SpeciesConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            builder.ToTable("species");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasConversion(
                    id => id.Value,
                    value => SpeciesId.Create(value));

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

            builder.OwnsMany(s => s.Breeds, bb =>
            {
                bb.Property(b => b.Id)
                    .HasConversion(
                        id => id.Value,
                        value => BreedId.Create(value));

                bb.Property(b => b.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
            });
        }
    }
}
