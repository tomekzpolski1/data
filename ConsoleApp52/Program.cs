using System;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzień");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj miesiąć");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rok");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine($"Podana data to {d}-{m}-{r}");
            switch (m)
            {
                case 1:
                    Console.WriteLine("Miesiąc to styczeń");
                    break;
                case 2:
                    Console.WriteLine("Miesiąc to luty");
                    break;
                case 3:
                    Console.WriteLine("Miesiąc to 3");
                    break;
                case 4:
                    Console.WriteLine("Miesiąc to 4");
                    break;
                case 5:
                    Console.WriteLine("Miesiąc to 5");
                    break;
                case 6:
                    Console.WriteLine("Miesiąc to 6");
                    break;
                case 7:
                    Console.WriteLine("Miesiąc to 7");
                    break;
                case 8:
                    Console.WriteLine("Miesiąc to 8");
                    break;
                case 9:
                    Console.WriteLine("Miesiąc to 9");
                    break;
                case 10:
                    Console.WriteLine("Miesiąc to 10");
                    break;
                case 11:
                    Console.WriteLine("Miesiąc to 11");
                    break;
                case 12:
                    Console.WriteLine("Miesiąc to 12");
                    break;
                default:
                    Console.WriteLine("Błąd");
                    break;

            }
        }
    }
}
