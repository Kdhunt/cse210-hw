public class ListingActivity : Activity
{
    //Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful 
    //or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. 
    //They might discover more depth than they previously realized.
    List<String> _prompts = new List<String>();
    List<string> _questions = new List<string>();


    public ListingActivity() : base()
    {
            _name = "Listing Activity";
            _description = "This activity will have you list and reflect on positive aspects of your life, relationships, strengths, and experiences.";
            _prompts.Add("List some people that you appreciate and why.");
            _prompts.Add("What are some of your personal strengths? List them.");
            _prompts.Add("Who are the people that you have helped this week? List them and how you helped.");
            _prompts.Add("When have you felt the Holy Ghost this month? List specific instances.");
            _prompts.Add("Who are some of your personal heroes? List their names and why they inspire you.");
            _prompts.Add("List things that bring you joy on a daily basis.");
            _prompts.Add("What are some activities that help you relax and unwind?");
            _prompts.Add("Who are people you admire for their resilience?");
            _prompts.Add("Name books or movies that have inspired you recently and why.");
            _prompts.Add("List personal achievements you're proud of and how they impacted you.");
            _prompts.Add("Who are individuals you're grateful to have in your life and why?");
            _prompts.Add("What are qualities you value in a friend?");
            _prompts.Add("Name places you find solace or peace and why they resonate with you.");
            _prompts.Add("List goals you've accomplished in the past year and how you achieved them.");
            _prompts.Add("Who are mentors or role models who have positively influenced your life?");

    }

   public string getRandomPrompt(){
    Random rand = new Random();
       int index = rand.Next(_prompts.Count);
       return _prompts[index];
   }

   public string getRandomQuestion(){
    Random rand = new Random();
       int index = rand.Next(_questions.Count);
       return _questions[index];
   }
   public void Run(){
    int remainingDuration = base._duration;
    Console.WriteLine("List as many responses as you can to the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"-- {getRandomPrompt()} --");
    Console.WriteLine();
    Console.WriteLine("Beginning in... ");
    showCountdown(3);
    
    DateTime currentTime = DateTime.Now;
    DateTime targetTime = currentTime.AddSeconds(_duration);
    int count = 0;
    while (targetTime  > currentTime)
    {
        Console.ReadLine();
        currentTime = DateTime.Now;
        count++;
    }
    Console.WriteLine($"You listed {count} items!");
    showSpinner(2000);
   }
    
}