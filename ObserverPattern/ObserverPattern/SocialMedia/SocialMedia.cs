using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class SocialMedia
    {
        protected abstract string Name { get; set; }

        protected abstract int Likes { get; set; }

        protected abstract List<string> Posts { get; set; }

        protected abstract List<ISocialMediaSubscriber> subscribers { get; set; }

        public void Post(string post)
        {
            Posts.Add(post);
            NotifySubscribersNewPost(post);
        }

        public void Like()
        {
            Likes++;
            NotifySubscribersNewLike();
        }

        public void Subscribe(ISocialMediaSubscriber subscriber) => subscribers.Add(subscriber);
        public void Unsubscribe(ISocialMediaSubscriber subscriber) => subscribers.Remove(subscriber);

        private void NotifySubscribersNewLike()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.UpdateLikes(Name, Likes);
            }
        }

        private void NotifySubscribersNewPost(string post)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.NotifyNewPost(Name, post);
            }
        }

    }
}
