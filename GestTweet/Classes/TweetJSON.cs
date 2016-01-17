using LinqToTwitter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTweet.Classes
{
    public class Tweet
    {

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("entities")]
        public Entities Entities { get; set; }

        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public static explicit operator Tweet(Status b)  // explicit byte to digit conversion operator
        {
            Tweet d = new Tweet();  // explicit conversion

            d.CreatedAt = b.CreatedAt.ToString();
            d.Text = b.Text;

            return d;
        }

        public static explicit operator Tweet(List<Status> v)
        {
            throw new NotImplementedException();
        }
    }

    public class Geo
    {
    }

    public class Entities
    {

        [JsonProperty("user_mentions")]
        public object[] UserMentions { get; set; }

        [JsonProperty("media")]
        public object[] Media { get; set; }

        [JsonProperty("hashtags")]
        public object[] Hashtags { get; set; }

        [JsonProperty("urls")]
        public object[] Urls { get; set; }
    }

    public class User
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("profile_image_url_https")]
        public string ProfileImageUrlHttps { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

}

