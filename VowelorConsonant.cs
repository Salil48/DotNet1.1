using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class VowelorConsonant
    {
        public static void Check()
        {
            Console.WriteLine("Enter a Alphabet : ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch(ch) 
            {
                case 'a':
                Console.WriteLine("The Alphabet is vowel");
                break;
                case 'e':
                Console.WriteLine("The Alphabet is vowel");
                break;
                case 'i':
                Console.WriteLine("The Alphabet is vowel");
                break;
                case 'o':
                Console.WriteLine("The Alphabet is vowel");
                break;
                case 'u':
                Console.WriteLine("The Alphabet is vowel");
                break;
                default :
                Console.WriteLine("The Alphabet is not a vowel");
                break;


            }
        }
    }
}
