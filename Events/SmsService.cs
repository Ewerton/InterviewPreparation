using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SmsService
    {
        public void SendSms(string message)
        {
            Console.WriteLine("Notifying users by SMS...");
            Console.WriteLine("   Sms message: " + message);
        }
    }
}
