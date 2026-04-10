
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Learning C#", "Alice", 600);
        Video video2 = new Video("OOP Basics", "Bob", 450);
        Video video3 = new Video("Abstraction Explained", "Charlie", 720);

        video1.AddComment(new Comment("John", "Very helpful!"));
        video1.AddComment(new Comment("Emma", "Great explanation."));
        video1.AddComment(new Comment("Liam", "Thanks for the video."));

        video2.AddComment(new Comment("Sophia", "Clear and simple."));
        video2.AddComment(new Comment("Noah", "Nice examples."));
        video2.AddComment(new Comment("Olivia", "Well done!"));

        video3.AddComment(new Comment("James", "I understand abstraction now."));
        video3.AddComment(new Comment("Mia", "Excellent content."));
        video3.AddComment(new Comment("Lucas", "Please make more videos."));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._videoTitle}");
            Console.WriteLine($"Author: {video._videoAuthor}");
            Console.WriteLine($"Length: {video._videoLength} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment._commName}: {comment._commText}");
            }

            Console.WriteLine();
        }
    }
}
