using System;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            Pryamaya pryamaya = new Pryamaya(k, b);
            Console.WriteLine(pryamaya.Root());
            Console.ReadKey();
        }
    }
}