using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class FacebookSubscriber : ISocialMediaSubscriber
    {
        public void NotifyNewPost(string socialMedia, string post)
        {
            Console.WriteLine($"FacebookSubscriber notified about the post: {post} on {socialMedia}");
        }

        public void UpdateLikes(string socialMedia, int likes)
        {
            Console.WriteLine($"FacebookSubscriber notified about number of likes: {likes} on {socialMedia}");
        }
    }
}
