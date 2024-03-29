using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_c_
{
    public class Users
    {
        string Username { get; set; }
        string Password { get; set; }

        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
