namespace Constructor;

internal class Estoque(string? name, double price, int quantity) // constructor (principal c# 9.0)
{
    /*
    private string? _name;
    private double _price;
    private int _quantity;

    public Estoque(string? name, double price, int quantity) // constructor
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }
    */

    public int Quantity()
    {
        return quantity;
    }

    public void AddProduct(int quantityAdd)
    {
        quantity = quantityAdd;
    }

    public void RemoveProduct(int quantityRemove)
    {
        quantity = quantityRemove;
    }

    public override string ToString()
    {
        return $"Product data: {name}, R${price}, {quantity} unities, total: R${price * quantity}";
    }
}