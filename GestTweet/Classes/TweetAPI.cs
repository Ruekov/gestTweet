using GestTweet.Classes;
using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public static void SaveTweets(string filepath, List<Tweet> saveTweets) {

            using (System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.Create))
            {

                using (System.IO.TextWriter writer = new System.IO.StreamWriter(fs, System.Text.Encoding.UTF8))
                {

                    XmlSerializer xs = new XmlSerializer(typeof(List<Tweet>));
                    xs.Serialize(writer, saveTweets);

                }

            }

            SavedExports.Load();

            SavedExports.Instance.ListOfExports.Add(new SavedExports.GestTweetExport()
            {
                dateOfExport = DateTime.Now,
                DirectoryName = filepath,
                NumOfTweets = saveTweets.Count(),
                typeExport = SavedExports.TypeOfExport.API
            });

            SavedExports.Save();

        }

        public static List<Tweet> readSavedTweets(string filepath) {

            List<Tweet> listToReturn = new List<Tweet>();


            if (System.IO.File.Exists(filepath))
            {

                using (System.IO.FileStream fs = System.IO.File.OpenRead(filepath))
                {

                    try
                    {

                        XmlSerializer xs = new XmlSerializer(typeof(List<Tweet>));
                        listToReturn = (List<Tweet>)xs.Deserialize(fs);

                    }
                    catch
                    {

                    }
                }

            }

            return listToReturn;

        }

        public static async Task<bool> DeleteTweet(long refid)
        {
            try
            {
                var twitterCtx = new TwitterContext(auth);
                Status status = await twitterCtx.DeleteTweetAsync((ulong)refid);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
