using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Notification in the form of email
    internal class EmailNotification : INotification
    {
        public void SendNotification(string content, string dest)
        {
            Console.WriteLine("Email notification is sending for: " + dest);
        }
    }
}
