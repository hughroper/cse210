using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video(
            "How to Use a Mesh Radio",
            "Hugh Roper",
            915
        );

        Comment c1 = new Comment(
           "Joe",
          "Great introduction to MeshCore!"
        );

        Comment c2 = new Comment(
            "Sue",
            "This helped me get my Heltec V4 working."
        );

        Comment c3 = new Comment(
            "Bob",
            "Can you make a video about room servers?"
        );

        video1.AddComment(c1);
        video1.AddComment(c2);
        video1.AddComment(c3);

        Console.WriteLine($"\n");

        video1.DisplayVideoInfo();

    }
}