using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
           var videoEncoder = new VideoEncoder();
           videoEncoder.RegistorNotificationChannel(new MailNotificationChannel());
           videoEncoder.RegistorNotificationChannel(new SMSNotificationChannel());

           videoEncoder.Encode(new Video());
        }
    }
}
