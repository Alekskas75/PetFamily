using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class Requisites
    {  
        public Requisites() { }
        public Guid Id { get; private set; }  //исправил2
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Target { get; private set; }
        public string Check { get; private set; }
        public string CardNumber { get; private set; }
        
    }
}
