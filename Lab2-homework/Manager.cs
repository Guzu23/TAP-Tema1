using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Manager role
    internal class Manager : Employee, Work
    {
        public Manager(string name, string email, string pass, float salary, string computerID, string ImageProfile) : base(name, email, pass, salary, computerID, ImageProfile)
        {
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public Manager(Employee employee)
        : base(employee.name, employee.email, employee.pass, employee.salary, employee.computerID, employee.ImageProfile) // Assuming these are the properties of Employee
        {
            this.id = employee.id;
            this.computerPermissions = employee.computerPermissions;
            this.ongoingProjects = employee.ongoingProjects;
            this.authorizedRooms = employee.authorizedRooms;
            this.isActive = employee.isActive;
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public new void addAuthorizedRooms()
        {
            authorizedRooms.Add("P0.9");
            authorizedRooms.Add("P0.19");
            authorizedRooms.Add("P1.9");
            authorizedRooms.Add("P1.19");
            authorizedRooms.Add("P1.32");
            authorizedRooms.Add("P2.14");
            authorizedRooms.Add("P3.23");

            authorizedRooms.Add("P0.7");
            authorizedRooms.Add("P0.17");
            authorizedRooms.Add("P1.7");
            authorizedRooms.Add("P1.17");
            authorizedRooms.Add("P1.33");
            authorizedRooms.Add("P2.15");
            authorizedRooms.Add("P3.24");

            authorizedRooms.Add("P0.4");
            authorizedRooms.Add("P0.5");
            authorizedRooms.Add("P1.6");
            authorizedRooms.Add("P1.16");
            authorizedRooms.Add("P1.36");
            authorizedRooms.Add("P2.16");
            authorizedRooms.Add("P3.26");

            authorizedRooms.Add("P0.8");
            authorizedRooms.Add("P0.18");
            authorizedRooms.Add("P1.8");
            authorizedRooms.Add("P1.18");
            authorizedRooms.Add("P1.38");
            authorizedRooms.Add("P2.18");
            authorizedRooms.Add("P3.28");
        }

        public new void addComputerPermissions()
        {
            computerPermissions.Add("Administrator");
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
