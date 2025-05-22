/*
Exercise 4: Multiplication Table Quiz
Create a program that quizzes the user on multiplication tables.
Generate random multiplication problems (like 7 × 8), ask for the answer, and keep score.

The program should:
Ask 10 questions total
Keep track of correct and incorrect answers
Show the final score at the end
For wrong answers, show the correct answer

Hints: You'll need a loop for the questions, random number generation, and variables to track the score.
*/

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            int rngNum1 = random.Next(1, 11);
            int rngNum2 = random.Next(1, 11);
            Console.Write("{0} x {1} = ", rngNum1, rngNum2);
            int result = Convert.ToInt32(Console.ReadLine());
            
        }
    }
}