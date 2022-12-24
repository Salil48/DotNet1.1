using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LeapYear
    {
        public static void Check()
        {
            Console.WriteLine("Enter Year to find it is leap year or not ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 && year < 9999) 
                {
                    Console.WriteLine(year);
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("This is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("This is not a leap year");
                    }

                }
            else
            {
                Console.WriteLine("Enter 4 digit number"); 
            }
        }
            
    }
}
