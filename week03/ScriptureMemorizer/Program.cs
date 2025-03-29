using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Reference reference1 = new Reference("3 Nephi", 5, 13);
        Reference reference2 = new Reference("Doctrine and Covenants", 88, 67,68);
        Scripture scripture1 = new Scripture(reference1,"Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life.");
        Scripture scripture2 = new Scripture(reference2,"And if your eye be single to my glory, your whole bodies shall be filled with light, and there shall be no darkness in you; and that body which is filled with light comprehendeth all things. Therefore, sanctify yourselves that your minds become single to God, and the days will come that you shall see him; for he will unveil his face unto you, and it shall be in his own time, and in his own way, and according to his own will.");
        
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);

        string userInput = "";
        
      
       foreach(var scripture in scriptures){
         Console.WriteLine(scripture.GetDisplayText());
            while(userInput == ""){

                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();
                Console.Clear();
                scripture.HideRandomWords();
                if(scripture.IsCompletelyHidden() == true){
                    Console.WriteLine();
                    break;
                }

            }
            
       }
        
            

    }
}