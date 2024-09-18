using CSharpFunctionalExtensions;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Shared.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record PetPhoto
    {
        private PetPhoto(string path, bool isMain)
        {
            Path = path;
            IsMain = isMain;
        }

        public string Path { get; }
        public bool IsMain { get; }

        public static Result<PetPhoto, Error> Create(string path, bool isMain)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return Errors.General.ValueIsInvalid("path");
            }

            return new PetPhoto(path, isMain);
        }
    }
   
}
