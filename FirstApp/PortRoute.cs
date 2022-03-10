using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class PortRoute
    {
        static void Main(string[] args)
        {

            IDictionary<int, string> ports = new Dictionary<int, string>();
            ports.Add(10, "AUstralia");
            ports.Add(50, "USA");
            ports.Add(200, "India");
            ports.Add(130, "UK");
            ports.Add(80, "Russia");

            Console.WriteLine("Enter Origin Port ID : ");
            int oid = Convert.ToInt32(Console.ReadLine());





            Console.WriteLine("Enter Destination Port ID : ");
            int did = Convert.ToInt32(Console.ReadLine());
            if (oid == did)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {
                Console.WriteLine($"Your total cost of shipping from {ports[oid]} to {ports[did]} is {oid * did}");
            }
        }
    }
}
