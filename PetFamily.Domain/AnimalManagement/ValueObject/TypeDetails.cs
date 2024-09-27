using CSharpFunctionalExtensions;
using PetFamily.Domain.SpeciesManagement.IDs;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record TypeDetails
    {
        private TypeDetails(SpeciesId speciesId, BreedId breedId)
        {
            SpeciesId = speciesId;
            BreedId = breedId;
        }

        public SpeciesId SpeciesId { get; }
        public BreedId BreedId { get; }

        public static Result<TypeDetails> Create(SpeciesId speciesId, BreedId breedId)
        {
            return new TypeDetails(speciesId, breedId);
        }
    }
}
