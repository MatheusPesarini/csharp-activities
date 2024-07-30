namespace ref_out;

public class Calculator
{
    public static void TripleRef (ref int a)
    {
        a = a * 3;
    }

    public static void TripleOut(ref int a, out int result)
    {
        result = a * 3;
    }
}