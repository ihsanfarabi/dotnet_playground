using Dotnet_Playground.Dependency_Injection.Services;

namespace Dotnet_Playground.Dependency_Injection.Client
{
    public class MessageClient(IMessageService messageService)
    {
        public void SendMessage(string message)
        {
            messageService.SendMessage(message);
        }
    }
}