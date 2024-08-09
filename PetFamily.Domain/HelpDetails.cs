using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class HelpDetails
    {  
        public HelpDetails() { }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Target { get; set; }
        public string Check { get; set; }
        public string CardNumber { get; set; }
        
    }
}
