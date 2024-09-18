﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.AnimalManagement.IDs
{
    public record VolunteerId
    {
        private VolunteerId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static VolunteerId NewVolunteerId() => new(Guid.NewGuid());

        public static VolunteerId Empty() => new(Guid.Empty);

        public static VolunteerId Create(Guid id) => new(id);

        public static implicit operator VolunteerId(Guid id) => new(id);

        public static implicit operator Guid(VolunteerId volunteerId)
        {
            ArgumentNullException.ThrowIfNull(volunteerId);

            return volunteerId.Value;
        }
    }
}
