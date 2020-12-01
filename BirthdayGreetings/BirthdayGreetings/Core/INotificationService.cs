using System.Threading.Tasks;

namespace BirthdayGreetings.Core
{
    public interface INotificationService
    {
        Task Send(string message);
    }
}