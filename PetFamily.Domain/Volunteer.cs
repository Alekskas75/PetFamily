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
        public int Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExperienceInYears { get; set; }
        public int InHome { get; set; }
        public int NoHome { get; set; }
        public int BeingTreated { get; set; }  //На лечении
        public string TelephoneNumber { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }

        public List<Requisites> Requisites;  //исправил8
        public List<Pet> Pets { get; set; } //исправил9
    }

}
