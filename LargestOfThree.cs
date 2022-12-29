using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LargestOfThree
    {
        public static void Check()
        {
            Console.WriteLine("Enter the first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The largest number is " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The largest number is " + b);
            }
            else
            {
                Console.WriteLine("The largest number is " + c);
            }
        }
    }
}
