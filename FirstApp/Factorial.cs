using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int Factorial(int i)
            {
                if (i == 0 || i == 0)
                {
                    return 1;
                }
                else
                {
                    return i * Factorial(i - 1);
                }
            }

            Console.WriteLine("Enter a num : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 31)
            {
                Console.WriteLine("This number is not valid for this operation!");
            }
            else
            {
                int ans = Factorial(num);
                Console.WriteLine("The factorial of " + num + " is " + ans);
            }
        }
    }
 }
