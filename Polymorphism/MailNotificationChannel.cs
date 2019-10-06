using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MailNotificationChannel: INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("sending mail...");
        }
    }
}
