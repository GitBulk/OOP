using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            Console.WriteLine("Mediator Pattern");
            User ronaldo = new User("Ronaldo");
            User bale = new User("Bale");
            User ramos = new User("Ramos");

            IMediator hubOne = new ChatRoom();
            hubOne.Register(ronaldo);
            hubOne.Register(bale);
            hubOne.Register(ramos);
            ronaldo.SendMessage(hubOne, "Message to HubOne from " + ronaldo.Name);

            User rooney = new User("Rooney");
            IMediator hubOldFriend = new ChatRoom();
            hubOldFriend.Register(ronaldo);
            hubOldFriend.Register(rooney);
            ronaldo.SendMessage(hubOldFriend, "Hello old friend");
            Console.ReadLine();
        }
    }
}
