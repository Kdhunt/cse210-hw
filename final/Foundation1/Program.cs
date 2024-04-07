using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Fishing with Grapes.", "Bob Sanderson", 120);
        video1.AddComment("John Smith", "Great video!");
        video1.AddComment("Kevin Anderson", "Nice content.");
        video1.AddComment("Lao Yen", "Could be better.");
        videos.Add(video1);

        Video video2 = new Video("Echoes of an Eternal Past", "Dobrovek Niska", 180);
        video2.AddComment("MacKenzie Austin", "Awesome!");
        video2.AddComment("Nguyen Nguyen", "Interesting topic.");
         video2.AddComment("Kyosuke Hojira", "Not so eternal");
        videos.Add(video2);

        Video video3 = new Video("Excuses to avoid life", "Larry the Cucumber", 150);
        video3.AddComment("Elder Paw", "Loved it!");
        video3.AddComment("Ida Longa Lou", "Love it!");
        video3.AddComment("Minecraft Mom", "Loved it the most!");
        videos.Add(video3);

        // Displaying video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}