using PetFamily.Application.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Application.Volunteers.UpdateSocialNetworks
{
    public record UpdateSocialNetworksRequest(Guid VolunteerId, UpdateSocialNetworksDto Dto);
}
