using System.Data;

class Scripture
{
    private readonly List<ScriptureWord> _words = new List<ScriptureWord>();
    private String _book {get; set;}
    private string _chapter  {get; set;}
    private string _verse  {get; set;}
    private  string _text { get; set; }

    public void Initialize(string book, string chapter, string verse, string text, string reference)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;

        this._text = text;

        // Split text into words
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Add each word to the list
        foreach (string word in wordArray)
        {
            this._words.Add(new ScriptureWord { Word = word, IsHidden = false });
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;
        if(count > 5){count = 5;}
        if(count >= this._words.Count(w => !w.IsHidden)){count = this._words.Count(w => !w.IsHidden);}
        while (hiddenCount < count)
        {
            int index = random.Next(0, this._words.Count);

            if (!this._words[index].IsHidden)
            {
                this._words[index].IsHidden = true;
                hiddenCount++;
            }
        }
    }

    public bool checkAllWordsHidden(){
        return !this._words.Any(w => !w.IsHidden);
    }

    public void Display()
    {
        Console.WriteLine($"Scripture Reference: {this._book} {this._chapter}:{this._verse} ");
        Console.WriteLine();

        foreach (ScriptureWord word in this._words)
        {
            if (word.IsHidden)
                Console.Write($"___ ");
            else
                Console.Write($"{word.Word} ");
        }
        //Console.WriteLine(this._words.Count(w => !w.IsHidden));
        Console.WriteLine();
    }
}