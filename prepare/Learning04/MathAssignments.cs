public class MathAssignment : Assignment
{
    private string _textbookSection {get;}
    private string _problems {get;}

    // calling the parent constructor using "base"!
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
      _textbookSection = textbookSection;
      _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}