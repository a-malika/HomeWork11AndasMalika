using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(User user, string message)
        {
            Console.WriteLine($"Notification sent to {user.Email}: {message}");
        }
    }
}
