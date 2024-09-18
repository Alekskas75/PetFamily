using PetFamily.Application.Dtos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Application.Volunteers.UpdateMainInfo
{
    public record UpdateMainInfoRequest(Guid VolunteerId, UpdateMainInfoDto Dto);
}
