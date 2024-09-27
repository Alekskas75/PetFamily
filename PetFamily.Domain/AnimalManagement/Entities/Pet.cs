using PetFamily.Domain.AnimalManagement.IDs;
using PetFamily.Domain.AnimalManagement.ValueObject;
using PetFamily.Domain.Enums;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Shared.ValueObjects;

using Address = PetFamily.Domain.AnimalManagement.ValueObject.Address;

namespace PetFamily.Domain.AnimalManagement.Entities
{
    public class Pet : Entity<PetId>, ISoftDeletable
    {
        private bool _isDeleted = false;

        private Pet(PetId id) : base(id)
        {
        }

        public string Name { get; private set; } = default!;
        public Description Description { get; private set; } = default!;
        public TypeDetails TypeDetails { get; private set; } = default!;
        public string Color { get; private set; } = default!;
        public string HealthInfo { get; private set; } = default!;
        public Address Address { get; private set; } = default!;
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; } = default!;
        public bool IsCastrated { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public bool IsVaccinated { get; private set; }
        public PetStatus Status { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public PetDetails Details { get; private set; } = default!;

        public void Delete()
        {
            if (_isDeleted)
                return;

            _isDeleted = true;
        }

        public void Restore()
        {
            if (!_isDeleted)
                return;

            _isDeleted = false;
        }
    }
}
