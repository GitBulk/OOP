using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Sample1
{
    // The Factory Method pattern is a way of creating objects,
    // but letting subclasses decide exactly which class to instantiate.
    // Various subclasses might implement the interface; the Factory Method
    // instantiates the appropriate subclass based on information supplied
    // by the client or extracted from the current state.
    public abstract class Student
    {
        private List<Subject> subjects = new List<Subject>();

        public List<Subject> Subjects { get { return this.subjects; } }

        public Student()
        {
            this.CreateStudent();
        }

        public void Learn()
        {
            foreach (var item in Subjects)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }

        // Factory Method
        protected abstract void CreateStudent();
    }
}
