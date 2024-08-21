using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models.Volunteer
{
    public record SocialNetwork
    {
        public SocialNetwork(string social, string link)
        {
            Social = social;
            Link = link;
        }

       
        public string Social { get; }
        public string Link { get; }

    }
}
