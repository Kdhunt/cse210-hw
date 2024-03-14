using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a scripture instance
        Scripture scripture = new Scripture();
        scripture.Initialize("And they knew that it must be expedient that Christ had come, because of the many signs which had been given, according to the words of the prophets; and because of the things which had come to pass already they knew that it must needs be that all things should come to pass according to that which had been spoken.", "3 Nephi 5:2");

        bool allWordsHidden = false;
        int hiddenWordCount = 1;

        while (!allWordsHidden)
        {
            // Display the scripture
            Console.Clear();
            scripture.Display();

            // Prompt the user
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide random words
            scripture.HideRandomWords(hiddenWordCount);
            hiddenWordCount++;

            // Check if all words are hidden
            allWordsHidden = scripture.checkAllWordsHidden();
        }
        Console.Clear();
        scripture.Display();
        //Console.WriteLine(hiddenWordCount);
    }
}