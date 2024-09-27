using FluentValidation;
using PetFamily.Application.Dtos;
using PetFamily.Application.Validation;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Shared.ValueObjects;

namespace PetFamily.Application.Volunteers.UpdateRequisites
{
    public class UpdateRequisitesRequestValidator : AbstractValidator<UpdateRequisitesRequest>
    {
        public UpdateRequisitesRequestValidator()
        {
            RuleFor(u => u.VolunteerId).NotEmpty().WithError(Errors.General.ValueIsRequired());
        }
    }

    public class UpdateRequisitesDtoValidator : AbstractValidator<UpdateRequisitesDto>
    {
        public UpdateRequisitesDtoValidator()
        {
            RuleForEach(u => u.Requisites)
                .MustBeValueObject(r => Requisite.Create(r.Name, r.Description));
        }
    }
}
