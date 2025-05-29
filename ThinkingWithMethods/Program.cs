class Program
{
    static void Main(string[] args)
    {
        Greeting("Jane", "Doe");
        Greeting("John", "Doe");
    }

    static void Greeting(string fName, string lName)
    {
        Console.WriteLine("Siema nazywam się {0} {1}.", fName, lName);
    }
}