using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Application.Dtos
{
    public record UpdateMainInfoDto(
    FullNameDto FullName,
    string Description,
    string Email,
    int Experience,
    string PhoneNumber);
}
