/*
Build a calculator that can perform basic operations (+, -, ×, ÷) but also has a "memory" feature. The program should:

Start with a result of 0
Allow the user to perform operations on the current result
Show the running total after each operation
Continue until the user chooses to quit
Handle division by zero appropriately
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        Console.WriteLine("Current result: {0}", result);
        double userNumber;
        double newResult = 0;

        bool keepGoing = true;
        while (keepGoing)
        {
            Console.Write("Enter operation: ");
            char operation = Convert.ToChar(Console.Read());
            Console.Write("Enter number: ");
            userNumber = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    {
                        newResult = result + userNumber;
                        break;
                    }
                case '-':
                    {
                        newResult = result - userNumber;
                        break;
                    }
                case '*':
                    {
                        newResult = result * userNumber;
                        break;
                    }
                case '/':
                    {
                        if (userNumber == 0)
                        {
                            Console.WriteLine("Illegal operation. Cannot divide by 0.");
                            break;
                        }
                        else
                        {
                            newResult = result / userNumber;
                            break;
                        }
                    }
                case 'q':
                    {
                        keepGoing = false;
                        break;
                    }
            }
            Console.WriteLine("Current result: {0}", newResult);
            result = newResult;
        }
    }

    static void OperationSelection()
    {
        //code      
    }
}