using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class NameAndAge
    {
        static void Main(string[] args)
        {
            string[] names = { "Paresh", "Ravi", "Mahesh", "Kevin", "Dhruti" };
            int[] age = { 21, 38, 54, 18, 20 };


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Username : {names[i]}, Age : {age[i]}");
            }



        }

    }
            

}
