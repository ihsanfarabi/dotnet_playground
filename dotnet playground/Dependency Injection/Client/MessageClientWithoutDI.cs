using Dotnet_Playground.Dependency_Injection.Services;

namespace Dotnet_Playground.Dependency_Injection.Client
{
    public class MessageClientWithoutDi
    {
        public void SendMessageEmail(string message)
        {
            var emailService = new EmailService();
            emailService.SendMessage(message);
        }

        public void SendMessageSms(string message)
        {
            var smsService = new SmsService();
            smsService.SendMessage(message);
        }
    }
}