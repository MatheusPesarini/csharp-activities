namespace SalaryCalc;

public class SalaryCalc
{
    private string _name;
    private double _grossSalary;
    private double _tax;

    public double CalculeNetSalary()
    {
        Console.WriteLine("Type the persona name, gross salary and tax:");
        _name = Console.ReadLine();
        _grossSalary = double.Parse(Console.ReadLine());
        _tax = double.Parse(Console.ReadLine());

        return _grossSalary - _tax;
    }

    public void IncreaseSalary(double percentage)
    {
        double increase = _grossSalary * (percentage / 100);
        _grossSalary += increase;
        Console.WriteLine($"Salary raise value: ${increase} \nSalary gross total: ${_grossSalary}");
    }

    public override string ToString()
    {
        return $"Name: ${_name} \nGross salary: ${_grossSalary} \nTax: ${_tax} \nNet salary: {_grossSalary - _tax}";
    }
}