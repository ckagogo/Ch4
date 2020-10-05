using System;

namespace LetterCase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(1);
                Console.Write("Enter an uppercase letter: ");
                char ch = Console.ReadLine()[0];
                if (ch == '!') break;
                if (ch >= 'A' && ch <= 'Z')
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Sorry- That was not an uppercase letter");



                }
            }
        }
    }
}
