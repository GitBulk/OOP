using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Sample1
{
    public class BlogReader : IBlogReader
    {
        public string ReaderName { get; set; }

        public BlogReader(string readerName)
        {
            this.ReaderName = readerName;
        }

        public void ReceiveMessage(string content)
        {
            Console.WriteLine("{0} received: {1}", this.ReaderName, content);
        }
    }
}
