using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    private int id;
    private String name;
    private float balance;
   
    public Account()
    {
        Console.WriteLine("Account Created with balance 0");
        id = 0;
        name = "None";
        balance = 0.0f;
    }

    public Account(int id, String name, float balance)
    {
        this.id = id;
        this.name = name;
        this.balance = balance;
    
    }

    public float Balance { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }

    public void print()
    {
        Console.WriteLine("Acoount details\nName : {0}\nID : {1}\nBalance : {2}", name, id, balance);
    }
}

namespace ConsoleApplication8
{   
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.print();

            Account obj1 = new Account(41909, "Anika Anjum", 150000.00f);
            obj1.print();

            Console.ReadKey();
        }
    }
}
