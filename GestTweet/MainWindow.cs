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
    public partial class MainWindow : Form
    {
        public object SaveExports { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonJS_Click(object sender, EventArgs e)
        {

            this.LoadFromJS();

        }

        private void LoadFromJS()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "js files (*.js)|*.js";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    this.bindingSrcTweets.DataSource = OpenFileArchive.OpenFileJSON(openFileDialog1.FileName);

                    this.toolStripStatusNumTweets.Text = "Loaded tweets: " + this.bindingSrcTweets.Count.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void LoadFromZIP()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "zip files (*.zip)|*.zip";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    this.bindingSrcTweets.DataSource = OpenFileArchive.openFileZip(openFileDialog1.FileName);

                    this.toolStripStatusNumTweets.Text = "Loaded tweets: " + this.bindingSrcTweets.Count.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonZIP_Click(object sender, EventArgs e)
        {
            this.LoadFromZIP();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusNumTweets.Text = "";

            Settings.Load();

            if (Settings.Instance.username == "")
            {
                this.loadAPIToolStripMenuItem.Enabled = false;
            }

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            userAPI window = new userAPI();

            window.ShowDialog();

            if (window.DialogResult == DialogResult.OK)
            {

                try
                {

                    this.bindingSrcTweets.DataSource = TweetAPI.GetFromAPI();

                    this.toolStripStatusNumTweets.Text = "Loaded tweets: " + this.bindingSrcTweets.Count.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void buttonStartAPI_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;

            this.LoadFromAPI();

            Cursor.Current = Cursors.Default;

            Application.DoEvents();

        }

        private void LoadFromAPI()
        {
            if (Settings.Instance.username != "")
            {

                try
                {

                    var tweetsFromAPI = TweetAPI.GetFromAPI();

                    this.bindingSrcTweets.DataSource = tweetsFromAPI;

                    this.toolStripStatusNumTweets.Text = "Loaded tweets: " + this.bindingSrcTweets.Count.ToString();

                    string Tempguid = Guid.NewGuid().ToString();

                    var m_File = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName, Tempguid);

                    System.IO.Directory.CreateDirectory(m_File);

                    m_File = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.ProductName, Tempguid, "exports.xml");

                    TweetAPI.SaveTweets(m_File, tweetsFromAPI);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userAPI window = new userAPI();
            window.ShowDialog();

        }

        private void fromPreviousLoadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreviousLoadsForm screen = new PreviousLoadsForm();
            if (screen.ShowDialog() == DialogResult.OK)
            {
                this.bindingSrcTweets.DataSource = screen.LoadedArchive;


            }
        }

        private void fromjsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.toolStripStatusNumTweets.Text = "Loading...";

            Application.DoEvents();

            this.LoadFromJS();

            Cursor.Current = Cursors.Default;

            Application.DoEvents();
        }

        private void fromzipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.toolStripStatusNumTweets.Text = "Loading...";

            Application.DoEvents();

            this.LoadFromZIP();

            Cursor.Current = Cursors.Default;

            Application.DoEvents();

        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userAPI window = new userAPI();
            window.ShowDialog();

        }

        private void loadAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.toolStripStatusNumTweets.Text = "Loading...";

            Application.DoEvents();

            this.LoadFromAPI();

            Cursor.Current = Cursors.Default;

            Application.DoEvents();
        }

        private void buttonOpenPrevious_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingSrcTweets_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {

                if (item.Cells[0].Selected == true)
                {

                    TweetAPI.DeleteTweet((long)item.Cells[2].Value);
                   
                }

            }
        }
    }
}
