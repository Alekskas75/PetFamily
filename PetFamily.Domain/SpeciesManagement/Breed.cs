using PetFamily.Domain.Shared;
using PetFamily.Domain.SpeciesManagement.IDs;

namespace PetFamily.Domain.SpeciesManagement
{
    public class Breed : Entity<BreedId>
    {
        private Breed(BreedId id) : base(id)
        {
        }

        public string Name { get; private set; } = default!;
    }
}
