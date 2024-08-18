﻿namespace PetFamily.Domain.Models
{
    public record VolunteerId
    {
        public VolunteerId(Guid value)
        {
            this.Value = value;
        }
        public Guid Value { get; }
        public static VolunteerId NewVolunteerId() => new(Guid.NewGuid());
        public static VolunteerId Empty() => new(Guid.Empty);
        public static VolunteerId Create(Guid id) => new(id);
    }
}
