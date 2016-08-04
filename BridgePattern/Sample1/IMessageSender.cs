namespace BridgePattern.Sample1
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}