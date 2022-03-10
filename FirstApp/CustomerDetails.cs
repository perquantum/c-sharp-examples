

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class CustomerDetails
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Customer customerone = new Customer();
            customerone.name = name;
            customerone.age = age;
            customerone.amount = amount;

            int flag = 0;

            if (age <= 25)
            {
                flag = 0;
            }
            else if (age > 25 && age <= 35)
            {
                flag = 1;
            }
            else if (age > 35 && age <= 45)
            {
                flag = 2;
            }
            else
            {
                flag = 3;
            }

            Console.WriteLine("\nBefore the loan is availed");
            Console.WriteLine($"Customer Name : {customerone.name}\nAge : {customerone.age}\nAmount : {customerone.amount}");

            switch (flag)
            {
                case 0:
                    customerone.amount = amount + ((amount) * 10 / 100);
                    break;
                case 1:
                    customerone.amount = amount + ((amount) * 15 / 100);
                    break;
                case 2:
                    customerone.amount = amount + ((amount) * 30 / 100);
                    break;
                case 3:
                    customerone.amount = amount + ((amount) * 50 / 100);
                    break;
            }

            Console.WriteLine("\nAfter the loan is availed");
            Console.WriteLine($"Customer Name : {customerone.name}\nAge : {customerone.age}\nAmount : {customerone.amount}");


        }
    }
}


