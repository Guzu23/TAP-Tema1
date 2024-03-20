using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //The visitor role
    internal class Visitor : BaseUser
    {
        DateTime expirationDate;

        public Visitor(string name, string email, string pass) : base(name, email, pass)
        {
            this.expirationDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            this.expirationDate.AddDays(1);
        }
    }
}
