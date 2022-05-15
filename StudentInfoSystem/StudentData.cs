using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        private static List<Student> _testStudent = new List<Student>();
        public static List<Student> TestStudents
        {
            get
            {

                data();
                return _testStudent;
            }
            set { }
        }

        public static void data()
        {
            _testStudent.Add(new Student());
            _testStudent[0].firstName = "Maria";
            _testStudent[0].middleName = "Dimitrova";
            _testStudent[0].lastName = "Ivanova";
            _testStudent[0].faculty = "FCST";
            _testStudent[0].specialty = "CSE";
            _testStudent[0].degree = "bachelor";
            _testStudent[0].status = "assured";
            _testStudent[0].facultyNumber = "12121300";
            _testStudent[0].course = 3;
            _testStudent[0].stream = 9;
            _testStudent[0].group = 31;
        }


    }
}
