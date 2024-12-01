using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Introduction to C#", "Alice", 600);
        var video2 = new Video("Advanced C# Tips", "Bob", 900);
        var video3 = new Video("Understanding Abstraction", "Carol", 720);

        video1.AddComment(new Comment("John", "Great tutorial!"));
        video1.AddComment(new Comment("Sarah", "Very helpful, thank you!"));
        video1.AddComment(new Comment("Mike", "Can't wait for the next one."));

        video2.AddComment(new Comment("Alice", "Love the tips, very practical!"));
        video2.AddComment(new Comment("John", "Super useful for my project."));
        video2.AddComment(new Comment("Emma", "I learned a lot!"));

        video3.AddComment(new Comment("Carol", "This explains abstraction so well."));
        video3.AddComment(new Comment("Paul", "Informative and concise."));
        video3.AddComment(new Comment("Nina", "Great job!"));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
