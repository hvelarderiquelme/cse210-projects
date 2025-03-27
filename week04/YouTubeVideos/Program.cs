using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Comment comment1 = new Comment("Horacio", "comment 1");
        Comment comment2 = new Comment("Charles", "comment 2");
        Comment comment3 = new Comment("Sergio", "comment 3");
        Comment comment4 = new Comment("Peter", "comment 4");
        Comment comment5 = new Comment("karla", "comment 5");
        Comment comment6 = new Comment("Suzanne", "comment 6");
        Comment comment7 = new Comment("Andres", "comment 7");
        Comment comment8 = new Comment("kezia", "comment 8");
        Comment comment9 = new Comment("Lydia", "comment 9");
        Comment comment10 = new Comment("Lia", "comment 10");
        Comment comment11 = new Comment("Rafael", "comment 11");
        Comment comment12 = new Comment("Valerie", "comment 12");
        

        videos.Add(new Video("Sunrise", "Carlos", 44.32,[comment1,comment2,comment3,comment4,comment5]));
        videos.Add(new Video("Dance", "Raul", 123.99,[comment6,comment7,comment8]));
        videos.Add(new Video("Cooking", "Mariana", 75,[comment9,comment10,comment11,comment12]));

        
        foreach(var video in videos){
            video.NumberOfComments();
            Console.WriteLine();
        }
        
    }
}