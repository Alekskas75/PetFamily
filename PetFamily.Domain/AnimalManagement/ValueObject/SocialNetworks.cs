using PetFamily.Domain.Shared.ValueObjects;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record SocialNetworks
    {
        private SocialNetworks()
        {
        }

        public SocialNetworks(IEnumerable<SocialNetwork> socials)
        {
            Socials = socials.ToList();
        }

        public IReadOnlyList<SocialNetwork> Socials { get; }
    }
}
