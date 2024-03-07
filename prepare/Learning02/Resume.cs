public class Resume {
    public string _personName  {get; set;}
    public List<Job> _jobs {get; set;}

    public Resume() {
        _jobs = new List<Job>();
    }

    public void AddJob(Job job) {
        _jobs.Add(job);
    }

    public void Display() {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _jobs) {
            job.Display();
        }
    }
}