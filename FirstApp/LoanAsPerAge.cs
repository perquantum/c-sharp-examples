using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace FirstApp
{
        public class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
    public interface IJunior
    {
        void InsuranceJr();
    }
    public interface ISenior
    {
        void InsuranceSr();
    }


    internal class LoanAsPerAge : IJunior, ISenior
    {

        static void Main(string[] args)
    {
            public void InsuranceJr()
            {
                int amount = 5000;
                Console.WriteLine($"Your yearly insurance cost is : {amount * 10}");
            }
            public void InsuranceSr()
            {
                int amount = 5000;
                Console.WriteLine($"Your yearly insurance cost is : {amount * 20}");
            }
            Console.WriteLine("Enter Your Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Your Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age <= 20)
        {
            NameAndAge personone = new NameAndAge();
            personone.InsuranceJr();
        }
        else
        {
            NameAndAge personone = new NameAndAge();
            personone.InsuranceSr();
        }

    }

}




    }

    