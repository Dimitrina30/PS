using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {

        private string _userName;
        private string _password;
        private string _errorLog;
        static public UserRoles currentUserRole { get; private set; }
        public static string currentUserUsername { get; private set; }
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError _errorNew;


        public LoginValidation(string name, string pass, ActionOnError error)
        {
            _userName = name;
            _password = pass;
            _errorNew = new ActionOnError(error);
        }


        public Boolean ValidateUserInput(ref User user)
        {

            bool emptyUserName = _userName.Equals(String.Empty);
            if (emptyUserName)
            {
                _errorLog = "Username is not valid";
                _errorNew(_errorLog);
                return false;
            }
            bool shortName = _userName.Length < 5;
            if (shortName)
            {
                _errorLog = "The name is short!";
                _errorNew(_errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }



            bool emptyPassword = _password.Equals(String.Empty);
            if (emptyPassword)
            {
                _errorLog = "Password is not valid";
                _errorNew(_errorLog);
                return false;
            }
            bool shortPass = _password.Length < 5;
            if (shortPass)
            {
                _errorLog = "The password is too short!";
                _errorNew(_errorLog);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            user = UserData.IsUserPassCorrect(_userName, _password);
            if (user != null)
            {
                currentUserRole = (UserRoles)user.userRole;
                currentUserUsername = _userName;
                // Logger.LogActivity("Successful Login");
                return true;
            }
            else
            {
                _errorLog = "Not such user found!";
                _errorNew(_errorLog);
                currentUserUsername = null;
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            /*
           if (string.IsNullOrEmpty(name1) || string.IsNullOrEmpty(pass1))
           {
              return false;
           }

           currentUserRole = UserRoles.ADMIN;

           */
            return true;

        }

    }
}