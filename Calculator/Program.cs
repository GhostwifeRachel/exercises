/*
Build a calculator that can perform basic operations (+, -, ×, ÷) but also has a "memory" feature. The program should:

Start with a result of 0
Allow the user to perform operations on the current result
Show the running total after each operation
Continue until the user chooses to quit
Handle division by zero appropriately
*/

//This entire program is an anti DRY hellspawn
//Dont look at it
//Gonna add methods to it someday to rid of repetition

using System;

class Program
{
    static void Main(string[] args)
    {
        double result = 0;
        Console.WriteLine("Current result: {0}", result);
        double userNumber;
        double newResult;

        bool keepGoing = true;
        while (keepGoing)
        {

            Console.Write("Enter operation: ");
            char operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    {
                        Console.Write("Enter number: ");
                        userNumber = Convert.ToDouble(Console.ReadLine());
                        newResult = result + userNumber;
                        Console.WriteLine("Current result: {0}", newResult);
                        result = newResult;
                        break;
                    }
                case '-':
                    {
                        Console.Write("Enter number: ");
                        userNumber = Convert.ToDouble(Console.ReadLine());
                        newResult = result - userNumber;
                        Console.WriteLine("Current result: {0}", newResult);
                        result = newResult;
                        break;
                    }
                case '*':
                    {
                        Console.Write("Enter number: ");
                        userNumber = Convert.ToDouble(Console.ReadLine());
                        newResult = result * userNumber;
                        Console.WriteLine("Current result: {0}", newResult);
                        result = newResult;
                        break;
                    }
                case '/':
                    {
                        Console.Write("Enter number: ");
                        userNumber = Convert.ToDouble(Console.ReadLine());
                        if (userNumber == 0)
                        {
                            Console.WriteLine("You cannot divide by 0.");
                            break;
                        }
                        else
                        {
                            newResult = result / userNumber;
                            Console.WriteLine("Current result: {0}", newResult);
                            result = newResult;
                            break;
                        }
                    }
                case 'q':
                    {
                        keepGoing = false;
                        break;
                    }
            }
        }
    }

    static void OperatorSelection()
    {
        //code      
    }
}