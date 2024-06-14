namespace ClassesPoo
{
    internal static class Program
    {
        private static void Main()
        {
            double xA, xB, xC, yA, yB, yC;
            
            Console.WriteLine("Write three sizes for the triangle X:");

            string[] inputsX = Console.ReadLine().Split(' ');

            xA = double.Parse(inputsX[0]);
            xB = double.Parse(inputsX[1]);
            xC = double.Parse(inputsX[2]);

            Console.WriteLine("Write three sizes for the triangle Y:");
            
            string[] inputsY = Console.ReadLine().Split(' ');

            yA = double.Parse(inputsY[0]);
            yB = double.Parse(inputsY[1]);
            yC = double.Parse(inputsY[2]);

            double pX = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));
            
            double pY = (xA + xB + xC) / 2;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine($"Área de X: {areaX:F4} \nÁrea de Y: {areaY:F4}");
        }
    }
}

