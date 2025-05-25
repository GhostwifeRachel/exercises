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

        int goodAnswer = 0;
        int badAnswer = 0;

        int questions = 1;
        while (questions <= 10)
        {
            int rngNum1 = random.Next(1, 11);
            int rngNum2 = random.Next(1, 11);
            int rngMultiplicationResult = rngNum1 * rngNum2;

            Console.Write("{0}) {1} x {2} = ", questions, rngNum1, rngNum2);
            int userResult = Convert.ToInt32(Console.ReadLine());
            questions++;

            if (userResult == rngMultiplicationResult)
            {
                Console.WriteLine("Correct!");
                goodAnswer++;
            }
            else
            {
                Console.WriteLine("Incorrect :( The correct answer is {0}.", rngMultiplicationResult);
                badAnswer++;
            }
        }
        Console.WriteLine("\nYou've guessed correctly {0} times :)\nAnd have guessed incorrectly {1} times :(", goodAnswer, badAnswer);
    }
}