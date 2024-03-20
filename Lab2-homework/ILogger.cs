using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_homework
{
    //Interface for logging in, out
    internal interface ILogger
    {
        void login(string email, string pass);
        void logout();
        void resetLoginAttempts();
    }
}
