using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Username
    {
        int a;
        public static void DisplayUsername()
        {
            Console.WriteLine("Please enter the username :");

            string username = Console.ReadLine();


            if (username.Length > 3)
            {

                Console.WriteLine("Hello " + username + ", How are you ?");
            }
            else
            {
                Console.WriteLine("The username is not having 3 characters ");
            }
        }
    }
}
