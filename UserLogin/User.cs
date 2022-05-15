using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {

        public System.String userName { get; set; }
        public System.String pass { get; set; }
        public System.String number { get; set; }
        public System.DateTime time { get; set; }
        public System.DateTime term { get; set; }
        public UserRoles userRole { get; set; }
        public System.Int32 UserId { get; set; }


        public User(string name, string p, string n, DateTime t, DateTime term, UserRoles r)
        {
            this.userName = name;
            this.pass = p;
            this.number = n;
            this.time = t;
            this.term = term;
            this.userRole = r;

        }

        public User()
        {

        }


    }
}
