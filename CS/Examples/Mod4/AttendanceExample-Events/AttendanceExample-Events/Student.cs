using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceExample_Events
{
    class Student
    {
        public string grade { get; set; }
        public string name { get; private set; }

        public Student (string name = "George", string grade = "A")
        {
            this.name = name;
            this.grade = grade;
        }

    }
}
