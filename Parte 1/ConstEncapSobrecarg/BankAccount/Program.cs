namespace BankAccount;

internal static class Program
{
    private static void Main()
    {
        var op = 1;
        var account = new BankAccount();

        while (op != 0)
        {
            Console.WriteLine("[0] Exit, [1] Change account balance, [2] New person in system, [3] Print data\n");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                account.UpdateBalance();
            } 
            else if (op == 2)
            {
                account = new BankAccount();
            } 
            else if (op == 3)
            {
                Console.WriteLine(account.ToString());
            }
        }
    }
}