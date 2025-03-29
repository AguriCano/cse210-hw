using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Exploring the Ocean", "Manuel Chavez", 300);
        Video video2 = new Video("How to Cook Ceviche", "Aguri Cano", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This is amazing!"));
        video1.AddComment(new Comment("Bob", "Loved it!"));
        video1.AddComment(new Comment("Charlie", "Very informative, thanks."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Great recipe!"));
        video2.AddComment(new Comment("Eve", "I tried this, it worked!"));

        // Add the videos to the list
        videos.Add(video1);
        videos.Add(video2);

        // Iterate through the list of videos and display their details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}
