using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Windows.Forms;

namespace GestTweet.Classes
{

    [Serializable()]
    public class Settings
    {

        private static Settings m_Instance;
        private static String m_File;

        public struct ApiTwitter
        {
            public string ConsumerSecret;
            public string ConsumerKey;
            public string OAuthToken;
            public string OAuthTokenSecret;
        }


        public ApiTwitter UserAccesAPI;
        public string username;

        public static Settings Instance
        {

            get
            {
                if (m_Instance == null)
                    m_Instance = new Settings();
                return m_Instance;
            }

        }

        public Settings()
        {

            m_File = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);

            if (!System.IO.Directory.Exists(m_File))
            {

                System.IO.Directory.CreateDirectory(m_File);

            }

            m_File = System.IO.Path.Combine(m_File, "settings.xml");


        }

        public static void Load()
        {

            Settings _Settings = new Settings();

            if (System.IO.File.Exists(m_File))
            {

                using (System.IO.FileStream fs = System.IO.File.OpenRead(m_File))
                {

                    try
                    {

                        XmlSerializer xs = new XmlSerializer(typeof(Settings));
                        _Settings = (Settings)xs.Deserialize(fs);

                    }
                    catch
                    {

                        _Settings = new Settings();

                    }
                }

            }
            else
            {

                _Settings = new Settings();

            }

            Instance.UserAccesAPI.ConsumerKey = _Settings.UserAccesAPI.ConsumerKey;
            Instance.UserAccesAPI.ConsumerSecret = _Settings.UserAccesAPI.ConsumerSecret;
            Instance.UserAccesAPI.OAuthToken = _Settings.UserAccesAPI.OAuthToken;
            Instance.UserAccesAPI.OAuthTokenSecret = _Settings.UserAccesAPI.OAuthTokenSecret;
            Instance.username = _Settings.username;

        }

        public static void Save()
        {

            using (System.IO.FileStream fs = new System.IO.FileStream(m_File, System.IO.FileMode.Create))
            {

                using (System.IO.TextWriter writer = new System.IO.StreamWriter(fs, System.Text.Encoding.UTF8))
                {

                    XmlSerializer xs = new XmlSerializer(typeof(Settings));
                    xs.Serialize(writer, Instance);

                }

            }




        }





    }


}
