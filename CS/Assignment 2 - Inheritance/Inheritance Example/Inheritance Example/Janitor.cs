using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Janitor : Employee
    {
        private int janitorID;

        public Janitor(ref int janitor, ref int employee)
        {
            janitor++;
            employee++;
            this.janitorID = janitor;
        }
    }
}
