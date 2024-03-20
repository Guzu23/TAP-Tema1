using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Designer role
    internal class Designer : Employee, Work
    {
        private String graphicalTabletID;
        public Designer(string name, string email, string pass, float salary, string computerID, string graphicalTabletID, string ImageProfile) : base(name, email, pass, salary, computerID, ImageProfile)
        {
            addAuthorizedRooms();
            addComputerPermissions();
            this.graphicalTabletID = graphicalTabletID;
        }

        public Designer(Employee employee, String graphicalTabletID)
        : base(employee.name, employee.email, employee.pass, employee.salary, employee.computerID, employee.ImageProfile)
        {
            this.id = employee.id;
            this.graphicalTabletID = graphicalTabletID;
            addAuthorizedRooms();
            addComputerPermissions();
        }

        public new void addAuthorizedRooms()
        {
            authorizedRooms.Add("P0.7");
            authorizedRooms.Add("P0.17");
            authorizedRooms.Add("P1.7");
            authorizedRooms.Add("P1.17");
            authorizedRooms.Add("P1.33");
            authorizedRooms.Add("P2.15");
            authorizedRooms.Add("P3.24");
        }

        public new void addComputerPermissions()
        {
            computerPermissions.Add("Sony Vegas Pro");
            computerPermissions.Add("Camtasia");
            computerPermissions.Add("Blender");
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
}
