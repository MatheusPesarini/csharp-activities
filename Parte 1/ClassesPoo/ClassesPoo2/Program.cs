namespace ClassesPoo2
{
    internal static class Program2
    {
        public static void Main()
        {
            var x = new Triangle();
            var y = new Triangle();
            
            double areaX = x.AreaTriangle();
            double areaY = y.AreaTriangle();
            
            Console.WriteLine($"Triangle X area: {areaX} \nTriangle Y area: {areaY}");
        }
    }
}

