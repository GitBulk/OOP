using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Sample1
{
    interface IMediator
    {
        List<User> User { get; }
        void Register(User user);
        void DistributeMessage(User sender, string message);
    }
}
