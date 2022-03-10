using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    internal class List
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
        }
        static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Fname = "Paresh", Lname = "Vala" },
                new Customer() { Id = 2, Fname = "Dhruti", Lname = "Desai" },
                new Customer() { Id = 3, Fname = "Lionel", Lname = "Messi" }
            };

            Console.WriteLine("Enter User ID : ");
            int inputId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Edit last name : ");
            string lastname = Console.ReadLine();


            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == inputId)
                {
                    customers[i].Lname = lastname;
                }
            }

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(customers[i].Fname + " " + customers[i].Lname);
            }

        }
    }

}
