using CSharpFunctionalExtensions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using PetFamily.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .HasConversion(id => id.Value, Value => VolunteerId.Create(Value) );

        }
    }
}
