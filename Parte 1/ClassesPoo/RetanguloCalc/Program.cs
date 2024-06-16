namespace RetanguloCalc;

internal static class Program
{
    public static void Main()
    {
        var op = 1;
        var retangulo = new RetanguloArit();

        while (op != 0)
        {
            Console.WriteLine("[0] Exit, [1] Insert");
            op = int.Parse(Console.ReadLine());
            
            if (op == 1)
            {
                retangulo.RectangleInput();
                Console.WriteLine($"{retangulo}");
            }
        }
    }
}