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
            JoinFiles();
            //SplitFiles();
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
}
