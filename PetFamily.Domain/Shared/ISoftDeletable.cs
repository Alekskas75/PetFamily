using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Shared
{
    public interface ISoftDeletable
    {
        void Delete();
        void Restore();
    }
}
