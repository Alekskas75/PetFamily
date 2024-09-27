using FluentValidation;
using PetFamily.Application.Dtos;
using PetFamily.Domain.AnimalManagement.ValueObject;
using PetFamily.Domain.Shared.ValueObjects;
using PetFamily.Domain.Shared;
using PetFamily.Application.Validation;

namespace PetFamily.Application.Volunteers.UpdateMainInfo
{
    public class UpdateMainInfoRequestValidator : AbstractValidator<UpdateMainInfoRequest>
    {
        public UpdateMainInfoRequestValidator()
        {
            RuleFor(u => u.VolunteerId).NotEmpty().WithError(Errors.General.ValueIsRequired());
        }
    }

    public class UpdateMainInfoDtoValidator : AbstractValidator<UpdateMainInfoDto>
    {
        public UpdateMainInfoDtoValidator()
        {
            RuleFor(u => u.FullName)
                .MustBeValueObject(x => FullName.Create(x.FirstName, x.LastName));

            RuleFor(c => c.Description).MustBeValueObject(Description.Create);
            RuleFor(c => c.Email).MustBeValueObject(Email.Create);
            RuleFor(c => c.Experience).MustBeValueObject(Experience.Create);
            RuleFor(c => c.PhoneNumber).MustBeValueObject(PhoneNumber.Create);
        }
    }
}
