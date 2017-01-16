using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();


            //var juniorStudent = new JuniorStudent();
            //juniorStudent.FullName = "kaka";
            //students.Add(juniorStudent);
            //Console.WriteLine(juniorStudent.Grade);
            //Console.ReadLine();

            //List<string> names = new List<string>();
            //names.Add("Ali");
            //names.Add("Al");
            //names.Add("Aki");
            //names.Sort();
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            
            CallCenter.Program.Excute();
        }


        static int AverageNumberOfLetters(string sentence)
        {
            var arrayString = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int countWord = 0;
            int countLength = 0;
            foreach (var item in arrayString)
            {
                if (item.Length > 1)
                {
                    countWord++;
                    countLength += item.Length;
                }
            }
            return (countLength / countWord);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Student()
        {
            Id = 0;
            FullName = "";
        }
    }

    class JuniorStudent : Student
    {
        public int Grade { get; set; }
        public int MyProperty { get; set; }
        public JuniorStudent() : base()
        {
            this.Grade = 1;
        }
    }
}
