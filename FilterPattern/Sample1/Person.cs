using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    class Person
    {
        public string FullName { get; set; }

        public Gender Gender { get; set; }

        public MarialStatus MarialStatus { get; set; }

        public Person(string fullName, Gender gender, MarialStatus marialStatus)
        {
            FullName = fullName;
            Gender = gender;
            MarialStatus = marialStatus;
        }
    }
}
