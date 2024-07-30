namespace aluguel_quartos
{
    class Program
    {
        static void Main()
        {
            int[] rooms = new int[10];
            Renters[] renters = new Renters[10];
            string[] personOrder = new string[10];
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Type the name of the person: ");
                string name = Console.ReadLine();
                Console.WriteLine("Type the email of the person: ");
                string email = Console.ReadLine();
                Console.WriteLine("Type the room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                
                rooms[roomNumber] = 1;
                personOrder[i] = name;

                renters[roomNumber] = new Renters { Name = name, Email = email };
                    
                Console.WriteLine("Do you want to add another person? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    break;
                }
            }
            
            Console.WriteLine("Person rent order: ");
            for (int i = 0; i < 10; i++)
            {
                if (personOrder[i] != null)
                {
                    Console.WriteLine(personOrder[i]);
                }
            }
            
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] == 1)
                {
                    Console.WriteLine($"Renters name: {renters[i].Name} - Renters email: {renters[i].Email} - Room number: {i}");
                }
                else
                {
                    Console.WriteLine($"Room number: {i} is empty.");
                }
            }
        }
    }
}

