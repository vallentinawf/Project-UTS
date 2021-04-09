using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopilih
{
    public class CustomerData
    {
        protected string name;
        protected double phoneNumber;
        protected string address;


        public virtual void Insert()
        {
            CustomerData customer = new CustomerData();

            Console.WriteLine("What is Your Name?  ");
            customer.name = Console.ReadLine();

            Console.WriteLine("What is Your Phone Number? ");
            customer.phoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("And Your Address? ");
            customer.address = Console.ReadLine();


        }

        
    }
}
