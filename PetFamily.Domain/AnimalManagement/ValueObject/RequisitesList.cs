using PetFamily.Domain.Shared.ValueObjects;

namespace PetFamily.Domain.AnimalManagement.ValueObject
{
    public record RequisitesList
    {
        private RequisitesList()
        {
        }

        public RequisitesList(IEnumerable<Requisite> requisites)
        {
            Requisites = requisites.ToList();
        }

        public IReadOnlyList<Requisite> Requisites { get; }
    }
}
