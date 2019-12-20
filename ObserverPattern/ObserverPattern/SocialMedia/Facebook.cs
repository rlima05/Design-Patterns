﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Facebook : SocialMedia
    {
        protected override string Name { get; set; }
        protected override int Likes { get; set; }
        protected override List<string> Posts { get; set; }
        protected override List<ISocialMediaSubscriber> subscribers { get; set; }

        public Facebook()
        {
            Name = "Facebook";
            Likes = 0;
            Posts = new List<string>();
            subscribers = new List<ISocialMediaSubscriber>();
        }
    }
}
