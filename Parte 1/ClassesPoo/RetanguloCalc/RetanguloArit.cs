namespace RetanguloCalc;

public class RetanguloArit
{
    private double _width;
    private double _height;

    public void RectangleInput()
    {
        Console.WriteLine("Type the width and height of the rectangle:");
        _width = double.Parse(Console.ReadLine());
        _height = double.Parse(Console.ReadLine());
    }

    private double Perimetro()
    {
        return 2 * (_width + _height);
    }

    private double Diagonal()
    {
        return Math.Sqrt(Math.Pow(_width, 2.0) + Math.Pow(_height, 2.0));
    }

    public override string ToString()
    {
        return $"The rectangle width and height: {_width} / {_height} \nArea: {_height * _width} \nPerimetro: {Perimetro()} \nDiagonal: {Diagonal()}";
    }
}