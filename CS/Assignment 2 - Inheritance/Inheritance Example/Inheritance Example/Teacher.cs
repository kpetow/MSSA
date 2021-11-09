using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Employee
    {
        private int teacherID;
        private string classes;

        public void setClasses(string classes)
        {
            this.classes = classes;
        }
        public string getClasses()
        {
            return this.classes;
        }

        public Teacher (ref int teacher, ref int employee)
        {
            teacher++;
            employee++;
            this.teacherID = teacher;
        }
    }
}