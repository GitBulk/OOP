using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            var people = new List<Person>();
            people.Add(new Person("David", Gender.Male, MarialStatus.Single));
            people.Add(new Person("John", Gender.Male, MarialStatus.Married));
            people.Add(new Person("Laura", Gender.Female, MarialStatus.Married));

            people.Add(new Person("Diana", Gender.Female, MarialStatus.Single));
            people.Add(new Person("Mike", Gender.Male, MarialStatus.Single));
            people.Add(new Person("Bobby", Gender.Male, MarialStatus.Single));
            ICriteria maleCriteria = new MaleCriteria();
            ICriteria femaleCriteria = new FemaleCriteria();
            ICriteria singleCriteria = new SingleCriteria();
            ICriteria maleSingle = new AndCriteria(maleCriteria, singleCriteria);
            ICriteria singleOrFemale = new OrCriteria(singleCriteria, femaleCriteria);

            Console.WriteLine("Males: ");
            PrintPeople(maleCriteria.Filter(people));
            Console.WriteLine("Females: ");
            PrintPeople(femaleCriteria.Filter(people));
            Console.WriteLine("Single males: ");
            PrintPeople(maleSingle.Filter(people));
            Console.WriteLine("Single or females: ");
            PrintPeople(singleOrFemale.Filter(people));

            Console.ReadLine();
        }

        private static void PrintPeople(IEnumerable<Person> people)
        {
            foreach (var person in people)
            {
                //Console.WriteLine("Person : [ Name : " + person.FullName + ", Gender : " + person.Gender + ", Marital Status : " + person.MarialStatus + " ]");
                Console.WriteLine($"Person : [ Name : { person.FullName }, Gender : { person.Gender }, Marital Status : { person.MarialStatus } ]");
            }
        }
    }
}
