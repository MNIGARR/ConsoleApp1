using System.Xml.Serialization;
using System.Threading;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number;
                double intNumber;
                string number1;
                double intNumber1;
                double result;
                Console.Clear();

                Console.Write("Enter the first number: ");
                number = Console.ReadLine();
                intNumber = Convert.ToInt32(number);

                Console.Write("Enter the second number: ");
                number1 = Console.ReadLine();
                intNumber1 = Convert.ToInt32(number1);

                Console.Write("Enter your choice: ");
                var choice = Console.ReadKey();

                Console.WriteLine(choice.Key);

                switch (choice.Key)
                {
                    case ConsoleKey.OemPlus:
                        result = intNumber + intNumber1;
                        Console.WriteLine(result);
                        Thread.Sleep(1500);
                        break;
                    case ConsoleKey.OemMinus:
                        result = intNumber - intNumber1;
                        Console.WriteLine(result);
                        Thread.Sleep(1500);
                        break;
                    case ConsoleKey.D8:
                        result = intNumber * intNumber1;
                        Console.WriteLine(result);
                        Thread.Sleep(1500);
                        break;
                    case ConsoleKey.Oem2:
                        if (intNumber1 != 0)
                        {
                            result = intNumber / intNumber1;
                            Console.WriteLine(result);
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            Console.WriteLine("0-a bolme mumkun deyil.");
                            Thread.Sleep(1500);
                        }
                        break;
                }
            }            
        }
    }
}