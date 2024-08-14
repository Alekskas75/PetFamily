using CSharpFunctionalExtensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models
{
    public record Address
    {
        private Address() { }
        private Address(string city, string district, int houseNumber, int flatNumber)
        {
            City = city;
            District = district;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }

        public string City { get; }
        public string District { get; }
        public int HouseNumber { get; }
        public int FlatNumber { get; }

        public static Result<Address> Create(string city, string district, int houseNumber, int flatNumber)
        {
           

            var address = new Address(city, district, houseNumber, flatNumber);

            return Result.Success(address);
        }

       
    }
}
