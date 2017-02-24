using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Sample1
{
    interface IAction
    {
        void SendMessage(IMediator hub, string message);
        void ReceiveMessage(string message);

    }
}
