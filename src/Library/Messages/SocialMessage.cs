using System;

namespace Library
{
    public class SocialMessage : IMessage
    {
        public SocialMessage(string from, string to)
        {
            this.From = from;
            this.To = to;
        }
        public string Text {get; set;}
        public string From {get;}
        public string To {get;}

        public void Notify()
        {
            new TwitterChannel().Send(this);
        }
    }
}