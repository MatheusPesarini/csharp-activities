namespace Exercs
{
    internal static class Program
    {
        public static void Main()
        {
            var p1 = new Person();
            var p2 = new Person();
            
            Console.WriteLine("Write name and age:");
            p1.name = Console.ReadLine() ?? "Anonymous";
            p1.age = int.Parse(Console.ReadLine() ?? string.Empty);
            
            Console.WriteLine("Write name and age:");
            p2.name = Console.ReadLine() ?? "Anonymous";
            p2.age = int.Parse(Console.ReadLine() ?? string.Empty);

            int value = OldestPerson(p1.age, p2.age);

            Console.WriteLine(value == 1 ? "Person 1 is older" : "Person 2 is older");
        }

        private static int OldestPerson(int p1Age, int p2Age)
        {
            return p1Age > p2Age ? 1 : 0;
        }
    }
}