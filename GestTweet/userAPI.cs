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
    public partial class userAPI : Form
    {
        public userAPI()
        {
            InitializeComponent();
        }

        private void userAPI_Load(object sender, EventArgs e)

        {

            Settings.Load();

            this.textBoxConsumerKey.Text = Settings.Instance.UserAccesAPI.ConsumerKey;
            this.textBoxConsumerSecret.Text = Settings.Instance.UserAccesAPI.ConsumerSecret;
            this.textBoxOAuthToken.Text = Settings.Instance.UserAccesAPI.OAuthToken;
            this.textBoxOAuthTokenSecret.Text = Settings.Instance.UserAccesAPI.OAuthTokenSecret;
            this.textBoxUsername.Text = Settings.Instance.username;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Settings.Instance.UserAccesAPI.ConsumerKey = this.textBoxConsumerKey.Text;
            Settings.Instance.UserAccesAPI.ConsumerSecret = this.textBoxConsumerSecret.Text;
            Settings.Instance.UserAccesAPI.OAuthToken = this.textBoxOAuthToken.Text;
            Settings.Instance.UserAccesAPI.OAuthTokenSecret = this.textBoxOAuthTokenSecret.Text;
            Settings.Instance.username = this.textBoxUsername.Text;

            Settings.Save();

            this.DialogResult = DialogResult.OK;

            this.Close();

        }
    }
}
