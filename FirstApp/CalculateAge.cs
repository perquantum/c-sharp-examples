using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class CalculateAge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your DOB : ");
            string dob = Console.ReadLine();
            DateTime date;

            var isValid = DateTime.TryParse(dob, out date);
            DateTime today = DateTime.Today;

            if (isValid)
            {
                var age = today.Year - date.Year;
                if (today.Month > date.Month)
                {
                    Console.WriteLine($"You are {age} years old.");
                    string yourdob = date.ToString();
                    Console.WriteLine(yourdob);
                }
                else
                {
                    Console.WriteLine($"You are {age - 1} years old.");
                    string yourdob = date.ToString();
                    string year = date.Year.ToString();
                    string month = date.Month.ToString();
                    string day = date.Day.ToString();
                    Console.WriteLine(day + "/" + month + "/" + year);
                }

            }
            else
            {
                Console.WriteLine($"The date {dob} is invalid. Please enter valid DOB!");
            }

        }
}

}
