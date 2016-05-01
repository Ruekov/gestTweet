using GestTweet.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestTweet.Classes
{
    public static class OpenFileArchive
    { 

        public static List<Tweet> OpenFileJSON(string filePath){

            List<Tweet> jsonResponse = new List<Tweet>();

            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();

                json = json.Substring(json.IndexOf("=") + 1);

                jsonResponse = JsonConvert.DeserializeObject<List<Tweet>>(json);

            }

            return jsonResponse;


        }

        public static List<Tweet> openFileZip(string filePath) {

            string Tempguid = Guid.NewGuid().ToString();

            var m_File = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName, Tempguid);
            var m_FileData = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName, Tempguid, "data","js","tweets");

            List<Tweet> jsonResponse = new List<Tweet>();

            try
            {

                ZipFile.ExtractToDirectory(filePath, m_File);

                var listFiles = Directory.GetFiles(m_FileData).ToList();

                foreach (var item in listFiles)
                {
                    if (Path.GetExtension(item) == ".js")
                    {

                        using (StreamReader r = new StreamReader(item))
                        {
                            string json = r.ReadToEnd();

                            json = json.Substring(json.IndexOf("=") + 1);

                            jsonResponse.AddRange(JsonConvert.DeserializeObject<List<Tweet>>(json));

                        }

                    }

                }


                SavedExports.Load();

                SavedExports.Instance.ListOfExports.Add(new SavedExports.GestTweetExport()
                {
                    dateOfExport = DateTime.Now,
                    DirectoryName = m_FileData,
                    NumOfTweets = jsonResponse.Count(),
                    typeExport = SavedExports.TypeOfExport.ZIP
                });

                SavedExports.Save();

                return jsonResponse;


            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<Tweet> openExportedZip(string filePath)
        {

            List<Tweet> jsonResponse = new List<Tweet>();

            try
            {

                var listFiles = Directory.GetFiles(filePath).ToList();

                foreach (var item in listFiles)
                {
                    if (Path.GetExtension(item) == ".js")
                    {

                        using (StreamReader r = new StreamReader(item))
                        {
                            string json = r.ReadToEnd();

                            json = json.Substring(json.IndexOf("=") + 1);

                            jsonResponse.AddRange(JsonConvert.DeserializeObject<List<Tweet>>(json));

                        }

                    }

                }

                return jsonResponse;


            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
