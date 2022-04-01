using System;

class MainClass
{
    public static void Main(string[] args)
    {
        const string myName = "Nemo";

        Console.WriteLine(myName);

        Console.WriteLine("\tПривет мир");
        Console.WriteLine("\tМне 35 лет");
        Console.WriteLine("\tMy name is\n {0}", myName);
        Console.WriteLine("\u0040");
        Console.WriteLine("\x23");

        Console.WriteLine(true);
        Console.WriteLine(false);

        Console.WriteLine(5);

        Console.WriteLine(0x0A);
        Console.WriteLine(0b11);

        Console.ReadKey();
    }
}