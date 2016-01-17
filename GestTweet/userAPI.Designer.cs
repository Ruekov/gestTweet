namespace GestTweet
{
    partial class userAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxConsumerSecret = new System.Windows.Forms.TextBox();
            this.textBoxConsumerKey = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxOAuthToken = new System.Windows.Forms.TextBox();
            this.textBoxOAuthTokenSecret = new System.Windows.Forms.TextBox();
            this.labelConsumerSecret = new System.Windows.Forms.Label();
            this.labelConsumerKey = new System.Windows.Forms.Label();
            this.labelOAuthToken = new System.Windows.Forms.Label();
            this.labelOAuthTokenSecret = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConsumerSecret
            // 
            this.textBoxConsumerSecret.Location = new System.Drawing.Point(12, 37);
            this.textBoxConsumerSecret.Name = "textBoxConsumerSecret";
            this.textBoxConsumerSecret.Size = new System.Drawing.Size(630, 20);
            this.textBoxConsumerSecret.TabIndex = 0;
            // 
            // textBoxConsumerKey
            // 
            this.textBoxConsumerKey.Location = new System.Drawing.Point(12, 92);
            this.textBoxConsumerKey.Name = "textBoxConsumerKey";
            this.textBoxConsumerKey.Size = new System.Drawing.Size(630, 20);
            this.textBoxConsumerKey.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 257);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(630, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxOAuthToken
            // 
            this.textBoxOAuthToken.Location = new System.Drawing.Point(12, 147);
            this.textBoxOAuthToken.Name = "textBoxOAuthToken";
            this.textBoxOAuthToken.Size = new System.Drawing.Size(630, 20);
            this.textBoxOAuthToken.TabIndex = 2;
            // 
            // textBoxOAuthTokenSecret
            // 
            this.textBoxOAuthTokenSecret.Location = new System.Drawing.Point(12, 202);
            this.textBoxOAuthTokenSecret.Name = "textBoxOAuthTokenSecret";
            this.textBoxOAuthTokenSecret.Size = new System.Drawing.Size(630, 20);
            this.textBoxOAuthTokenSecret.TabIndex = 3;
            // 
            // labelConsumerSecret
            // 
            this.labelConsumerSecret.AutoSize = true;
            this.labelConsumerSecret.Location = new System.Drawing.Point(12, 13);
            this.labelConsumerSecret.Name = "labelConsumerSecret";
            this.labelConsumerSecret.Size = new System.Drawing.Size(85, 13);
            this.labelConsumerSecret.TabIndex = 4;
            this.labelConsumerSecret.Text = "ConsumerSecret";
            // 
            // labelConsumerKey
            // 
            this.labelConsumerKey.AutoSize = true;
            this.labelConsumerKey.Location = new System.Drawing.Point(12, 68);
            this.labelConsumerKey.Name = "labelConsumerKey";
            this.labelConsumerKey.Size = new System.Drawing.Size(72, 13);
            this.labelConsumerKey.TabIndex = 5;
            this.labelConsumerKey.Text = "ConsumerKey";
            // 
            // labelOAuthToken
            // 
            this.labelOAuthToken.AutoSize = true;
            this.labelOAuthToken.Location = new System.Drawing.Point(12, 123);
            this.labelOAuthToken.Name = "labelOAuthToken";
            this.labelOAuthToken.Size = new System.Drawing.Size(68, 13);
            this.labelOAuthToken.TabIndex = 6;
            this.labelOAuthToken.Text = "OAuthToken";
            // 
            // labelOAuthTokenSecret
            // 
            this.labelOAuthTokenSecret.AutoSize = true;
            this.labelOAuthTokenSecret.Location = new System.Drawing.Point(12, 178);
            this.labelOAuthTokenSecret.Name = "labelOAuthTokenSecret";
            this.labelOAuthTokenSecret.Size = new System.Drawing.Size(99, 13);
            this.labelOAuthTokenSecret.TabIndex = 7;
            this.labelOAuthTokenSecret.Text = "OAuthTokenSecret";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 233);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(566, 295);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(485, 295);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // userAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 330);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelOAuthTokenSecret);
            this.Controls.Add(this.labelOAuthToken);
            this.Controls.Add(this.labelConsumerKey);
            this.Controls.Add(this.labelConsumerSecret);
            this.Controls.Add(this.textBoxOAuthTokenSecret);
            this.Controls.Add(this.textBoxOAuthToken);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxConsumerKey);
            this.Controls.Add(this.textBoxConsumerSecret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 369);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 369);
            this.Name = "userAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "userAPI";
            this.Load += new System.EventHandler(this.userAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsumerSecret;
        private System.Windows.Forms.TextBox textBoxConsumerKey;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxOAuthToken;
        private System.Windows.Forms.TextBox textBoxOAuthTokenSecret;
        private System.Windows.Forms.Label labelConsumerSecret;
        private System.Windows.Forms.Label labelConsumerKey;
        private System.Windows.Forms.Label labelOAuthToken;
        private System.Windows.Forms.Label labelOAuthTokenSecret;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}