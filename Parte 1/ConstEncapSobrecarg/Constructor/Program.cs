namespace Constructor;

internal static class Program
{
    public static void Main()
    {
        var op = 1;
        var product = new Estoque("Tico", 500, 10);

        int productQuantity = product.Quantity();
        int productQuantityChange = productQuantity;

        while (op != 0)
        {
            Console.WriteLine($"{product}");
            Console.WriteLine("[0] To exit \n[1] To add items \n[2] To remove items");
            op = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the change value");
                
            if (op == 1)
            {
                productQuantityChange += int.Parse(Console.ReadLine());
                product.AddProduct(productQuantityChange);
            }
            else if (op == 2)
            {
                productQuantityChange -= int.Parse(Console.ReadLine());
                product.RemoveProduct(productQuantityChange);
            }
        }
    }
}