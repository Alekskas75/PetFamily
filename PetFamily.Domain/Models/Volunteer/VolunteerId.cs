namespace PetFamily.Domain.Models.Volunteer
{
    public record VolunteerId
    {
        public Guid Value { get; }

        private VolunteerId(Guid value) => Value = value;

        public static VolunteerId NewId() => new VolunteerId(Guid.NewGuid());
        public static VolunteerId Empty() => new VolunteerId(Guid.Empty);
        public static VolunteerId Create(Guid value) => new VolunteerId(value);
    }
}
