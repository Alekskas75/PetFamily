using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class PetPhoto
    {
        public Guid Id { get; private set; } //исправил5
        public string Path { get; private set; }
        public bool IsMainPhoto { get; private set; } //исправил7
    }
}
