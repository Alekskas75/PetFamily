using CSharpFunctionalExtensions;

using PetFamily.Domain.AnimalManagement.AggregateRoot;
using PetFamily.Domain.AnimalManagement.IDs;
using PetFamily.Domain.Shared;

namespace PetFamily.Application
{
    public interface IVolunteersRepository
    {
        Task<Guid> Add(Volunteer volunteer, CancellationToken cancellationToken = default);

        Task<Guid> Save(Volunteer volunteer, CancellationToken cancellationToken = default);

        Task<Guid> Delete(Volunteer volunteer, CancellationToken cancellationToken = default);

        Task<Result<Volunteer, Error>> GetById(VolunteerId volunteerId, CancellationToken cancellationToken = default);
    }
}
