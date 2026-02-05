using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("Anna", "Great explanation!"));
        video1.AddComment(new Comment("Mike", "This helped a lot."));
        video1.AddComment(new Comment("Sara", "Very clear and simple."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("OOP Explained Simply", "Dev Simplified", 480);
        video2.AddComment(new Comment("John", "Best OOP video so far."));
        video2.AddComment(new Comment("Emily", "Finally makes sense."));
        video2.AddComment(new Comment("Chris", "Loved the examples."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Classes and Objects in C#", "Programming Basics", 720);
        video3.AddComment(new Comment("Laura", "Perfect for beginners."));
        video3.AddComment(new Comment("Alex", "Straight to the point."));
        video3.AddComment(new Comment("Nina", "Exactly what I needed."));
        videos.Add(video3);

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
