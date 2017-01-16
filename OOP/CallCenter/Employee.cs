using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.CallCenter
{
    class Employee
    {
        public Guid Id { get; set; }
        public Rank Rank { get; protected set; }
        public string FullName { get; set; }
        public bool Free { get; set; }        
    }
}
