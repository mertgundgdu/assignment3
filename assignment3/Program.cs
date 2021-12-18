using System;

namespace assignment3
{
    class Program
    {

        static void Main(string[] args)
        {

            int startNumber = 2;
            Console.Write("Write a number : ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Prime Numbers between {endNumber} are : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}