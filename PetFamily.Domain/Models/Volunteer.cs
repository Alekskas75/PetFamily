using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models
{
    public class Volunteer
    {
        public Volunteer() { }
        public Guid Id { get; private set; }
        public string LastName { get; private set; } = default!;
        public string FirstName { get; private set; } = default!;
        public string MiddleName { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public int ExperienceInYears { get; private set; }
        public int InHome { get; private set; }
        public int NoHome { get; private set; }
        public int BeingTreated { get; private set; }
        public string PhoneNumber { get; private set; } = default!;
        public List<SocialNetwork> SocialNetworks { get; private set; } = [];
        public List<Requisites> Requisites { get; private set; } = [];
        public List<Pet> Pets { get; private set; } = [];
    }

}
