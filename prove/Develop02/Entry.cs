public class Entry{
    
    public Entry(){
        _date = DateTime.Now;
    }
    public string _prompt {get; set;}
    public DateTime _date {get; set;}
    public string _entryText {get; set;}
    public void displayPrompt(){
        Console.WriteLine(_prompt);
    }
    public void displayEntry(){
        //display date formatted to MM/DD/YYYY
        string dateText = _date.ToShortDateString();
        Console.WriteLine($"Date: {dateText}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}