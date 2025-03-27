using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Comment comment1 = new Comment("Horacio Velarde", "Lorem ipsum dolor sit amet.");
        Comment comment2 = new Comment("Charles Dickens", "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Voluptatum quaerat necessitatibus inventore dignissimos dolorem ex.");
        Comment comment3 = new Comment("Sergio Martinez", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Explicabo voluptate possimus ullam fuga ea laudantium!");
        Comment comment4 = new Comment("Peter Goldsmith", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam dolorem deleniti commodi. Possimus quasi nesciunt totam corporis.");
        Comment comment5 = new Comment("karla Tailor", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex, nesciunt nulla!");
        Comment comment6 = new Comment("Suzanne Walker", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti nobis, odit rem ab et ut officiis quisquam quos alias, vitae distinctio omnis voluptatem consequuntur?");
        Comment comment7 = new Comment("Andres Garcia", "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Minus, quia!");
        Comment comment8 = new Comment("kezia Vaillard", "comment 8 Lorem ipsum dolor sit amet consectetur adipisicing elit. Explicabo, voluptate!");
        Comment comment9 = new Comment("Lydia Villo", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam.");
        Comment comment10 = new Comment("Lia Baker", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat incidunt unde facere quasi laboriosam eveniet!");
        Comment comment11 = new Comment("Rafael Riquelme", "Lorem ipsum dolor sit amet consectetur adipisicing.");
        Comment comment12 = new Comment("Valerie Duncan", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Optio blanditiis ex eaque impedit repudiandae dolore.");
        

        videos.Add(new Video("Sunrise", "Carlos Benavides", 44.32,[comment1,comment2,comment3,comment4,comment5]));
        videos.Add(new Video("Dance", "Raul Gutierrez", 123.99,[comment6,comment7,comment8]));
        videos.Add(new Video("Cooking", "Mariana Riquelme", 75,[comment9,comment10,comment11,comment12]));

        
        foreach(var video in videos){
            video.NumberOfComments();
            Console.WriteLine();
        }
        
    }
}