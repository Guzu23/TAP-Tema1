using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    public abstract class BaseUser : ILogger, INotification
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public List<String> authorizedRooms = new List<String>();
        private int loginAttempts = 0;
        private bool isLoggedIn = false;
        public List<Email> emails = new List<Email>();

        public BaseUser(string name, string email, string pass) { 
            id= Guid.NewGuid();
            this.name = name;
            this.email = email;
            this.pass = pass;
            this.isActive = true;
            addAuthorizedRooms();
        }

        public void addAuthorizedRooms()
        {
            authorizedRooms.Add("Canteen");
            authorizedRooms.Add("P0.0");
            authorizedRooms.Add("P0.1");
            authorizedRooms.Add("P1.0");
            authorizedRooms.Add("P1.1");
            authorizedRooms.Add("P1.5");
            authorizedRooms.Add("P2.4");
            authorizedRooms.Add("P3.17");
            authorizedRooms.Add("Front Enter/Exit");
        }

        public void SetActive(bool active)
        {
            this.isActive = active;
        }

        public void login(string email, string pass)
        {
            if (loginAttempts >= 3)
            {
                Console.WriteLine("You tried too many times to login! Contact someone from the Cybersecurity department!");
                return;
            }
            if (this.email == email && this.pass == pass)
            { 
                Console.WriteLine("The user " + this.email + " logged in!");
                this.isLoggedIn = true;
                loginAttempts = 0;
            }
            else
            {
                Console.WriteLine("The email and the password are wrong!");
                loginAttempts++;
            }
            
        }

        public void logout()
        {
            if(isLoggedIn)
            {
                Console.WriteLine("The user " + this.email + " logged out!");
                this.isLoggedIn = false;
            }
            
        }

        public void resetLoginAttempts()
        {
            loginAttempts = 0;
        }

        //Basically sends the email from "sender"(this object/user) to "receiverEmail" with the content stored in the variable "content"
        public void SendNotification(string content, string receiverEmail)
        {
            //You have to be logged in to send an email
            if (!isLoggedIn) {
                Console.WriteLine("ERROR: THIS USER IS NOT LOGGED IN!");
                return; 
            }
            Console.WriteLine("Email notification is sending for: " + receiverEmail + " from " + this.email + " with the content:\n" + content);
            Email email = new Email(this.email, receiverEmail, content);
            this.emails.Add(email);

            //We have 2 lists: Visitors and Employees, so we have to search through both of them for the email address
            int receiverIndex = Data.Employees.FindIndex(x => x.email == receiverEmail);
            //If the receiver is not an employee
            if(receiverIndex < 0)
            {
                receiverIndex = Data.Visitors.FindIndex(x => x.email == receiverEmail);
                //If the receiver is not even a visitor it means that the email address is not in the database
                if(receiverIndex < 0)
                {
                    Console.WriteLine("This email does not exist!");
                }
                else
                {
                    //Add the email to the visitor email list
                    Data.Visitors[receiverIndex].emails.Add(email);
                }
            }
            else
            {
                //Add the email to the employee email list
                Data.Employees[receiverIndex].emails.Add(email); 
            }
            
        }
    }
}
