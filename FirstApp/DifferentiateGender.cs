using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class DifferentiateGender
    {
    static void Main(string[] args)
    {
            string[] male = { };
            string[] female = { };

            Console.WriteLine("Enter total person : ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Gender : Male / Female. Press m for male or f for female");
                char gender = Convert.ToChar(Console.ReadLine());


                if (gender.Equals('m'))
                {
                    Array.Resize(ref male, male.Length + 1);
                    male[male.Length - 1] = name;
                }
                else if (gender.Equals('f'))
                {
                    Array.Resize(ref female, female.Length + 1);
                    female[female.Length - 1] = name;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }

            Console.WriteLine("Males :");
            foreach (string m in male)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine("\nFemales :");
            foreach (string f in female)
            {
                Console.WriteLine(f);
            }
        }

}
}
