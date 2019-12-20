using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Subscribers
{
    public class InstagramSubscriber : ISocialMediaSubscriber
    {
        public void NotifyNewPost(string socialMedia, string post)
        {
            Console.WriteLine($"InstagramSubscriber notified about the post: {post} on {socialMedia}");
        }

        public void UpdateLikes(string socialMedia, int likes)
        {
            Console.WriteLine($"InstagramSubscriber notified about number of likes: {likes} on {socialMedia}");
        }
    }
}
