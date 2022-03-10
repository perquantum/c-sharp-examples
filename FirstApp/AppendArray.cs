using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class AppendArray
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];
            int[] newnums = new int[] { };
            Console.WriteLine("Enter total number of elements : ");
            int size = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter numbers : ");
            for (int i = 0; i < size; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                if (i > 4)
                {
                    Array.Resize(ref newnums, newnums.Length + 1);
                    newnums[newnums.Length - 1] = num;
                }
                else
                {
                    nums[i] = num;
                    if (i == 4)
                    {
                        Console.WriteLine("Now the original array is full, so we will push the next elements into the new array");
                    }
                }
            }

            Console.WriteLine("Elements of original array : ");
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Elements of new array : ");
            foreach (int i in newnums)
            {
                Console.WriteLine(i);
            }
        }
}
}