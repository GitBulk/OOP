using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern.Sample1
{
    public static class Program
    {
        public static void Excute()
        {
            IBlog writer = new BlogAuthor();
            BlogReader reader1 = new BlogReader("Toan");
            BlogReader reader2 = new BlogReader("Tran");
            writer.AddReader(reader1);
            writer.AddReader(reader2);
            writer.NotifyReaders("This is first message");
            Console.WriteLine();
            writer.RemoveReader(reader2);
            writer.NotifyReaders("This is second message");
            Console.ReadLine();
        }
    }
}
