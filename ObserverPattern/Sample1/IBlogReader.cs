using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Sample1
{
    public interface IBlogReader
    {
        void ReceiveMessage(string content);
    }
}
