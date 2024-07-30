namespace ref_out;

class Program
{
    static void Main()
    {
        int a = 10;
        int result;
        
        Calculator.TripleRef(ref a);
        Console.WriteLine($"Ref: {a}"); // ref a variavel precisa ter sido iniciada com atribuicao 

        a = 10;

        Calculator.TripleOut(ref a, out result); // out nao precisa ser inicializado
        Console.WriteLine($"Out: {result}");
    }
}

