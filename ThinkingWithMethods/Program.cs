class Program
{
    static void Main(string[] args)
    {
        Greeting("Filip", "Bone");
        Greeting("Tadeusz", "Maderski");
    }

    static void Greeting(string fName, string lName)
    {
        Console.WriteLine("Siema nazywam się {0} {1}.", fName, lName);
    }
}