using System;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {

            int vowelCount = 0;
            char ch;

            Console.WriteLine(1);
            Console.WriteLine("Enter a Phrase");

            String line = Console.ReadLine();
            

            for (int i = 0; i < line.Length; ++i)
            {

                ch = line[i];
                ch = char.ToLower(ch);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelCount++;

                }
            }   
            
            Console.WriteLine(vowelCount);
        }
    }
}