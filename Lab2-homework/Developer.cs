using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Developer role
    internal class Developer : Employee, Work
    {
        
        public Developer(string name, string email, string pass, float salary, string computerID, string ImageProfile) : base(name, email, pass, salary, computerID, ImageProfile)
        {
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public Developer(Employee employee)
        : base(employee.name, employee.email, employee.pass, employee.salary, employee.computerID, employee.ImageProfile) // Assuming these are the properties of Employee
        {
            this.id = employee.id;
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
        }

        public new void addComputerPermissions()
        {
            computerPermissions.Add("Bash");
            computerPermissions.Add("Cmd");
            computerPermissions.Add("Download");
            computerPermissions.Add("Install");
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
