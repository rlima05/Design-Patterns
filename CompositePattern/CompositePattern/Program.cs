using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("C:");

            var desktop = new Folder("Desktop");
            root.AddObject(desktop);
            var historyHomework = new File("History Homework.docx");
            var myVideo = new File("My Video.mp4");

            var media = new Folder("Media");

            var pictures = new Folder("Pictures");

            var myPicture = new File("Picture.jpg");

            desktop.AddObject(historyHomework);

            desktop.AddObject(media);

            media.AddObject(pictures);

            pictures.AddObject(myPicture);

            var videos = new Folder("Videos");
            root.AddObject(videos);

            videos.AddObject(myVideo);

            var presentation = new File("Presentation.pptx");

            desktop.AddObject(presentation);

            root.Display();

            Console.ReadKey();
        }
    }
}
