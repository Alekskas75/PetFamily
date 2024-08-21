using PetFamily.Domain.Shared;



namespace PetFamily.Domain.Models.Volunteer
{
    public class Pet : Entity<PetId>
    {
        private Pet(PetId id) : base(id)
        {

        }
        public PetId Id { get; private set; }
        public string Name { get; private set; } = default!;
        public string Species { get; private set; } = default!;
        public string Description { get; private set; } = default!;
        public string Breed { get; private set; } = default!;
        public string Color { get; private set; } = default!;
        public string HealthInformation { get; private set; } = default!; //Информация о здоровье
        public Address Address { get; private set; }
        public decimal Weight { get; private set; }
        public string PhoneNumber { get; private set; } = default!;
        public bool IsNeutered { get; private set; }   //Кастрирован?
        public DateTime DateOfBirth { get; private set; }
        public bool IsVaccinated { get; private set; }
        public enum Status;
        public Requisites Requisites { get; private set; }
        public DateTime CreationDate { get; private set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Entity<PetId> other)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
