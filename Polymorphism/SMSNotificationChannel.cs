﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class SMSNotificationChannel:INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Send SMS...");
        }
    }
}
