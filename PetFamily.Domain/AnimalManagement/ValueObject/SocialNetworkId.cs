using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record SocialNetworkId
    {
        public SocialNetworkId(Guid value)
        {
            Value = value;
        }
        public Guid Value { get; }
        public static SocialNetworkId NewVolunteerId() => new(Guid.NewGuid());
        public static SocialNetworkId Empty() => new(Guid.Empty);
    }
}
