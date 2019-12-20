using System;
using ObserverPattern.Subscribers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebook = new Facebook();
            var instagram = new Instagram();

            var facebookSubscriber = new FacebookSubscriber();
            facebook.Subscribe(facebookSubscriber);

            var instagramSubscriber = new InstagramSubscriber();
            instagram.Subscribe(instagramSubscriber);

            var bothSubscriber = new BothSubscriber();
            facebook.Subscribe(bothSubscriber);
            instagram.Subscribe(bothSubscriber);

            facebook.Like();
            facebook.Like();
            facebook.Post("Test");
            facebook.Like();

            instagram.Like();
            instagram.Like();
            instagram.Post("Test");
            instagram.Like();

            instagram.Unsubscribe(bothSubscriber);
            Console.WriteLine("Unsubscribed");
            instagram.Like();

            Console.ReadKey();
        }
    }
}
