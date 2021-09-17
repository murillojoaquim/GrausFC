using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Digite o valor em graus Farenheint:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("°F = ");
            string Farenheint = Console.ReadLine();

            double Celsius = (Convert.ToDouble(Farenheint) - 32) / 1.8;
            
            Console.Write($"\n{Farenheint}°F equivalem a ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Celsius}°C");

            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
