namespace foreachProgram;

class Program
{
    static void Main()
    {
        string[] vect = new string[] { "1", "2", "3" };

        foreach (string number in vect)
        {
            Console.WriteLine(number);
        }
    }
}

