using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class Volunteer
    {
        public Volunteer() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ExperienceInYears { get; set; }
        public int InHome { get; set; }
        public int NoHome { get; set; }
        public int BeingTreated { get; set; }  //На лечении
        public string TelephoneNumber { get; set; }
        public string SocialNetworks { get; set; }
        public string DetailsForHelp { get; set; }
        public List<Pet> ListOfPets { get; set; }

    }
}
