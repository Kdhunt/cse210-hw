using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter;
        if(percentage>=90){
            Console.WriteLine(letter = "A");
        }else if(percentage>=80){
            Console.WriteLine(letter ="B");
        }else if(percentage>=70){
            Console.WriteLine(letter ="C");
        }else if(percentage>=60){
            Console.WriteLine(letter = "D");
        }else{
            Console.WriteLine(letter  = "F");
        }

        Console.WriteLine($"Your grade is: {letter}");
        if(percentage>=70){
            Console.WriteLine("You Passed!");
        }else{
            Console.WriteLine("You have been touched by failure's refining fire. Just wait until you get your next chance!");
        }
    }
}