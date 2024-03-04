using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, press 0 when finished.");
        List<int> numbers = new List<int>();
        int add_number;
        string userInput;
        do{
            Console.Write($"Enter number: ");
            userInput = Console.ReadLine();
            add_number = int.Parse(userInput);
            numbers.Add(add_number);
        }while(add_number != 0);
        int sum = 0;
        foreach(int i in numbers){
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum/numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
       
    }
}