using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list to hold all the videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Foundations: Classes Explained", "Code With Casey", 612);
        video1.AddComment(new Comment("Priya S.", "This finally made inheritance click for me!"));
        video1.AddComment(new Comment("Marcus T.", "Could you do a follow-up on interfaces?"));
        video1.AddComment(new Comment("Lena W.", "Great pacing, thanks for the examples."));
        video1.AddComment(new Comment("DevDan99", "Subscribed after this one."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Hiking Trails in the Pacific Northwest", "Trailblazer Tina", 845);
        video2.AddComment(new Comment("HikerHank", "Added three of these to my summer list!"));
        video2.AddComment(new Comment("Sara Okafor", "The drone shots at Mt. Rainier were stunning."));
        video2.AddComment(new Comment("Chris P.", "Is trail #4 dog-friendly?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Building a Budget Gaming PC in 2026", "TechBench", 1320);
        video3.AddComment(new Comment("QuietStorm", "That GPU price is way better than I expected."));
        video3.AddComment(new Comment("Aiden R.", "Would love a laptop version of this guide."));
        video3.AddComment(new Comment("Nora K.", "Cable management tips were clutch, thank you."));
        video3.AddComment(new Comment("BuildItBetty", "Saved me at least $150, appreciate the breakdown."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("15-Minute Morning Yoga for Beginners", "Calm Flow Yoga", 900);
        video4.AddComment(new Comment("Jamie L.", "Perfect length for my morning routine."));
        video4.AddComment(new Comment("Robert M.", "My back thanks you for this one."));
        video4.AddComment(new Comment("EmzWellness", "Love the calming background music choice."));
        videos.Add(video4);

        // Iterate through the videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title:            {video.Title}");
            Console.WriteLine($"Author:           {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
