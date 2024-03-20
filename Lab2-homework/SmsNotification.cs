using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Notificationn in the form of SMS
    internal class SmsNotification : INotification
    {
        public void SendNotification(string content, string dest)
        {
            Console.WriteLine("Sms notification sending for: " + dest);
        }
    }
}
