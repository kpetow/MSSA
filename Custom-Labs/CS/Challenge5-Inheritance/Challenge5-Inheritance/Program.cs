using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class A
    {
        public int a;
        public A()
        {
            a = 5;
        }
    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 20;
        }
        public int getSum()
        {
            return a + b;
        }
    }
    class Run
    {
        static void Main(string[] args)
        {
            B obj = new B();
            Console.WriteLine(obj.getSum());
        }
    }
}
