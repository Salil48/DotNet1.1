using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Powerof2
     {
        public static void Table()
        {
            Console.WriteLine("Enter a number in range 0 to 31 :");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 32)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("2 power of " + i + " is " + Math.Pow(2, i));

                }
            }
            else
            {
                Console.WriteLine("The number is above the range");
            }
        }
     }
}
