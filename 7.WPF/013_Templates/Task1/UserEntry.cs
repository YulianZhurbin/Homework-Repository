using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserEntry
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Status Status { get; private set; }

        public UserEntry(string login, string password, Status status = Status.Simple)
        {
            Login = login;
            Password = password;
            Status = status;
        }
    }

    public enum Status
    {
        Simple,
        Premium
    }
}
