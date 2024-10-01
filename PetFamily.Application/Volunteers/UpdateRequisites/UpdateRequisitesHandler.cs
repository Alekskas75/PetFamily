using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using PetFamily.Domain.AnimalManagement.ValueObject;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Shared.ValueObjects;

namespace PetFamily.Application.Volunteers.UpdateRequisites
{
    public class UpdateRequisitesHandler
    {
        private readonly ILogger<UpdateRequisitesHandler> _logger;
        private readonly IVolunteersRepository _volunteersRepository;

        public UpdateRequisitesHandler(
            IVolunteersRepository volunteersRepository,
            ILogger<UpdateRequisitesHandler> logger)
        {
            _volunteersRepository = volunteersRepository;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(
            UpdateRequisitesRequest request,
            CancellationToken cancellationToken = default)
        {
            var volunteerResult = await _volunteersRepository.GetById(request.VolunteerId, cancellationToken);

            if (volunteerResult.IsFailure)
                return volunteerResult.Error;

            var requisites = new RequisitesList(request.Dto.Requisites.Select(r =>
                Requisite.Create(r.Name, r.Description).Value));

            volunteerResult.Value.UpdateRequisites(requisites);

            _logger.LogInformation("Volunteer requisites update with id: {VolunteerId}.", request.VolunteerId);

            return await _volunteersRepository.Save(volunteerResult.Value, cancellationToken);
        }
    }
}
