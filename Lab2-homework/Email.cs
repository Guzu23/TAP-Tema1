using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    public class Email
    {
        public String sender; // The person that sent the email
        public String receiver; //The person that received the email
        public String content; //The content of the email
        public bool read = false; //If the receiver of the email read the email

        public Email(String sender, String receiver, String content)
        {
            this.sender = sender;
            this.receiver = receiver;   
            this.content = content;
        }

        public void readEmail()
        {
            Console.WriteLine("Email:");
            Console.WriteLine("Sender: " + sender);
            Console.WriteLine("Receiver: " + receiver);
            Console.WriteLine("Content: ");
            Console.WriteLine(content);
            Console.WriteLine("\n");
            this.read = true;
        }
    }
}
