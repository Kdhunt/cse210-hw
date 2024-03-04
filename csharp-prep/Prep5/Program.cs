using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(name, squared);
    }


static void DisplayWelcome(){ 
    Console.WriteLine("Welcome to the program!");
} //- Displays the message, "Welcome to the Program!"
static string PromptUserName(){
    Console.WriteLine("What is your name?");
    return Console.ReadLine();
} // - Asks for and returns the user's name (as a string)
static int PromptUserNumber(){
    Console.WriteLine("What is your favorite number?");
        string userInput = Console.ReadLine();
        return int.Parse(userInput);
} // - Asks for and returns the user's favorite number (as an integer)
static int SquareNumber(int number){
    return number * number;
} // - Accepts an integer as a parameter and returns that number squared (as an integer)
static void DisplayResult(string name, int square_number){
    Console.WriteLine($"{name}, your favorite number squared is {square_number}");
} // - Accepts the user's name and the squared number and displays them.

}