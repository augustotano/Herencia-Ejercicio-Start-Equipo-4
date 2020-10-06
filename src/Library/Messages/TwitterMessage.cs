using System;

namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
         public void Send(IMessage message)
         {
            string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
            string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
            string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
            string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("Hello world!",@"Channing Tatum.png"));
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage(message.Text, message.To));
         }
    }
}
