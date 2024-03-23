public class LaughterActivity : Activity
{
    //Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful 
    //or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. 
    //They might discover more depth than they previously realized.
    private List<Joke> _jokes = new List<Joke>();

    public LaughterActivity() : base()
    {
            _name = "Laughter Activity";
            _description = "This activity will help you focus on you and find humor in life and the theraputic nature of laughter.";
            _jokes.Add(new Joke("Why don't scientists trust atoms?", "Because they make up everything!"));
            _jokes.Add(new Joke("Why did the bicycle fall over?", "Because it was two-tired!"));
            _jokes.Add(new Joke("What's orange and sounds like a parrot?", "A carrot!"));
            _jokes.Add(new Joke("How does a penguin build its house?", "Igloos it together!"));
            _jokes.Add(new Joke("What do you call a belt made out of watches?", "A waist of time!"));
            _jokes.Add(new Joke("What's the best thing about Switzerland?", "I don't know, but their flag is a big plus!"));
            _jokes.Add(new Joke("Why did the computer go to the doctor?", "Because it had a virus!"));
            _jokes.Add(new Joke("Why couldn't the leopard play hide and seek?", "Because he was always spotted!"));
            _jokes.Add(new Joke("Why did the scarecrow become a successful neurosurgeon?", "Because he was outstanding in his field!"));
            _jokes.Add(new Joke("Why did the tomato turn red?", "Because it saw the salad dressing!"));
            _jokes.Add(new Joke("What do you call fake spaghetti?", "An impasta!"));
            _jokes.Add(new Joke("What did one plate say to the other plate?", "Lunch is on me!"));
            _jokes.Add(new Joke("What did one ocean say to the other ocean?", "Nothing, they just waved!"));
            _jokes.Add(new Joke("Why was the math book sad?", "Because it had too many problems!"));
            _jokes.Add(new Joke("Why couldn't the bicycle stand up by itself?", "It was two-tired!"));
            _jokes.Add(new Joke("Why did the golfer bring two pairs of pants?", "In case he got a hole in one!"));
            _jokes.Add(new Joke("What do you call cheese that isn't yours?", "Nacho cheese!"));
            _jokes.Add(new Joke("What did one hat say to the other hat?", "Stay here, I'm going on ahead!"));
            _jokes.Add(new Joke("Why did the snowman call his dog Frost?", "Because Frost bites!"));
            _jokes.Add(new Joke("Why couldn't the sesame seed leave the casino?", "Because he was on a roll!"));
            _jokes.Add(new Joke("Why don't skeletons fight each other?", "They don't have the guts!"));
            _jokes.Add(new Joke("What's the best time to go to the dentist?", "Tooth-hurty!"));
            _jokes.Add(new Joke("What do you call an alligator in a vest?", "An investigator!"));
            _jokes.Add(new Joke("Why don't scientists trust atoms?", "Because they make up everything!"));
            _jokes.Add(new Joke("What do you call fake spaghetti?", "An impasta!"));
            _jokes.Add(new Joke("Why couldn't the bicycle stand up by itself?", "It was two-tired!"));
            _jokes.Add(new Joke("What did the grape say when it got stepped on?", "Nothing, it just let out a little wine!"));
            _jokes.Add(new Joke("Why did the scarecrow win an award?", "Because he was outstanding in his field!"));
            _jokes.Add(new Joke("What do you get when you cross a snowman and a vampire?", "Frostbite!"));
            _jokes.Add(new Joke("Why did the math book look sad?", "Because it had too many problems!"));
            _jokes.Add(new Joke("Why did the tomato turn red?", "Because it saw the salad dressing!"));
            _jokes.Add(new Joke("What did one plate say to the other plate?", "Dinner's on me!"));
            _jokes.Add(new Joke("Why did the coffee file a police report?", "It got mugged!"));
            _jokes.Add(new Joke("Why was the math book sad?", "Because it had too many problems!"));
            _jokes.Add(new Joke("Why couldn't the bicycle stand up by itself?", "It was two-tired!"));
            _jokes.Add(new Joke("Why did the golfer bring two pairs of pants?", "In case he got a hole in one!"));
            _jokes.Add(new Joke("What did one hat say to the other hat?", "You stay here, I'll go on ahead!"));
            _jokes.Add(new Joke("Why don't eggs tell jokes?", "Because they'd crack each other up!"));
            _jokes.Add(new Joke("Why did the computer go to the doctor?", "Because it had a virus!"));
            _jokes.Add(new Joke("What's orange and sounds like a parrot?", "A carrot!"));


    }

   public Joke getRandomJoke(){
    Random rand = new Random();
       int index = rand.Next(_jokes.Count);
       return _jokes[index];
   }

    public void Run(){
        int remainingDuration = base._duration;
        Console.WriteLine("Smile.");
        showSpinner(2000);
        Console.WriteLine("Think of the most recent thing that made you laugh. Was it a joke? A funny situation? Take a moment to remember that and smile.");
        showSpinner(3000);
        Console.WriteLine("And now sit back and allow yourself to laugh at some truely bad humor. It is recommended to read the jokes aloud.");
        showSpinner(3000);
        Console.WriteLine("Beginning in... ");
        showCountdown(3);
        
        DateTime currentTime = DateTime.Now;
        DateTime targetTime = currentTime.AddSeconds(_duration);
        while (targetTime  > currentTime)
        {
            Joke joke = this.getRandomJoke();
            Console.Clear();
            Console.WriteLine(joke.GetQ());
            showSpinner(4000);
            Console.WriteLine(joke.GetA());
            showSpinner(2000);
            currentTime = DateTime.Now;
        }
        Console.WriteLine("Yes, they were bad, but hopefully you let yourself laugh.");
        showSpinner(2000);
    }
}