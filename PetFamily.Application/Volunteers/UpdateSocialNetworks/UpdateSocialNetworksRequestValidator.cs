using FluentValidation;
using PetFamily.Application.Dtos;
using PetFamily.Application.Validation;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Shared.ValueObjects;

namespace PetFamily.Application.Volunteers.UpdateSocialNetworks
{
    public class UpdateSocialNetworksRequestValidator : AbstractValidator<UpdateSocialNetworksRequest>
    {
        public UpdateSocialNetworksRequestValidator()
        {
            RuleFor(u => u.VolunteerId).NotEmpty().WithError(Errors.General.ValueIsRequired());
        }
    }

    public class UpdateSocialNetworksDtoValidator : AbstractValidator<UpdateSocialNetworksDto>
    {
        public UpdateSocialNetworksDtoValidator()
        {
            RuleForEach(u => u.SocialNetworks)
                .MustBeValueObject(r => SocialNetwork.Create(r.Name, r.Url));
        }
    }
}
