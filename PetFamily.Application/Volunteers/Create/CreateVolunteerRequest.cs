using PetFamily.Application.Dtos;

namespace PetFamily.Application.Volunteers.Create
{
    public record CreateVolunteerRequest(
      FullNameDto FullName,
      string Description,
      string Email,
      int Experience,
      string PhoneNumber,
      List<SocialNetworkDto> SocialNetworks,
      List<RequisiteDto> Requisites);
}
