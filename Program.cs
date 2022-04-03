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

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("3.5. Ввод и вывод в консоль");

            string MyName1 = "Евгения";
            Console.WriteLine("Привет, мир");
            Console.WriteLine();
            Console.WriteLine($"Меня зовут {MyName1}");

            // Вставка строгового литерала
            Console.WriteLine("Меня зовут {0}", "Mini");

            Console.WriteLine("\n***************************************************\n");

            string NameComputer = "Computer";
            Console.WriteLine("Привет, человек");
            Console.WriteLine("Меня зовут {0}", NameComputer);
            Console.WriteLine("А как тебя зовут?");
            //string YourName = Console.ReadLine();
            //Console.WriteLine("Рад встрече, {0}", YourName);

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("3.6. Основные операции C#");

            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);
            Console.WriteLine("\n");

            Console.WriteLine("Операция вычисления остатка от деления");
            double result1 = 5.0 % 2.0;
            Console.WriteLine("Остаток от деления 5 / 2 равен {0}\n", result1);

            Console.WriteLine("Операции инкемент ++ и декремент --");
            int counter = 10;
            Console.WriteLine("Value: {0} increment: {1}\n", counter, ++counter);

            Console.WriteLine("Демонстарция приоритета операций");
            double result2 = 10.0 * 2.0 / 5.0;
            Console.WriteLine("10.0 * 2.0 / 5.0  Value: {0}", result2);

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

