using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Sample1
{
    public class UserMessage : Message
    {
        public string UserComment { get; set; }
        public override void Send()
        {
            string content = string.Format("{0}\nUser Comment: {1}", Body, UserComment);
            MessageSender.SendMessage(Subject, content);
        }
    }
}
