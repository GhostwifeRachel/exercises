/*
Exercise 1: Grade Calculator
Write a program that:

Takes 5 test scores from the user and stores them in an array
Calculates and displays the average score
Finds and displays the highest and lowest scores
Counts how many scores are above the average

Skills practiced: Basic array operations, loops, finding min/max values
*/

using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[5];

            //enter values into the array
            for (int i = 0; i < studentGrades.Length; i++)
            {
                int grade;
                Console.Write($"Enter grade {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("Please enter a valid number: ");
                }
                studentGrades[i] = grade;
            }

            //sum all studentGrades and divide by 5 to achieve grade average
            int gradesSum = 0;
            for (int i = 0; i < studentGrades.Length; i++)
            {
                gradesSum += studentGrades[i];
            }
            int gradesAvg = gradesSum / studentGrades.Length;
            Console.WriteLine($"Grades average: {gradesAvg}"); 
        }
    }
}