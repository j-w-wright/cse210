using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create instances of Comments
        Comment comment1 = new Comment("Bob", "Great video!  I love to learn more about sailing.");
        Comment comment2 = new Comment("Leo", "Keep working hard!  Just take baby steps and you can accomplish amazing things.");
        Comment comment3 = new Comment("Ziggy", "I love the way you explain things.  You make it so easy to understand.");

        // Display the comments
        Console.WriteLine("Comments:");
        Console.WriteLine($"1. {comment1.Author}: {comment1.CommentText}");
        Console.WriteLine($"2. {comment2.Author}: {comment2.CommentText}");
        Console.WriteLine($"3. {comment3.Author}: {comment3.CommentText}");
        Console.WriteLine();

        // Create instances of Videos
        Video video1 = new Video("How to Sail a Boat", "Captain Jack", 321);

        Video video2 = new Video("How to accomplish your goals", "Doctor Marvin", 670);

        Video video3 = new Video("How to dive", "Bob Wiley", 478);

        // Display video information
        Console.WriteLine("Videos:");
        Console.WriteLine(video1.DisplayVideoInfo());
        Console.WriteLine(video2.DisplayVideoInfo());
        Console.WriteLine(video3.DisplayVideoInfo());
        Console.WriteLine();
        // Create a list of videos
        Video[] videos = { video1, video2, video3 };
        // Display all videos
        Console.WriteLine("All Videos:");
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideoInfo());
        }
        Console.WriteLine();
        // Display the total number of videos
        Console.WriteLine($"Total number of videos: {videos.Length}");
        Console.WriteLine();
    }
}