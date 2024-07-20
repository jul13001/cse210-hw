using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1._author = "John Smith";
        video1._title = " Happy Days";
        video1._length = 1;
        Video video2 = new Video();
        video2._author = "Tamara Johnson";
        video2._title = "Sad Days";
        video2._length = 2;
        Video video3 = new Video();
        video3._author = "Dwayne Wade";
        video3._title = "Basketball Days";
        video3._length = 3;
        
        Comment comment1 = new Comment("Jackie", "This is a cool video!");
        Comment comment2 = new Comment("Greg", "This is a lousy video");
        Comment comment3 = new Comment("Adam", "It was nice to learn something new");

        Comment comment4 = new Comment("Edward", "I've never seen anything like this!");
        Comment comment5 = new Comment("Albert", "I'm shocked");
        Comment comment6 = new Comment("Dean", "When will this torture end!");

        Comment comment7 = new Comment("Evan", "You have to be kidding me!");
        Comment comment8 = new Comment("Kimberly", "Is this real life?");
        Comment comment9 = new Comment("Deborah", "Like this comment if your here in 2024");
        Comment comment10 = new Comment("Betty", "I don't understand how this is funny");

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        video1.Display();
        Console.WriteLine();
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2.Display();
        Console.WriteLine();
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);

        video3.Display();


    }
}