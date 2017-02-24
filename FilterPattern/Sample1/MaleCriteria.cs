using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    class MaleCriteria : ICriteria
    {
        public IEnumerable<Person> Filter(IEnumerable<Person> people)
        {
            return people.Where(p => p.Gender == Gender.Male);
        }
    }
}
