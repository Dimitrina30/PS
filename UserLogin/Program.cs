using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            User user1 = new User("Rachel", "1212", "0101552",250 );
            Console.WriteLine(user1.userName);
            Console.WriteLine(user1.pass);
            Console.WriteLine(user1.number);
            Console.WriteLine(user1.userRole);
            */

            User user1 = new User();
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string pass = Console.ReadLine();
            LoginValidation validation = new LoginValidation(username, pass, errorFunc);

            if (validation.ValidateUserInput(ref user1))
            {
                Console.WriteLine("The username is:" + user1.userName);
                Console.WriteLine("The password is:" + user1.pass);
                Console.WriteLine("The faculty number is:" + user1.number);
                Console.WriteLine("The date of creation is:" + user1.time);
                Console.WriteLine("The validation's term of the user is:" + user1.term);
            }

            void errorFunc(string message)
            {
                Console.WriteLine("! ! !" + message + "! ! !");
            }

            void menu()
            {
                Console.WriteLine("\n Choose option:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Change user's role");
                Console.WriteLine("2: Change user's expire validation");
                Console.WriteLine("3: Print all users");
                Console.WriteLine("4: Logging activity preview");

                Console.WriteLine("5: Current logging activity preview");


                int choice = new int();
                while (choice != 0)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 0)
                    {
                        Console.WriteLine("Exit");

                    }
                    else if (choice == 1)
                    {
                        Console.WriteLine("Change of user'role.");
                        changeRole();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Change of user'validation date.");
                        changeData();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("All users are:");
                        printAllUsers();

                    }
                    else if (choice == 4)
                    {
                        IEnumerable<string> fileContent = Logger.getFileContent();
                        fileContent = File.ReadLines("test.txt");
                        foreach (string line in fileContent)
                        {
                            Console.WriteLine(line);
                        }


                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Choose filetr: ");
                        string filter = Console.ReadLine();
                        StringBuilder sb = new StringBuilder();
                        IEnumerable<string> currentActs = Logger.GetCurrentSessionActivity(filter);
                        foreach (string line in currentActs)
                        {
                            sb.AppendLine(line);
                        }
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Your choice is not valid!");
                    }

                }
            }



            void changeRole()
            {
                string name;
                UserRoles newRole;
                Console.WriteLine("Enter the username and his new role:");
                name = Console.ReadLine();
                newRole = (UserRoles)int.Parse(Console.ReadLine());
                UserData.AssignUserRole(name, (UserRoles)newRole);

            }

            void changeData()
            {
                string name;
                string newDate;
                Console.WriteLine("Enter the username and his new date of validation:");
                name = Console.ReadLine();
                newDate = Console.ReadLine();
                UserData.SetUserActiveTo(name, Convert.ToDateTime(newDate));

            }

            string showContent()
            {
                string contentOfFile = File.ReadAllText("test.txt");
                return contentOfFile;
            }

            void printAllUsers()
            {
                foreach (var user in UserData.ТestUser)
                {
                    Console.WriteLine("The username is:" + user.userName);
                    Console.WriteLine("The password is:" + user.pass);
                    Console.WriteLine("The faculty number is:" + user.number);
                    Console.WriteLine("The user role is:" + user.userRole);
                    Console.WriteLine("The date of creation is:" + user.time);
                    Console.WriteLine("The validation's term of the user is:" + user.term);
                }
            }






            /*
            LoginValidation obj = new LoginValidation();
            if(obj.ValidateUserInput())
            {
            
                Console.WriteLine(LoginValidation.currentUserRole);
            }
            */
        }
    }
}