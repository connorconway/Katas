using System.Threading.Tasks;
using BirthdayGreetings.Core;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BirthdayGreetings
{
    //This would be tested at an integration or end-to-end test level 
    public class EmailService : INotificationService
    {
        private readonly ISendGridClient _client;
        private readonly string _fromEmail;
        private readonly string _fromName;
        private readonly string _subject;
        private readonly string _recipientsEmail;

        public EmailService(string subject, string recipientsEmail)
        {
            _client = new SendGridClient("someApiKey");
            _fromEmail = "no-reply@fromemail.com";
            _fromName = "Me";
            _subject = subject;
            _recipientsEmail = recipientsEmail;
        }

        public async Task Send(string message)
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress(_fromEmail, _fromName));
            msg.AddTo(_recipientsEmail);
            msg.SetSubject(_subject);
            msg.AddContent(MimeType.Html, message);
            await _client.SendEmailAsync(msg);
        }
    }
}