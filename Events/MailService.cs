using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class MailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Notifying users by Email...");
            Console.WriteLine("   Mail message: " + message);
        }
    }
}
