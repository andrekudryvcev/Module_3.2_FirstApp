using System;

namespace MyNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);

            string MyName = "Nemo";
            byte MyAge = 35;
            bool HaveIAPet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is {0}", MyName);
            Console.WriteLine("My age is {0}", MyAge);
            Console.WriteLine("Do I have a pet? {0}", HaveIAPet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);

            Console.WriteLine("\n***************************************************\n");

            const byte Monday = 1;
            const byte Tuesday = 2;

            Console.WriteLine("{0} {1}", Monday, Tuesday);

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("Перечесления\n");

            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);

            Console.WriteLine("\n***************************************************\n");

            Semaphore MySemaphore;
            MySemaphore = Semaphore.Red;
            Console.WriteLine(MySemaphore);

            Console.ReadKey();

        }

        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Semaphore: int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

    }
}

