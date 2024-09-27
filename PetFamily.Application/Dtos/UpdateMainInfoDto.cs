namespace PetFamily.Application.Dtos
{
    public record UpdateMainInfoDto(
    FullNameDto FullName,
    string Description,
    string Email,
    int Experience,
    string PhoneNumber);
}
