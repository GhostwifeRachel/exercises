using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is less efficient due to the calculation being reiterated at each instance of the if statement
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("___________________________");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //This is more efficient because division by 3 and 5 is calculated and stored as value not calculated at each iteration of if statements
            bool div3 = false;
            bool div5 = false;

            for (int i = 1; i <= number; i++)
            {
                div3 = i % 3 == 0;
                div5 = i % 5 == 0;

                if (div3 && div5)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (div3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (div5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}