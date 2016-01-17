using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTweet.Classes
{
    class TweetAPI
    {

        public TweetAPI() {

            Settings.Load();

        }

        public static PinAuthorizer auth = new PinAuthorizer
        {
            CredentialStore = new SingleUserInMemoryCredentialStore
            {
                ConsumerSecret = Settings.Instance.UserAccesAPI.ConsumerSecret,
                ConsumerKey = Settings.Instance.UserAccesAPI.ConsumerKey,
                OAuthToken = Settings.Instance.UserAccesAPI.OAuthToken,
                OAuthTokenSecret = Settings.Instance.UserAccesAPI.OAuthTokenSecret
            }

        };


        public static List<Tweet> GetFromAPI() {



            ulong sinceID = 83407830496968704;
            List<Tweet> statusList = new List<Tweet>();

            var twitterCtx = new TwitterContext(auth);


            ulong maxID;
            const int Count = 6000;


            var userStatusResponse =
                (from tweet in twitterCtx.Status
                 where tweet.Type == StatusType.User &&
                   tweet.ScreenName == Settings.Instance.username &&
                   tweet.SinceID == sinceID &&
                   tweet.Count == Count &&
                   tweet.Retweeted == false
                 select tweet)
                .ToList();

            foreach (var item in userStatusResponse)
            {
                statusList.Add((Tweet)item);
            }

            // first tweet processed on current query
            maxID = userStatusResponse.Min(
                status => ulong.Parse(status.StatusID.ToString())) - 1;

            do
            {
                // now add sinceID and maxID
                userStatusResponse =
                    (from tweet in twitterCtx.Status
                     where tweet.Type == StatusType.User &&
                           tweet.ScreenName == Settings.Instance.username &&
                           tweet.Count == Count &&
                           tweet.SinceID == sinceID &&
                           tweet.MaxID == maxID &&
                           tweet.Retweeted == false
                     select tweet)
                    .ToList();

                if (userStatusResponse.Count > 0)
                {
                    // first tweet processed on current query
                    maxID = userStatusResponse.Min(
                        status => ulong.Parse(status.StatusID.ToString())) - 1;

                    foreach (var item in userStatusResponse)
                    {
                        statusList.Add((Tweet)item);
                    }
                }
            }
            while (userStatusResponse.Count != 0 && statusList.Count < Count);

            return statusList.ToList();


        }



    }
}
