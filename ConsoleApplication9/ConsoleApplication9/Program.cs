using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class A
    {
        public int x;
        private int y;
        protected int z;

        public A()
        {
            Console.WriteLine("Class A default constructor is called");
            x = 5;
            y = 6;
            z = 7;
        }

        public void Show()
        {
            Console.WriteLine(x + " " + y + " " + z);
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Class B default constructor is called");
            Show();
        }

        public void print()
        {

            Console.WriteLine("The value of x is {0} and the value of z is {1} ", x, z);
        }

    }


    class C : B
    {
        public int w;

        public C()
        {
            Console.WriteLine("class c default constructor is called");
            w = 11;
            Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.Show();
            obj.print();
            B obj1 = new B();

            Console.ReadKey();
        }
    }
}
