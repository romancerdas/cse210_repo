using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        List<Video> ListOfVideos = new List<Video>();

        // make a video 
        Video gaming_video = new Video("New Game Just Dropped", "RandomGamer", 600);

        // make comments 
        Comment gaming_comment1 = new Comment("John S.", "360 No-Scope!!");
        Comment gaming_comment2 = new Comment("Sarah J.", "Wow, what a great video, great work");
        Comment gaming_comment3 = new Comment("Thiago R.", "Get good scrub");

        // add comments to List in Video object 
        gaming_video.AddComment(gaming_comment1);
        gaming_video.AddComment(gaming_comment2);
        gaming_video.AddComment(gaming_comment3);

        // make video 
        Video cooking_video = new Video("My Favorite Recipe", "CookingWithGrandma", 1200);

        // make comments 
        Comment cooking_comment1 = new Comment("Angela W.", "I'm gonna try this next time!");
        Comment cooking_comment2 = new Comment("Samantha P.", "Great recipe, looks yummy!");
        Comment cooking_comment3 = new Comment("Karen G.", "Can you make it gluten free?");

        // add comments to List in Video object 
        cooking_video.AddComment(cooking_comment1);
        cooking_video.AddComment(cooking_comment2);
        cooking_video.AddComment(cooking_comment3);


        // make video 
        Video news_video = new Video("Today's News", "NewsStation", 10000000);

        // make comments 
        Comment news_comment1 = new Comment("Mike L.", "Thanks for the update!");
        Comment news_comment2 = new Comment("Linda K.", "Very informative.");
        Comment news_comment3 = new Comment("George H.", "I appreciate the unbiased reporting.");

        // add comments to List in Video object 
        news_video.AddComment(news_comment1);
        news_video.AddComment(news_comment2);
        news_video.AddComment(news_comment3);

        // add videos to ListOfVideos
        ListOfVideos.Add(gaming_video);
        ListOfVideos.Add(cooking_video);
        ListOfVideos.Add(news_video);

        // iterate through the list of videos and display information

        foreach (Video video in ListOfVideos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }



    }
}