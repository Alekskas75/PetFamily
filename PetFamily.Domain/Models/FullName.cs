using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models
{
    public record FullName
    {
        public FullName()
        {
        }

        public FullName(string lastName, string firstName, string middleName)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
        }

        public string LastName { get; } 
        public string FirstName { get; } 
        public string MiddleName { get; }
    }
}
