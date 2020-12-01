using System.Collections.Generic;
using System.Threading.Tasks;
using BirthdayGreetings.Core;

namespace BirthdayGreetings.Test.Core
{
    public class TestNotificationService : INotificationService
    {
        public Task Send(string message)
        {
            DataSent.Add(new NotificationData
            {
                Message = message,
                Subject = "subject",
                RecipientsEmail = "recipientEmail"
            });

            return Task.CompletedTask;
        }

        public List<NotificationData> DataSent { get; } = new List<NotificationData>();
    }

    public class NotificationData
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string RecipientsEmail { get; set; }
    }
}