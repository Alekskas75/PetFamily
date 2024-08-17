using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models
{
    public class PetPhoto
    {
        public PetPhoto() {}

        public Guid Id { get; private set; }
        public string Path { get; private set; } = default!;
        public bool IsMainPhoto { get; private set; }
    }
}
