using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class Volunteer
    {
        public Volunteer() { }
        public int Guid { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int ExperienceInYears { get; private set; }
        public int InHome { get; private set; }
        public int NoHome { get; private set; }
        public int BeingTreated { get; private set; }  //На лечении
        public string TelephoneNumber { get; private set; }
        public List<SocialNetwork> SocialNetworks { get; private set; }
        public List<Requisites> Requisites { get; private set; };  //исправил8
        public List<Pet> Pets { get; private set; } //исправил9
    }

}
