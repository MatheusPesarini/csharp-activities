using System;

namespace vectorclass
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insira o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            
            Product[] vect = new Product[n];
            
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }
            
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            
            Console.WriteLine($"Average price: {sum / n}");
        }
    }
}

