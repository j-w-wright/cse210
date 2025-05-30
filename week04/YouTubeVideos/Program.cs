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
        Comment comment4 = new Comment("Darla", "This is a fantastic video! I learned so much.");
        Comment comment5 = new Comment("Charlie", "Great tips! I can't wait to try them out.");
        Comment comment6 = new Comment("Smithy", "I love the way you explain things.  You make it so easy to understand.");
        Comment comment7 = new Comment("Ethan", "This is a fantastic video! I learned so much.");
        Comment comment8 = new Comment("Fiona", "That was interesting! I can't wait to try those suggestions out.");
        Comment comment9 = new Comment("George", "Such an amazing video!  That explanation was so clear and easy to follow.");

        Console.WriteLine();

        // Create instances of Videos
        Video video1 = new Video("How to Sail a Boat", "Captain Jack", 321);
        Video video2 = new Video("How to accomplish your goals", "Doctor Marvin", 670);
        Video video3 = new Video("How to dive", "Bob Wiley", 478);

        // Create a list of videos
        Video[] videos = { video1, video2, video3 };

        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);
        video2.Comments.Add(comment4);
        video2.Comments.Add(comment5);
        video2.Comments.Add(comment6);
        video3.Comments.Add(comment7);
        video3.Comments.Add(comment8);
        video3.Comments.Add(comment9);

        Console.WriteLine(video1.DisplayVideoInfo());
        Console.WriteLine("Comments: ");
        foreach (Comment comment in video1.Comments)
        {
            Console.WriteLine(comment.Author + ": " + comment.CommentText);
        }
        Console.WriteLine();
        Console.WriteLine(video2.DisplayVideoInfo());
        Console.WriteLine("Comments: ");
        foreach (Comment comment in video2.Comments)
        {
            Console.WriteLine(comment.Author + ": " + comment.CommentText);
        }
        Console.WriteLine();
        Console.WriteLine(video3.DisplayVideoInfo());
        Console.WriteLine("Comments: ");
        foreach (Comment comment in video3.Comments)
        {
            Console.WriteLine(comment.Author + ": " + comment.CommentText);
        }
        Console.WriteLine();
        // Display the total number of videos
        Console.WriteLine($"Total number of videos: {videos.Length}");
        Console.WriteLine();
    }
}