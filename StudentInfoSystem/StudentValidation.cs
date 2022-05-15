using System;
using System.Collections.Generic;
using System.Linq;
using UserLogin;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        Student GetStudentDataByYser(UserLogin.User user)
        {
            Student student = new Student();
            if (user.number == null || user.number.Equals(user.number))
            {
                Console.WriteLine("There is not student with this faculty number.");
                return null;
            }

            return (from stud in StudentData.TestStudents where stud.facultyNumber == user.number select stud).First();

        }

    }
}
