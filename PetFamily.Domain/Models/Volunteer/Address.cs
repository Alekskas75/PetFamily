using CSharpFunctionalExtensions;
//using PetFamily.Domain.Shared;

namespace PetFamily.Domain.Models.Volunteer
{
    public record Address
    {
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
            if (string.IsNullOrWhiteSpace(city))
            {
                return Result.Failure<Address>("Город не может быть пустым.");
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                return Result.Failure<Address>("Район не может быть пустым.");
            }
            if (houseNumber <= 0)
            {
                return Result.Failure<Address>("Номер дома не может быть пустым.");
            }
            if (flatNumber <= 0)
            {
                return Result.Failure<Address>("Номер квартиры должен быть больше нуля.");
            }
            var address = new Address(city, district, houseNumber, flatNumber);
            return Result.Success(address);
        }
    }
}
