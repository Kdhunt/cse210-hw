using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        string playagain = "n";
       do{
        RunGame();
        Console.WriteLine("Do you want to play again? (y/n)");
        playagain = Console.ReadLine();
       }while(playagain == "y");

    
    }
    static void RunGame(){
         Random rnd = new Random();
        //Console.Write("What is the magic number?");
        string userInput;// = Console.ReadLine();
        //int magic_number = int.Parse(userInput);
        int guess_count = 0;
        int magic_number = rnd.Next(1,100);
        Boolean check = true;
        while(check){
            Console.Write($"What is your guess: ");
            userInput = Console.ReadLine();
            int guess_number = int.Parse(userInput);
            guess_count++;
            if(guess_number == magic_number){
                Console.WriteLine($"You got it in {guess_count} guesses!");
                check = false;
            }else if(guess_number > magic_number){
                Console.WriteLine("Lower");
            }else{
                Console.WriteLine("Higher");
            }
        }
    }

}
