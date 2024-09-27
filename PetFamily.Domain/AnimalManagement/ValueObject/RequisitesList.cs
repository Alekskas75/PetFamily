using PetFamily.Domain.Shared.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
