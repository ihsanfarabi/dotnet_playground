using Dotnet_Playground.Dependency_Injection.Client;
using Dotnet_Playground.Dependency_Injection.Services;

// with DI
var emailService = new EmailService();
var smsService = new SmsService();
var emailMessageClient = new MessageClient(emailService);
var smsMessageClient = new MessageClient(smsService);

emailMessageClient.SendMessage("with DI");
smsMessageClient.SendMessage("with DI");

// without DI
var messageClient = new MessageClientWithoutDi();
messageClient.SendMessageEmail("without DI, using concrete object");
messageClient.SendMessageSms("without DI, using concrete object");

