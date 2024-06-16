namespace SalaryCalc;

internal static class Program
{
    public static void Main()
    {
        var op = 1;
        var person = new SalaryCalc();

        person.CalculeNetSalary();

        while (op != 0)
        {
            Console.WriteLine("[0] Exit, [1] Insert, [2] Salary Raise");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                double netSalary = person.CalculeNetSalary();
                Console.WriteLine($"Net salary: {netSalary}");
            }
            else if (op == 2)
            {
                Console.WriteLine("Type the percentage raise of salary:");
                double percentage = double.Parse(Console.ReadLine());
                person.IncreaseSalary(percentage);
            }
        }
    }
}