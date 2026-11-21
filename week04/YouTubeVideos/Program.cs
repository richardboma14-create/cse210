using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learning C# Basics", "Code Academy", 600);
        video1.AddComment(new Comment("John", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Mary", "I finally understand variables."));
        video1.AddComment(new Comment("David", "Looking forward to the next lesson."));

        // Video 2
        Video video2 = new Video("Introduction to Programming", "Tech World", 900);
        video2.AddComment(new Comment("Sarah", "Great explanation."));
        video2.AddComment(new Comment("Peter", "This made programming easier."));
        video2.AddComment(new Comment("James", "Thanks for sharing!"));

        // Video 3
        Video video3 = new Video("Understanding Object-Oriented Programming", "Programming Hub", 1200);
        video3.AddComment(new Comment("Grace", "Abstraction is much clearer now."));
        video3.AddComment(new Comment("Michael", "Excellent examples."));
        video3.AddComment(new Comment("Daniel", "Very informative video."));
        video3.AddComment(new Comment("Faith", "Please make more videos like this."));

        // Video 4
        Video video4 = new Video("Introduction to Web Development", "Web Masters", 750);
        video4.AddComment(new Comment("Alex", "I enjoyed this lesson."));
        video4.AddComment(new Comment("Rachel", "The explanations were simple."));
        video4.AddComment(new Comment("Samuel", "Very useful content."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }
        }
    }
}
