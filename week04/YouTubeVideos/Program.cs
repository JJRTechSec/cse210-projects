using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Programming Is Tough", "CodeWithCorey", 345);
        Comment comment1Video1 = new Comment();
        comment1Video1.SetCommenterName("Jimmy");
        comment1Video1.SetCommentText("I really can't understand C#. It's frustrating and makes ZERO sense whatsoever.");
        video1.comments.Add(comment1Video1);

        Comment comment2Video1 = new Comment();
        comment2Video1.SetCommenterName("MollyCarson");
        comment2Video1.SetCommentText("How did this end up on my feed?");
        video1.comments.Add(comment2Video1);

        Comment comment3Video1 = new Comment();
        comment3Video1.SetCommenterName("MrBlobby");
        comment3Video1.SetCommentText("I know that as a beginner, anything is tough, but I've been trying to learn how to code for a year and it's still feeling impossible. Glad to know that it's not just me though");
        video1.comments.Add(comment3Video1);

        Comment comment4Video1 = new Comment();
        comment4Video1.SetCommenterName("Juggernaut7");
        comment4Video1.SetCommentText("@MrBlobby it's only tough if you learn with no structure, or only following tutorials. Try building something simple that you want to build, and search how to do those specific things, and you'll learn quicker that way");
        video1.comments.Add(comment4Video1);

        video1.DisplayVideoInformation();
        Console.WriteLine();


        Video video2 = new Video("Creating Classes In C#", "ProgrammingTips", 1800);
        Comment comment1Video2 = new Comment();
        comment1Video2.SetCommenterName("IanHolloway89");
        comment1Video2.SetCommentText("Your way of explaining things is AMAZING. I'm finally understanding how it all pieces together.");
        video2.comments.Add(comment1Video2);

        Comment comment2Video2 = new Comment();
        comment2Video2.SetCommenterName("TommyCash");
        comment2Video2.SetCommentText("I still don't fully understand how classes can be used as types. Can you make another video on this?");
        video2.comments.Add(comment2Video2);

        Comment comment3Video2 = new Comment();
        comment3Video2.SetCommenterName("LaurenDaley");
        comment3Video2.SetCommentText("I get that having different classes means being able to hide code from other parts of the program, but is it not simpler to just have everything in one class so there's no hassle with connecting them all together?");
        video2.comments.Add(comment3Video2);

        video2.DisplayVideoInformation();
        Console.WriteLine();


        Video video3 = new Video("C# VS JavaScript. Which Is Better?", "CodingSleuth", 720);
        Comment comment1Video3 = new Comment();
        comment1Video3.SetCommenterName("JSLuvva");
        comment1Video3.SetCommentText("I much prefer JS over C#. It's a pain to learn at first but it's still simpler than C#");
        video3.comments.Add(comment1Video3);

        Comment comment2Video3 = new Comment();
        comment2Video3.SetCommenterName("DustinCoughman");
        comment2Video3.SetCommentText("They're both good for different things, but what's the difference between C#, C and C++? The syntax is different for all 3 of them but stem from the same language, so what's going on there?");
        video3.comments.Add(comment2Video3);

        Comment comment3Video3 = new Comment();
        comment3Video3.SetCommenterName("HughQuackman");
        comment3Video3.SetCommentText("Can someone summarise so I don't have to watch the whole video pls?");
        video3.comments.Add(comment3Video3);

        video3.DisplayVideoInformation();
    }
}