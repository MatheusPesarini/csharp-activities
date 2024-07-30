namespace calculator;

public class Calculator
{
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}