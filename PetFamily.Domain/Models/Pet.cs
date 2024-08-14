namespace PetFamily.Domain.Models
{
    public class Pet
    {
        private Pet() { }
        public PetId Id { get; private set; }
        public string Name { get; private set; } = default!;
        public string Species { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Breed { get; private set; } = default!;
        public string Color { get; private set; } = default!;
        public string HealthInformation { get; private set; } = default!;
        public Address address { get; private set; }
        public decimal Weight { get; private set; }
        public string PhoneNumber { get; private set; } = default!;
        public bool IsNeutered { get; private set; } 
        public DateTime DateOfBirth { get; private set; }
        public bool IsVaccinated { get; private set; }  
        public enum Status;
        public Requisites Requisites { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}
