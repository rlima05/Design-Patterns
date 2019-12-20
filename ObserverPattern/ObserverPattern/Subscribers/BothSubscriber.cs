using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Subscribers
{
    public class BothSubscriber : ISocialMediaSubscriber
    {
        public void NotifyNewPost(string socialMedia, string post)
        {
            Console.WriteLine($"BothSubscriber notified about the post: {post} on {socialMedia}");
        }

        public void UpdateLikes(string socialMedia, int likes)
        {
            Console.WriteLine($"BothSubscriber notified about number of likes: {likes} on {socialMedia}");
        }
    }
}
