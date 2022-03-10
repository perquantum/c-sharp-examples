using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public void getDetails(){}
    }
    internal class EmployeeDetails
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

            Console.WriteLine(Person.GetDetails());



            Console.WriteLine("Enter details : ");
            Console.WriteLine("Enter First Name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter First Name : ");
            string lastname = Console.ReadLine(); ;

            Console.WriteLine("Do you want to append your name? (Y/N)");
            char response = Convert.ToChar(Console.ReadLine());
            if (response.Equals('y') || response.Equals('Y'))
            {
                StringBuilder fullname = new StringBuilder();
                fullname.Append(firstname);
                fullname.Append(lastname);
                Console.WriteLine($"Your name is {fullname}");
            }
            else if (response.Equals('n') || response.Equals('N'))
            {
                Console.WriteLine($"Your name is {firstname}");
            }
            else
            {
                Console.WriteLine("Invalid response");
            }

            Console.WriteLine("Enter First Name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Title : ");
            string title = Console.ReadLine();

            Person person = Person.getDetails();
            person.FirstName = firstname;
            person.LastName = lastname;
            person.Title = title;
            StringBuilder fullname = new StringBuilder();
            fullname.Append(person.FirstName);
            fullname.Append(" " + person.LastName);
            Console.WriteLine($"Mr. {fullname} is entitled as {person.Title}")


        }
    }

