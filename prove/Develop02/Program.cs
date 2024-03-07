using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the journal program!");
        int choice = 0;
        do{
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.Save();
                    break;
                case 4:
                    journal.Load();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }while(true);
    }
}