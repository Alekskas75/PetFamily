using PetFamily.Domain.Shared.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
