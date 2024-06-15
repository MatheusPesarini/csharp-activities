namespace ClassesPoo2
{
    internal class Triangle
    {
        private double A;
        private double B;
        private double C;

        private void VariableFunction()
        {
            Console.WriteLine("Type three numbers:"); 
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
        }
        
        public double AreaTriangle()
        {
            VariableFunction();
            
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}