using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Sample1
{
    public class BlogAuthor : IBlog
    {
        private List<IBlogReader> listReaders = new List<IBlogReader>();

        public void AddReader(IBlogReader reader)
        {
            listReaders.Add(reader);
        }

        public void NotifyReaders(string message)
        {
            foreach (var reader in listReaders)
            {
                reader.ReceiveMessage(message);
            }
        }

        public void RemoveReader(IBlogReader readder)
        {
            listReaders.Remove(readder);
        }
    }
}
