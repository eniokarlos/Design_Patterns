using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace composite
{
    public class Contractor : IEmployed
    {
        public int Id {get;set;}
        public string Name {get;set;}

        public Contractor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        
        
    }
}