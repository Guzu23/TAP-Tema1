using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    
    public class Employee : BaseUser
    {
        public float salary {  get; set; } // ? currency
        public String computerID; // the of the computer the employee uses
        public string ImageProfile { get; set; }
        public List<String> computerPermissions = new List<String>();
        public List<String> ongoingProjects = new List<String>();

        public Employee(string name, string email, string pass, float salary, string computerID, string ImageProfile) : base(name, email, pass)
        {
            this.salary = salary;
            this.computerID = computerID;
            this.ImageProfile = ImageProfile;
            addAuthorizedRooms(); 
            addComputerPermissions();
        }

        public new void addAuthorizedRooms()
        {
            authorizedRooms.Add("Parking");
            authorizedRooms.Add("Back Enter/Exit");
            authorizedRooms.Add("P0.2");
            authorizedRooms.Add("P0.3");
            authorizedRooms.Add("P0.6");
            authorizedRooms.Add("P1.2");
            authorizedRooms.Add("P1.3");
            authorizedRooms.Add("P1.7");
            authorizedRooms.Add("P2.7");
            authorizedRooms.Add("P2.8");
        }

        public void addComputerPermissions()
        {
            computerPermissions.Add("Base things");
        }

        public void addProject(String projectID)
        {
            if (!ongoingProjects.Contains(projectID))
            {
                ongoingProjects.Add(projectID);
                Console.WriteLine("The project " + projectID + " was added!");
            }
            else Console.WriteLine("The project " + projectID + " is already on the list!");
        }

        public void removeProject(String projectID)
        {
            if (ongoingProjects.Contains(projectID))
            {
                ongoingProjects.Remove(projectID);
                Console.WriteLine("The project " + projectID + " was removed!");
            }
            else Console.WriteLine("The project " + projectID + " is not on the list!");
        }
    }
}
