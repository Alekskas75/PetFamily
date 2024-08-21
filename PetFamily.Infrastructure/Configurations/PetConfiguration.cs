using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Models.Volunteer;
using PetFamily.Domain.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Infrastructure.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("pet");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .HasConversion(
                id => id.Value, 
                value => PetId.Create(new Guid()));

            builder.Property(p => p.Name)
                .IsRequired(true)
                .HasMaxLength(Constants.MAX_MEDIUM_TEXT_LENGTH);

           builder.Property(p => p.Description)
                .HasMaxLength(Constants.MAX_SHORT_TEXT_LENGTH);

            builder.HasOne(p => p.Address)
                .WithOne()
                .HasForeignKey("pet_id"); 
        }
    }
}
