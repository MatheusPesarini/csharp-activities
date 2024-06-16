namespace BankAccount;

internal class BankAccount
{
    private string? Name { get; set; }
    private double Balance { get; set; }
    private int AccountId { get; set; }

    public BankAccount()
    {
        Console.WriteLine("Type your name, account id and balance:");
        Name = Console.ReadLine();
        AccountId = int.Parse(Console.ReadLine());
        Balance = double.Parse(Console.ReadLine());
    }

    public void UpdateBalance()
    {
        Console.WriteLine("[0] To raise the balance \n[1] To lower the balance:");
        int op = int.Parse(Console.ReadLine());
        Console.WriteLine("Value:");
        double value = double.Parse(Console.ReadLine());
        
        if (op == 0)
        {
            Balance += value;
        } 
        else if (op == 1)
        {
            Balance -= value;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Account ID: {AccountId}, Balance: {Balance}";
    }
}