using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // code to encode
            foreach (var notificationChannel in _notificationChannels)
            {
                notificationChannel.Send("Send");
            }
        }

        public void RegistorNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);
        }
    }
}
