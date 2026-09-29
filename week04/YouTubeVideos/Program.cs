using System;
using System.Collections.Generic;

namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Peru National Team - Season Highlights", "Bicolor Sports", 620);
        video1.AddComment(new Comment("Renzo_Dev", "That second goal was brilliant. Exceptional play by the team!"));
        video1.AddComment(new Comment("Giancarlo_M", "The tactical analysis in this video is on point. Subscribed."));
        video1.AddComment(new Comment("Stefano_C", "Great effort from our players. Outstanding video quality!"));
        videos.Add(video1);

        Video video2 = new Video("How to Prepare Authentic Lomo Saltado", "Peruvian Cuisine", 850);
        video2.AddComment(new Comment("Ximena_Gourmet", "An excellent recipe! The wok technique makes all the difference."));
        video2.AddComment(new Comment("Roberto_B", "Tried this at home today and it turned out delicious. Thank you for sharing!"));
        video2.AddComment(new Comment("Luciana_M", "Clear instructions and great presentation. Looking forward to your next recipe."));
        video2.AddComment(new Comment("Piero_Lima", "High quality ingredients are indeed the key. Wonderful explanation."));
        videos.Add(video2);

        Video video3 = new Video("Exploring Miraflores & Barranco Historic Architecture", "Cultural Journeys", 1100);
        video3.AddComment(new Comment("Mateo_Travels", "Barranco's artistic atmosphere is truly unique. Beautiful footage!"));
        video3.AddComment(new Comment("Valeria_S", "Wonderful tour! Miraflores has such stunning coastal views."));
        video3.AddComment(new Comment("Joaquin_CR", "Very insightful guide to Lima's heritage. Excellent production value."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }
            Console.WriteLine();
        }
    }
}