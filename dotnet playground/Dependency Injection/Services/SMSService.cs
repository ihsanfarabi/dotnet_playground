namespace Dotnet_Playground.Dependency_Injection.Services
{
    public class SmsService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}