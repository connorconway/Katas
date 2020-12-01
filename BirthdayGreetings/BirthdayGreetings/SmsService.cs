using System;
using System.Threading.Tasks;
using BirthdayGreetings.Core;

namespace BirthdayGreetings
{
    public class SmsService : INotificationService
    {
        public Task Send(string message)
        {
            throw new NotImplementedException("This would send an sms message in the real world");
        }
    }
}