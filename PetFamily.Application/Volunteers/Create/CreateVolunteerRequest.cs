using PetFamily.Application.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
