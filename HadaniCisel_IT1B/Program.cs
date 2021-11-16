using System;

namespace HadaniCisel_IT1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahCislo = random.Next(1,100);
            Console.WriteLine(" Hadání čísla");
            Console.WriteLine("---------------------");
            Console.WriteLine($" Myslím si číslo od 1 do 100");

            Console.ReadLine();
        }
    }
}
