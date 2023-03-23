using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.Clear();
        Command commmand = new Command();

        int choice = 0;
        while (choice != 4)
        {
        choice = commmand.DisplayMenu();
        switch(choice)
        {
            case 1:
                Video video = new Video("N/A", "N/A", 0);
                System.Console.Write("Enter Video title: ");
                string title = Console.ReadLine();
                video.Title = title;
                System.Console.Write("Enter author name: ");
                string author = Console.ReadLine();
                video.Author= author;
                System.Console.Write("How long is the video?(Hrs) ");
                string len = Console.ReadLine();
                int length = int.Parse(len);
                video.Length = length;

                int choose = 0;
                while (choose != 2)
                {
                    choose = commmand.GetVideoOption();
                switch(choose)
                {
                    case 1:

                        video.AddComment();
                        choose = commmand.GetVideoOption();
                        break;
                }
                videos.Add(video);
                }
                break;

            case 2:
                foreach(Video media in videos)
                {
                    System.Console.WriteLine($"Video Name: {media.Title}");
                    System.Console.WriteLine($"Author Name: {media.Author}");
                    System.Console.WriteLine($"Video Length: {media.Length} hour");

                    System.Console.WriteLine("Comments:");
                    media.DisplayComment();

                }
                    break;
            case 3:
                
                for(int i = 0; i < videos.Count(); i++ )
                {
                    System.Console.WriteLine($"{i+1}. {videos[i].Title}");
                }
                System.Console.Write("Which video would you like to remove? ");
                string remove = Console.ReadLine();
                int removingIndex = int.Parse(remove);
                videos.RemoveAt(removingIndex-1);

                System.Console.WriteLine($"Video removed"); 
                break;
            
        }
                
        }
    }
}