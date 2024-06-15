namespace EstoqueLoja
{
    internal class Estoque
    {
        private string name;
        private double price;
        private int quantity;

        public int TotalValue()
        {
          Console.WriteLine("Type the name of the product, price and quantity");
          name = Console.ReadLine();
          price = double.Parse(Console.ReadLine());
          quantity = int.Parse(Console.ReadLine());
          Print();
          return quantity;
        }

        private void Print()
        {
            Console.WriteLine($"Product data: {name}, R${price}, {quantity} unities, total: R${price * quantity}");
        }

        public void AddProduct(int QuantityAdd)
        {
            quantity = QuantityAdd;
            Print();
        }

        public void RemoveProduct(int quantityRemove)
        {
            quantity = quantityRemove;
            Print();
        }
    }
}

