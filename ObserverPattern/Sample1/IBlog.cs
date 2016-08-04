using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Sample1
{
    public interface IBlog
    {
        void AddReader(IBlogReader reader);
        void RemoveReader(IBlogReader readder);
        void NotifyReaders(string message);
    }
}
