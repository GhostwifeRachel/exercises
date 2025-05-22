class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int attemptCounter = -1;
        int guessedNumber = 0;

        Console.Write("Guess the number between 1 and 100: ");
        while (guessedNumber != randomNumber)
        {
            guessedNumber = Convert.ToInt32(Console.ReadLine());
            if (guessedNumber == randomNumber)
            {
                Console.WriteLine("The number is {0}. Congrats! You've won!", randomNumber);
            }
            else if (guessedNumber < randomNumber)
            {
                Console.Write("Too low.\nGuess again: ");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.Write("Too high.\nGuess again: ");
            }
            attemptCounter++;
        }
        Console.WriteLine("Failed attempts: {0}",attemptCounter);
    }
}