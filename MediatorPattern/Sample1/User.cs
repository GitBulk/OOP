using System;

namespace MediatorPattern.Sample1
{
    class User : IAction
    {
        public string Name { get; set; }
        public User(string fullName)
        {
            this.Name = fullName;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(this.Name + " received " + message);
        }
        
        public void SendMessage(IMediator hub, string message)
        {
            hub.DistributeMessage(this, message);
        }
    }
}
