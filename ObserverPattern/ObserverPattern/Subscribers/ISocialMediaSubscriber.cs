using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface ISocialMediaSubscriber
    {
        void UpdateLikes(string socialMedia, int likes);
        void NotifyNewPost(string socialMedia, string post);
    }
}
