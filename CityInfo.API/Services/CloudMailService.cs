namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {

        private string _mailTo = String.Empty;
        private string _mailFrom = String.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            _mailTo = configuration["MailSettings:mailToAddress"];
            _mailFrom = configuration["MailSettings:mailFromAddress"];
        }
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from{_mailFrom} to {_mailTo} with {nameof(CloudMailService)}");
            Console.WriteLine($"subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}

