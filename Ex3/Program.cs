class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the triangle: ");
        int size = Convert.ToInt32(Console.ReadLine());
        if (size <= 0 || size > 9)
        {
            Console.WriteLine("Please enter a valid size (1-9).");
        }
        else
        {
            EasyTriangle(size);
            Console.WriteLine();
            BonusTriangle(size);
        }
    }

    static void EasyTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }

    static void BonusTriangle(int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = size - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i + 1; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}