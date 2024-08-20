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
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable(nameof(Pet));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasConversion(id => id, Value => PetId.Create(new Guid()));
        }
    }
}
