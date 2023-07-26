using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{

    abstract class Employee
    {

        public virtual void Login()
        {
            Console.WriteLine("Employee class virtual login method");
        }

        public virtual void Logoff()
        {
            Console.WriteLine("Employee class virtual logoff method");
        }

        public abstract void EatLunch();

    }

    class Manager : Employee
    {
        public override void Login()
        {
            Console.WriteLine("Manager class virtual login method");
        }

        public override void Logoff()
        {
            Console.WriteLine("Manager class virtual logoff method");
        }

        public override void EatLunch()
        {
            Console.WriteLine("Manager class implement abstract EatLunch method");
        }
    }

    class Programmer : Employee
    {

        public override void Login()
        {
            Console.WriteLine("Programmer class virtual login method");
        }

        public override void Logoff()
        {
            Console.WriteLine("Programmer class virtual logoff method");
        }

        public override void EatLunch()
        {
            Console.WriteLine("Programmer class implement abstract  EatLunch method");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Login();
            m.Logoff();
            m.EatLunch();

            Programmer p = new Programmer();
            p.Login();
            p.Logoff();
            p.EatLunch();


            Console.ReadKey();

        }
    }
}
