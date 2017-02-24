using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    class AndCriteria : ICriteria
    {
        private ICriteria firstCriteria;
        private ICriteria otherCriteria;

        public AndCriteria(ICriteria firstCriteria, ICriteria otherCriteria)
        {
            this.firstCriteria = firstCriteria;
            this.otherCriteria = otherCriteria;
        }

        public IEnumerable<Person> Filter(IEnumerable<Person> people)
        {
            IEnumerable<Person> result = this.firstCriteria.Filter(people);
            return this.otherCriteria.Filter(result);
        }
    }
}
