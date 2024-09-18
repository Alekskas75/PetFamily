using CSharpFunctionalExtensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Shared.ValueObjects
{
    public record Description
    {
        private Description(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static Result<Description, Error> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > Constants.MAX_HIGH_TEXT_LENGTH)
                return Errors.General.ValueIsInvalid("description");

            return new Description(value);
        }
    }
}
