namespace EscapsulamentoPrivate;

internal class Estoque
{
    private string? _name;
    private double _price;
    private int _quantity;
    public int PublicTest { get; set; }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    //public double Price => _price;

    //public int Quantity => _quantity;

    /*
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    */

    public int TotalValue()
    {
        Console.WriteLine("Type the product price and quantity");
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