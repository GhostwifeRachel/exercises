class Program
{
    static void Main(string[] args)
    {
        //Make a multiplication table x * 10; x being user input
        Console.Write("Enter a number to be displayed in a multiplication table: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            int result = x * i;
            Console.WriteLine("{0} x {1} = {2}", x, i, result);
        }
    }
}