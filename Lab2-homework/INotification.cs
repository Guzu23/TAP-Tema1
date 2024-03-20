using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Interface to send a notification: email, mail, sms
    internal interface INotification
    {
        public void SendNotification(string content, string dest);
    }
}
