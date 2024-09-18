using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models.Volunteer
{
    public record FullName
    {
        public FullName()
        {
        }

        public FullName(string lastName, string firstName, string? middleName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName =default!;
        }

        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
    }
}
