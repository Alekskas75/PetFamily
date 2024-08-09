using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class PetPhoto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool MainPhoto { get; set; }
    }
}
