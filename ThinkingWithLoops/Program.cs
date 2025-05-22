namespace ThinkingWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the triangle length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            int bottomLength = length - 1;
            for (int i = 0; i < length; i++)
            {
                for (int j = bottomLength - i; j > 0; j--)
                {
                    Console.Write("#");
                }

                if (i < bottomLength)
                    Console.WriteLine();
            }
        }
    }
}