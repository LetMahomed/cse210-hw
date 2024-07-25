using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("How screens actually affect your sleep", "Vox", 398);

        Comment video1Comment1 = new Comment("@Evelyn-lq9gk", "not me watching this while IN BED");
        Comment video1Comment2 = new Comment("@shoriryu1216", "bold of you to assume that I feel alert and awake in the morning, Vox.");
        Comment video1Comment3 = new Comment("@k.cooper8816", "I always find Dark Mode more useful than Night Shift.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Why Fast Food Has Gotten So Expensive", "CNBC", 479);

        Comment video2Comment1 = new Comment("@slaction", "The real issue is that it's just not worth it.  The fast food places were never actually great, they were just cheap.  When you take cheap away there is zero reason to ever go there.");
        Comment video2Comment2 = new Comment("@aimeelee76", "I love how they keep saying that WAGES are the big reason for the price increases but then fail to mention record corporate profits. We see you, CNBC.");
        Comment video2Comment3 = new Comment("@aftersolo", "I just quit going.  Problem solved.  That garbage food is not necessary to anyone.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Can AI help us predict extreme weather?", "Vox", 491);

        Comment video3Comment1 = new Comment("@awedelen2", "Earlier predictions would be extremely helpful to all of us in the path of hurricanes.");
        Comment video3Comment2 = new Comment("@flermilyxx", "Vox delivering another excellent bit of content");
        Comment video3Comment3 = new Comment("@wbl_unlimited", "Two Microsoft AI commercials before the video.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}