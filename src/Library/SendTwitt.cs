using System;

namespace Library
{
    public class SendTwitt
    {
        protected string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        protected string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        protected string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        protected string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";

         public void Send(string message, string imagePath)
         {
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter(message,imagePath));
         }
    }
}
