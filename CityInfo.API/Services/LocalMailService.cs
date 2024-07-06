﻿

namespace CityInfo.API.Services

{
    public class LocalMailService : IMailService
    {
        private string _mailTo = String.Empty;
        private string _mailFrom = String.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            _mailTo = configuration["MailSettings:mailToAddress"];
            _mailFrom = configuration["MailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from{_mailFrom} to {_mailTo} with {nameof(LocalMailService)}");
            Console.WriteLine($"subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
