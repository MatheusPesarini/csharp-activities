using System;
using System.Globalization; // Biblioteca para usar a concatenacao de strings com o cifrao

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            string nome = "João";
            float saldo = 10.5567F;
            Console.WriteLine($"{nome} testando c# {saldo:F2}");

            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];
            

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter with your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("How many rooms have in your house? ");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product price: ");
            float productPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter with your last name, age and height: ");
            string[] vet1 = Console.ReadLine().Split(' ');

            Console.WriteLine($"{name} \n{rooms} \n{productPrice:F2} \n{vet1[0]} \n{vet1[1]} \n{vet1[2]}");
            */

            Console.WriteLine("Write three numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            
            double result = Maior(n1, n2, n3);

            Console.WriteLine($"Higher = {result}");
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}