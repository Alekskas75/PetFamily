﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain
{
    public class SocialNetwork
    {           
        public SocialNetwork() { }            
        public Guid Id { get; private set; } //исправил4
        public string Name { get; private set; }
        public string Description { get; private set; }
       
    }
}
