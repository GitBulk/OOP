using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    class OrCriteria : ICriteria
    {
        private ICriteria firstCriteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria firstCriteria, ICriteria otherCriteria)
        {
            this.firstCriteria = firstCriteria;
            this.otherCriteria = otherCriteria;
        }

        public IEnumerable<Person> Filter(IEnumerable<Person> people)
        {
            IList<Person> first = firstCriteria.Filter(people).ToList();
            IEnumerable<Person> other = otherCriteria.Filter(people);
            foreach (var item in other)
            {
                if (first.Contains(item) == false)
                {
                    first.Add(item);
                }
            }
            return first;
        }
    }
}
