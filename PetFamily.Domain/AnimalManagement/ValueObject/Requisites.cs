using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record Requisites
    {
        public Requisites()
        {
        }

        public Requisites(string name, string description, string target, string check, string cardNumber)
        {
            Name = name;
            Description = description;
            Target = target;
            Check = check;
            CardNumber = cardNumber;
        }

        public string Name { get; }
        public string Description { get; }
        public string Target { get; }
        public string Check { get; }
        public string CardNumber { get; }


    }
}
