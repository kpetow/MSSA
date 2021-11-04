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

        public Teacher (ref int teacher, ref int employee)
        {
            teacher++;
            employee++;
            this.teacherID = teacher;
        }
    }
}