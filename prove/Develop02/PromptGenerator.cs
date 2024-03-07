using System.ComponentModel.Design;

public class PromptGenerator{
  List<string> _prompts;
  public PromptGenerator()
  {
    _prompts = new List<string>();
    _prompts.Add("Reflect on moments where you felt the presence of God in your day.");
    _prompts.Add("How did you serve others today? How did it make you feel?");
    _prompts.Add("Write about a scripture or spiritual thought that inspired you today.");
    _prompts.Add("How did you strive to follow Jesus Christ's example today?");
    _prompts.Add("Reflect on a moment of gratitude from today. What are you thankful for?");
    _prompts.Add("Write about a challenge you faced today and how you sought guidance through prayer.");
    _prompts.Add("How did you strengthen your relationship with God today?");
    _prompts.Add("Reflect on a moment where you felt prompted by the Holy Ghost. What was the prompting and how did you respond?");
    _prompts.Add("Write about a way you showed love and kindness to others today.");
    _prompts.Add("How did you strive to align your actions with your faith today?");
    _prompts.Add("Reflect on a lesson you learned from a church meeting, scripture study, or prayer today.");
    _prompts.Add("Write about a moment where you felt the Savior's love for you personally.");
    _prompts.Add("Reflect on an attribute of God that inspires you. How did you strive to emulate that attribute today?");
    _prompts.Add("Write about one way you were able to share your testimony with others today.");
    _prompts.Add("How did you make time for personal prayer and scripture study today?");
    _prompts.Add("Write about one way you were able to share your testimony with others today.");
    _prompts.Add("How did you make time for personal prayer and scripture study today?");
    _prompts.Add("Reflect on a way you were able to share your testimony today.");
    _prompts.Add("How did you apply a gospel principle in your life today?");
    _prompts.Add("Reflect on a way the Savior's Atonement blessed your life today.");
    _prompts.Add("How did you show compassion to others in need today?");
    _prompts.Add("Reflect on a way you were able to lift or strengthen someone else today.");
    _prompts.Add("How did you strive to follow Jesus Christ's example today?");
    _prompts.Add("Reflect on a moment of gratitude from today. What are you thankful for?");
    _prompts.Add("Write about a challenge you faced today and how you sought guidance through prayer.");
    _prompts.Add("How did you strengthen your relationship with God today?");
    _prompts.Add("Reflect on a moment where you felt prompted by the Holy Ghost. What was the prompting and how did you respond?");
    _prompts.Add("Write about a way you showed love and kindness to others today.");
    _prompts.Add("How did you strive to align your actions with your faith today?");
    _prompts.Add("Reflect on a lesson you learned from a church meeting, scripture study, or prayer today.");
    _prompts.Add("Write about a moment where you felt the Savior's love for you personally.");
    _prompts.Add("How did you seek to uplift and encourage those around you today?");
    _prompts.Add("Reflect on how you can improve your discipleship and follow Christ more closely tomorrow.");
    _prompts.Add("Write about a blessing you received today and how it strengthened your testimony.");
    _prompts.Add("What can you do tomorrow to make someone else's day brighter?");
    _prompts.Add("Reflect on the ways you've seen God's hand in your life this week.");
    _prompts.Add("Write about a time when you felt prompted to share your testimony with someone.");
    _prompts.Add("How did you strive to be a light and example to others today?");
    _prompts.Add("Reflect on a moment when you felt peace amidst life's challenges.");
    _prompts.Add("Write about a lesson you learned from studying the life of a prophet or apostle");

  }

    public string GetPrompt(){
        // Generate random number
        Random random = new Random();
        //select prompt from _prompts based on rando number
        int randomNumber = random.Next(0, _prompts.Count);
        //return prompt
        return _prompts[randomNumber];
        

    }
}