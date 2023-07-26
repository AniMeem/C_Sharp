using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{

    public interface ICustomer
    {
        string Name
        {
            get;
            set;
        }
        string Product
        {
            get;
            set;
        }

    }

    public interface ISupplier
    {
        string Name
        {
            get;
            set;
        }
        string Product
        {
            get;
            set;
        }

    }
    public class Dealer : ICustomer, ISupplier
    {
        private string name;
        private string product;

        public Dealer(string name, string product)
        {
            this.name = name;
            this.product = product;
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Product
        {
            get
            {
                return this.product;
            }
            set
            {
                this.product = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dealer dealer = new Dealer("Anika", "Laptop");
            Console.WriteLine("Customer Name:" + dealer.Name);
            Console.WriteLine("Product Name:" + dealer.Product);
            Console.ReadKey();
        }
    }
}
