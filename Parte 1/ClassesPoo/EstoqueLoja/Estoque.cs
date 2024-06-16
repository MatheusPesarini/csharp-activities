using System;

namespace EstoqueLoja
{
    internal class Estoque
    {
        private string? _name;
        private double _price;
        private int _quantity;

        public int TotalValue()
        {
          Console.WriteLine("Type the name of the product, price and quantity");
          _name = Console.ReadLine();
          _price = double.Parse(Console.ReadLine() ?? string.Empty);
          _quantity = int.Parse(Console.ReadLine() ?? string.Empty);
          
          return _quantity;
        }

        public void AddProduct(int quantityAdd)
        {
            _quantity = quantityAdd;
        }

        public void RemoveProduct(int quantityRemove)
        {
            _quantity = quantityRemove;
        }

        public override string ToString()
        {
            return $"Product data: {_name}, R${_price}, {_quantity} unities, total: R${_price * _quantity}";
        }
    }
}

