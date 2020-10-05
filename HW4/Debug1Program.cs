using System;

namespace Debug1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine();
            while (!(stockNum.Equals(ITEM209) || stockNum.Equals(ITEM312) || stockNum.Equals(ITEM414)))
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }
            if (stockNum == ITEM209)
                price = PRICE209;
            else
               if (stockNum == ITEM312)
                price = PRICE312;
            else
                price = PRICE414;
            Console.WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C"));


        }
    }
}
