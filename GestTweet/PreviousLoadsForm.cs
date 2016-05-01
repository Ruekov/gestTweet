using GestTweet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestTweet
{
    public partial class PreviousLoadsForm : Form
    {

        public List<Tweet> LoadedArchive { get; set; }

        public PreviousLoadsForm()
        {
            InitializeComponent();

            SavedExports.Load();

            this.bindingSource1.DataSource = SavedExports.Instance.ListOfExports;

      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int a;

            var b = this.dataGridView1.Rows[e.RowIndex];

            string path = (string)b.Cells[1].Value;

            GestTweet.Classes.SavedExports.TypeOfExport type = (GestTweet.Classes.SavedExports.TypeOfExport)b.Cells[3].Value;

            if (type == GestTweet.Classes.SavedExports.TypeOfExport.API)
            {

                LoadedArchive = TweetAPI.readSavedTweets(path);


            }
            if (type == GestTweet.Classes.SavedExports.TypeOfExport.ZIP)
            {

                LoadedArchive = OpenFileArchive.openExportedZip(path);


            }

            this.DialogResult = DialogResult.OK;

            this.Close();

            //e.RowIndex
        }

    }
}
