using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Studenttin bagasyn engiz: ");
            int kerek_bag = Convert.ToInt32(Console.ReadLine());
            Console.Write("bagalar sanyn engiz: ");
            int koll = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[koll];
            int sum = 0;
            Random random = new Random();
            while (kerek_bag != (sum / koll))
            {
                sum = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = random.Next(50, 100);
                    sum += mass[i];
                    Console.WriteLine($"i {i + 1} --- mass[i] {mass[i]}sum {sum}");
                }
            }
        }
    }
}