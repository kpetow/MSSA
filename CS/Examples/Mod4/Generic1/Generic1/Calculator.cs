using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    public class Calculator<T> where T : struct
    {
        public int Addition(int a, int b)
        {
            return a + b;

        }
    }
}
