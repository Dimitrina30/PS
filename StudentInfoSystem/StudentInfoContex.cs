using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentInfoSystem
{
    internal class StudentInfoContex : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
      
        public StudentInfoContex() : base(Properties.Settings.Default.DbConnect)
        {

        }

        /*

        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            if (queryStudents == null)
            {
                return false;
            }
            int countStudents = queryStudents.Count();
            return true;
        }

        public void CopyTestStudents()
        {
           StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
            if (TestStudentsIfEmpty())
                CopyTestStudents();
        }
        */
        
    }
}
