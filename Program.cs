using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string MyName = "Nemo";
        byte MyAge = 35;
        bool HaveIAPet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is {0}", MyName);
        Console.WriteLine("My age is {0}", MyAge);
        Console.WriteLine("Do I have a pet? {0}", HaveIAPet);
        Console.WriteLine("My shoe size is {0}", MyShoeSize);

        
        Console.ReadKey();
    }
}