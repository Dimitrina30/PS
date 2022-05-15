using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {

        private static List<User> _testUser = new List<User>();
        static public List<User> ТestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }



        static public User IsUserPassCorrect(string name, string pass)
        {
            /*
            foreach (var userCheck in _testUser)
            {
                if (userCheck.userName.Equals(name) && userCheck.pass.Equals(pass))

                {
                    return userCheck;
                }
            }
            return null;
            */

            IEnumerable<User> users = (from user in _testUser
                                       where user.userName.Equals(name) &&
                user.pass.Equals(pass)
                                       select user).ToList();

            return users.FirstOrDefault();


        }

        static public void SetUserActiveTo(string name, DateTime date)
        {
            foreach (var user in _testUser)
            {
                user.term = date;


            }
        }

        static public void AssignUserRole(string name, UserRoles role)
        {
            foreach (var user in _testUser)
            {
                if (user.userName.Equals(name))
                {
                    user.userRole = role;

                }
            }
        }



        static private void ResetTestUserData()
        {

            if (_testUser.Count == null)
            {
                _testUser.Add(new User());
                _testUser[0].userName = "Admin1";
                _testUser[0].pass = "123456";
                _testUser[0].number = "1";
                _testUser[0].time = DateTime.Now;
                _testUser[0].term = DateTime.MaxValue;
                _testUser[0].userRole = UserRoles.ADMIN;



                _testUser.Add(new User());
                _testUser[1] = new User();
                _testUser[1].userName = "Student1";
                _testUser[1].pass = "010101";
                _testUser[1].number = "121219";
                _testUser[1].time = DateTime.Now;
                _testUser[1].term = DateTime.MaxValue;
                _testUser[0].userRole = UserRoles.STUDENT;



                _testUser.Add(new User());
                _testUser[2] = new User();
                _testUser[2].userName = "Student2";
                _testUser[2].pass = "020202";
                _testUser[2].number = "121213";
                _testUser[2].time = DateTime.Now;
                _testUser[2].term = DateTime.MaxValue;
                _testUser[2].userRole = UserRoles.STUDENT;
            }

        }

    }
}