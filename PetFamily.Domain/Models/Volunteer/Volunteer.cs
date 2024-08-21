using PetFamily.Domain.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetFamily.Domain.Models;

namespace PetFamily.Domain.Models.Volunteer
{
    public class Volunteer : Entity<VolunteerId>
    {
        public Volunteer(VolunteerId id) : base(id)
        {
        }

        public Volunteer(VolunteerId volunteerId,
                         FullName fullName,
                         string description)
            : base(volunteerId)
        {
            Id = volunteerId;
            FullName = fullName;
            Description = description;
        }
        private readonly List<Pet> _pets = [];
        private readonly int _InHome;
        private readonly int _NoHome;
        private readonly int _BeingTreated;

        public VolunteerId Id { get; private set; }
        public FullName FullName { get; private set; }
        public string Description { get; private set; } = default!;
        public int ExperienceInYears { get; private set; }
        public int GetInHomeCount() => _InHome; //Нашли дом count
        public int GetNoHomeCount() => _NoHome; //Без дома count
        public int GetBeingTreatedCount() => _BeingTreated; //Лечится count
        public string PhoneNumber { get; private set; } = default!;
        public List<SocialNetwork> SocialNetworks { get; private set; } = [];
        public Requisites Requisites { get; private set; }


        public IReadOnlyList<Pet> Pets => _pets;
    }
}
