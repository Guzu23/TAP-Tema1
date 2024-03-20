using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Cybersecurity Analyst role
    internal class Cybersecurity : Employee, Work
    {
        public Cybersecurity(string name, string email, string pass, float salary, string computerID, string ImageProfile) : base(name, email, pass, salary, computerID, ImageProfile)
        {
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public Cybersecurity(Employee employee)
        : base(employee.name, employee.email, employee.pass, employee.salary, employee.computerID, employee.ImageProfile) 
        {
            this.id = employee.id;
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public new void addAuthorizedRooms()
        {

            authorizedRooms.Add("P0.4");
            authorizedRooms.Add("P0.5");
            authorizedRooms.Add("P1.6");
            authorizedRooms.Add("P1.16");
            authorizedRooms.Add("P1.36");
            authorizedRooms.Add("P2.16");
            authorizedRooms.Add("P3.26");
        }

        public new void addComputerPermissions()
        {
            computerPermissions.Add("Root");
            computerPermissions.Add("Kernel");
            computerPermissions.Add("SYSTEM");
            computerPermissions.Add("Superuser");
            computerPermissions.Add("Hardware Control:");
            computerPermissions.Add("System-Level");
            computerPermissions.Add("*");
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
