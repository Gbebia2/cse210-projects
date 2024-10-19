using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning Python", "Bray Wyatt", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));

        Video video2 = new Video("Preparing Egusi Soup", "Chiamaka Stevens", 450);
        video2.AddComment(new Comment("Cynthia", "I love this video!"));
        video2.AddComment(new Comment("Dana", "Taught very well."));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}