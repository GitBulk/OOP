using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Sample1
{
    public class VietnamStudent : Student
    {
        public override void CreateStudent()
        {
            Subjects.Add(new Math());
            Subjects.Add(new Physics());
            Subjects.Add(new Literature());
        }
    }
}
