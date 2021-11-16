using System;

namespace HadaniCisel_IT1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahCislo = random.Next(1,100);
            int tipCislo;
            bool neuhodl = true;
            Console.WriteLine(" Hadání čísla");
            Console.WriteLine("---------------------");
            Console.WriteLine($" Myslím si číslo od 1 do 100 {nahCislo}");
            while (neuhodl)
            {
                Console.Write(" Tipni hodnotu: ");
                tipCislo = int.Parse(Console.ReadLine());
                if (tipCislo > nahCislo)
                {
                    Console.WriteLine(" To je moc");
                }
                else if (tipCislo < nahCislo)
                {
                    Console.WriteLine(" To je málo");
                }
                else
                {
                    Console.WriteLine(" Trefa");
                    neuhodl = false;
                }
            }
            Console.ReadLine();
        }
    }
}
