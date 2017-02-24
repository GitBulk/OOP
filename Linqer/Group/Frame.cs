using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqer.Group
{
    class Frame
    {
        public static void Run()
        {
            //JoinFiles();
            //SplitFiles();

            var studentClass = new StudentClass();
            studentClass.GroupBySingleProperty();
            Console.ReadLine();
        }

        public static void Columns()
        {
            string[] lines = File.ReadAllLines(@"../../names.csv");
            int exam = 3;
            SingleColumn(lines, exam + 1);
        }

        public static void SingleColumn(IEnumerable<string> strs, int examNum)
        {
            Console.WriteLine("Single column query");
            var columnQuery = from line in strs
                              let elements = line.Split(',')
                              select Convert.ToInt32(elements[examNum]);

            var results = columnQuery.ToList();

            double avg = results.Average();
            int max = results.Max();
            int min = results.Min();

            Console.WriteLine("Exam #{0}: Average:{1:##.##} High Score:{2} Low Score:{3}",
                examNum, avg, max, min);
        }

        public static void JoinFiles()
        {
            string[] names = File.ReadAllLines(@"../../names.csv");
            string[] scores = File.ReadAllLines(@"../../scores.csv");
            
            IEnumerable<string> scoreQuery1 = from name in names
                                              let nameFields = name.Split(',')
                                              from id in scores
                                              let scoreFields = id.Split(',')
                                              where nameFields[2].Trim() == scoreFields[0].Trim()
                                              select nameFields[0] + "," + scoreFields[1] + "," + scoreFields[2]
                                                + "," + scoreFields[3] + "," + scoreFields[4];

            // Pass a query variable to a method and execute it  
            // in the method. The query itself is unchanged.  
            OutputQueryResults(scoreQuery1, "Merge two spreadsheets:");

            // Keep console window open in debug mode.  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static void OutputQueryResults(IEnumerable<string> query, string message)
        {
            Console.WriteLine(System.Environment.NewLine + message);
            foreach (string item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("{0} total names in list", query.Count());
        }

        public static void SplitFiles()
        {
            string[] fileA = File.ReadAllLines(@"../../names1.txt");
            string[] fileB = File.ReadAllLines(@"../../names2.txt");

            // Concatenate and remove duplicate names based on  
            // default string comparer  
            var mergeQuery = fileA.Union(fileB);

            // Group the names by the first letter in the last name.
            var groupQuery = from name in mergeQuery
                             let n = name.Split(',')
                             group name by n[0][0] into newGroup
                             orderby newGroup.Key
                             select newGroup;
            foreach (var item in groupQuery)
            {
                // Create the new file name.  
                string fileName = @"../../testFile_" + item.Key + ".txt";

                // Output to display.  
                Console.WriteLine(item.Key);
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (var subItem in item)
                    {
                        sw.WriteLine(subItem);
                        // Output to console for example purposes.  
                        Console.WriteLine("   {0}", subItem);
                    }
                }
            }
            // Keep console window open in debug mode.  
            Console.WriteLine("Files have been written. Press any key to exit");
            Console.ReadKey();
        }
    }

    class StudentClass
    {
        #region data
        protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public GradeLevel Year;
            public List<int> ExamScores;
        }

        protected static List<Student> students = new List<Student>
        {
            new Student {FirstName = "Terry", LastName = "Adams", ID = 120,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 99, 82, 81, 79}},
            new Student {FirstName = "Fadi", LastName = "Fakhouri", ID = 116,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 99, 86, 90, 94}},
            new Student {FirstName = "Hanying", LastName = "Feng", ID = 117,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 93, 92, 80, 87}},
            new Student {FirstName = "Cesar", LastName = "Garcia", ID = 114,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 97, 89, 85, 82}},
            new Student {FirstName = "Debra", LastName = "Garcia", ID = 115,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 35, 72, 91, 70}},
            new Student {FirstName = "Hugo", LastName = "Garcia", ID = 118,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 92, 90, 83, 78}},
            new Student {FirstName = "Sven", LastName = "Mortensen", ID = 113,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 88, 94, 65, 91}},
            new Student {FirstName = "Claire", LastName = "O'Donnell", ID = 112,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 75, 84, 91, 39}},
            new Student {FirstName = "Svetlana", LastName = "Omelchenko", ID = 111,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 97, 92, 81, 60}},
            new Student {FirstName = "Lance", LastName = "Tucker", ID = 119,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 68, 79, 88, 92}},
            new Student {FirstName = "Michael", LastName = "Tucker", ID = 122,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 94, 92, 91, 91}},
            new Student {FirstName = "Eugene", LastName = "Zabokritski", ID = 121,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 96, 85, 91, 60}}
        };
        #endregion

        //Helper method, used in GroupByRange.
        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }

        public void QueryHighScores(int exam, int score)
        {
            var highScores = from stu in students
                             where stu.ExamScores[exam] > score
                             select new
                             {
                                 Name = stu.FirstName,
                                 Score = stu.ExamScores[exam]
                             };
            foreach (var item in highScores)
            {
                Console.WriteLine("{0,-15}{1}", item.Name, item.Score);
            }
        }

        public void GroupBySingleProperty()
        {
            Console.WriteLine("Group by a single property in an object:");

            // Variable queryLastNames is an IEnumerable<IGrouping<string, 
            // DataClass.Student>>. 
            var queryLastName = from stu in students
                                group stu by stu.LastName into ng
                                orderby ng.Key
                                select ng;

            foreach (var groupItem in queryLastName)
            {
                Console.WriteLine("Key: {0}", groupItem.Key);
                foreach (var item in groupItem)
                {
                    Console.WriteLine("\t{0}, {1}", item.LastName, item.FirstName);
                }
            }
        }

    }
}
