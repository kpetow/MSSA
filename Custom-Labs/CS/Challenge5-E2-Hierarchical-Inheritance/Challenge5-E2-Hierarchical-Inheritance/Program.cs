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
            a = 10;
        }
    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 7;
        }
    }
    class C : A
    {
        public int c;
        public C()
        {
            c = 23;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hierarchical inheritance");
            B obj1 = new B();
            C obj2 = new C();
            Console.WriteLine("Using class B object (obj1)");
            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.b);
            Console.WriteLine("Using class C object (obj2)");
            Console.WriteLine(obj2.a);
            Console.WriteLine(obj2.c);
        }
    }
}
