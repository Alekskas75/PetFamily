﻿using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using PetFamily.Application;
using PetFamily.Domain.AnimalManagement.AggregateRoot;
using PetFamily.Domain.AnimalManagement.IDs;
using PetFamily.Domain.Shared;
using PetFamily.Infrastructure.Data;

namespace PetFamily.Infrastructure.Repositories
{
    public class VolunteersRepository : IVolunteersRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public VolunteersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Add(
            Volunteer volunteer,
            CancellationToken cancellationToken = default)
        {
            await _dbContext.Volunteer.AddAsync(volunteer, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return volunteer.Id;
        }

        public async Task<Guid> Save(
            Volunteer volunteer,
            CancellationToken cancellationToken = default)
        {
            _dbContext.Volunteer.Attach(volunteer);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return volunteer.Id;
        }

        public async Task<Guid> Delete(Volunteer volunteer, CancellationToken cancellationToken = default)
        {
            _dbContext.Volunteer.Remove(volunteer);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return volunteer.Id;
        }

        public async Task<Result<Volunteer, Error>> GetById(
            VolunteerId volunteerId,
            CancellationToken cancellationToken = default)
        {
            var volunteer = await _dbContext.Volunteer
                .FirstOrDefaultAsync(v => v.Id == volunteerId, cancellationToken);

            if (volunteer is null)
                return Errors.General.NotFound(volunteerId);

            return volunteer;
        }
    }
}
