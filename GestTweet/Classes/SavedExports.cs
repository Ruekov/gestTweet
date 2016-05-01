using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTweet.Classes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    [Serializable()]
    public class SavedExports
    {

        private static SavedExports m_Instance;
        private static string m_File;

        public enum TypeOfExport
        {
            ZIP,
            JS,
            API

        }

        public class GestTweetExport
        {
            public DateTime dateOfExport { get; set; }
            public string DirectoryName { get; set; }
            public int NumOfTweets { get; set; }
            public TypeOfExport typeExport { get; set; }
        }


        public List<GestTweetExport> ListOfExports;

        public static SavedExports Instance
        {

            get
            {
                if (SavedExports.m_Instance == null)
                    SavedExports.m_Instance = new SavedExports();
                if (SavedExports.m_Instance.ListOfExports == null)
                    SavedExports.m_Instance.ListOfExports = new List<GestTweetExport>();
                return SavedExports.m_Instance;
            }

        }

        public static void listPreviousExports()
        {


            var m_ExportFiles = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);

            //var listFiles = Directory.GetDirectories();



        }

        public SavedExports()
        {

            SavedExports.m_File = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName);

            if (!System.IO.Directory.Exists(m_File))
            {

                System.IO.Directory.CreateDirectory(m_File);

            }

            m_File = System.IO.Path.Combine(m_File, "exports.xml");


        }

        public static void Load()
        {

            SavedExports _Settings = new SavedExports();

            if (System.IO.File.Exists(m_File))
            {

                using (System.IO.FileStream fs = System.IO.File.OpenRead(m_File))
                {

                    try
                    {

                        XmlSerializer xs = new XmlSerializer(typeof(SavedExports));
                        _Settings = (SavedExports)xs.Deserialize(fs);

                    }
                    catch
                    {

                        _Settings = new SavedExports();


                    }
                }

            }
            else
            {

                _Settings = new SavedExports();
                SavedExports.Instance.ListOfExports = new List<GestTweetExport>();

            }

            SavedExports.Instance.ListOfExports = _Settings.ListOfExports;

        }

        public static void Save()
        {

            using (System.IO.FileStream fs = new System.IO.FileStream(m_File, System.IO.FileMode.Create))
            {

                using (System.IO.TextWriter writer = new System.IO.StreamWriter(fs, System.Text.Encoding.UTF8))
                {

                    XmlSerializer xs = new XmlSerializer(typeof(SavedExports));
                    xs.Serialize(writer, SavedExports.Instance);

                }

            }
        }
    }
}
