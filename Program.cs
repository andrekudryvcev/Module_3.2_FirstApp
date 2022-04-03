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
            MyFavoriteDay = DaysOfWeek.Monday;
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

            Console.WriteLine("\n***************************************************\n");

            Console.WriteLine("3.7. Преобразования типов\n");

            int olddata = 6;
            string data = olddata.ToString();
            Console.WriteLine(olddata);
            Console.WriteLine(data);

            Console.WriteLine();

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is {0}\n", age);

            Console.WriteLine("Проверка на корректность ввода.Пользователь ввёл не чило а число с текстом - (27 лет)\n");

            //Console.WriteLine("Enter your age: ");
            //int age1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your age is {0}", age1);

            Console.WriteLine();

            Console.WriteLine("TryParse возвращает булевское значение в зависимости от того, было\n" +
                "ли преобразование удачным. После этого его можно обработать. В любом случае, если в строке\n" +
                "будет что-то неверно (не только цифры, но и буквы), преобразование не получится,\n" +
                "но программа не выпадет в ошибку\n");

            //Console.WriteLine("Enter your age: ");
            //int age2;
            //bool iscorrect = int.TryParse(Console.ReadLine(), out age2);
            //Console.WriteLine("Your age is {0}\n", age2);

            //Console.WriteLine("Краткая справка обо мне\n");
            //Console.WriteLine("Enter your name: ");
            //string name2 = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your name is {0} and age is {1}\n", name2, age2);

            Console.WriteLine("Сейчас возраст мы вводим в переменную типа int.\n" +
                "Это слишком много, почему бы не привести её к byte?\n");

            //Console.WriteLine("Enter your name: ");
            //string name3 = Console.ReadLine();
            //Console.WriteLine("Enter your age: ");
            //byte age3 = (byte)int.Parse(Console.ReadLine());
            //Console.WriteLine("Your name is {0} and your age is {1}\n", name3, age3);

            Console.WriteLine("checked - служебное слово. Проверяет возможно ли преобразование без потери данных\n");

            Console.WriteLine("Enter your name: ");
            string name4 = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            byte age4 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and your age is {1}\n", name4, age4);

            Console.WriteLine("Задание 3.7.4\n");

            Console.Write("Enter your name: ");
            string name5 = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age5 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name5, age5);
            Console.Write("What is your favorite day of week? ");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}\n", day);


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

