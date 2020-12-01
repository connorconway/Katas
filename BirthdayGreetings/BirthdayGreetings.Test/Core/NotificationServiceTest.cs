using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace BirthdayGreetings.Test.Core
{
    [TestFixture]
    public class NotificationServiceTest
    {
        [Test]
        public void Send()
        {
            var notificationService = new TestNotificationService();
            notificationService.Send("message");
            var expectedMessages = new List<NotificationData>
            {
                new NotificationData
                {
                    Message = "message",
                    RecipientsEmail = "recipient",
                    Subject = "subject"
                }
            };

            expectedMessages.Should().BeEquivalentTo(notificationService.DataSent);
        }
    }
}