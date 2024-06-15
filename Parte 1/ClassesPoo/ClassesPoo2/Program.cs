namespace ClassesPoo2
{
    internal static class Program2
    {
        public static void Main()
        {
            var x = new Triangle();
            var y = new Triangle();
            
            Console.WriteLine("Type three numbers for triangle X:");
            x.A = double.Parse(Console.ReadLine() ?? string.Empty);
            x.B = double.Parse(Console.ReadLine() ?? string.Empty);
            x.C = double.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Type three numbers for triangle Y:");
            y.A = double.Parse(Console.ReadLine() ?? string.Empty);
            y.B = double.Parse(Console.ReadLine() ?? string.Empty);
            y.C = double.Parse(Console.ReadLine() ?? string.Empty);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            
            Console.WriteLine($"Triangle X area: {areaX} \nTriangle Y area: {areaY}");
        }
    }
}

