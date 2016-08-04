using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Sample1
{
    class Program
    {
        public static void Excute()
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            Message message = new SystemMessage();
            message.Subject = "Test message";
            message.Body = "Hi, this is a test message";
            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            var userMessage = new UserMessage();
            userMessage.Subject = "Test message";
            userMessage.Body = "Hi, this is a test message";
            userMessage.UserComment = "I hope you are well";
            userMessage.MessageSender = email;
            userMessage.Send();
            Console.ReadLine();
        }
    }
}
