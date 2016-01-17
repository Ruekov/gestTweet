namespace GestTweet
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageLoadedTweets = new System.Windows.Forms.TabPage();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxFromArchive = new System.Windows.Forms.GroupBox();
            this.ButtonLoadArchiveJS = new System.Windows.Forms.Button();
            this.ButtonLoadFromZIP = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusNumTweets = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxAPI = new System.Windows.Forms.GroupBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStartAPI = new System.Windows.Forms.Button();
            this.tabStads = new System.Windows.Forms.TabPage();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSrcTweets = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPrevious = new System.Windows.Forms.GroupBox();
            this.buttonOpenPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLoadedTweets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panelRight.SuspendLayout();
            this.groupBoxFromArchive.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxAPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSrcTweets)).BeginInit();
            this.groupBoxPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 415);
            this.splitContainer1.SplitterDistance = 792;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 415);
            this.panel1.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageLoadedTweets);
            this.tabControlMain.Controls.Add(this.tabStads);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(792, 415);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageLoadedTweets
            // 
            this.tabPageLoadedTweets.Controls.Add(this.dataGridViewMain);
            this.tabPageLoadedTweets.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoadedTweets.Name = "tabPageLoadedTweets";
            this.tabPageLoadedTweets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoadedTweets.Size = new System.Drawing.Size(784, 389);
            this.tabPageLoadedTweets.TabIndex = 0;
            this.tabPageLoadedTweets.Text = "Loaded Tweets";
            this.tabPageLoadedTweets.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sourceDataGridViewTextBoxColumn,
            this.entitiesDataGridViewTextBoxColumn,
            this.geoDataGridViewTextBoxColumn,
            this.idStrDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dataGridViewMain.DataSource = this.bindingSrcTweets;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(778, 383);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxPrevious);
            this.panelRight.Controls.Add(this.groupBoxAPI);
            this.panelRight.Controls.Add(this.groupBoxFromArchive);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.MaximumSize = new System.Drawing.Size(211, 415);
            this.panelRight.MinimumSize = new System.Drawing.Size(211, 415);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(211, 415);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxFromArchive
            // 
            this.groupBoxFromArchive.Controls.Add(this.ButtonLoadArchiveJS);
            this.groupBoxFromArchive.Controls.Add(this.ButtonLoadFromZIP);
            this.groupBoxFromArchive.Location = new System.Drawing.Point(19, 22);
            this.groupBoxFromArchive.Name = "groupBoxFromArchive";
            this.groupBoxFromArchive.Size = new System.Drawing.Size(170, 100);
            this.groupBoxFromArchive.TabIndex = 4;
            this.groupBoxFromArchive.TabStop = false;
            this.groupBoxFromArchive.Text = "From Archive";
            // 
            // ButtonLoadArchiveJS
            // 
            this.ButtonLoadArchiveJS.Location = new System.Drawing.Point(48, 31);
            this.ButtonLoadArchiveJS.Name = "ButtonLoadArchiveJS";
            this.ButtonLoadArchiveJS.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadArchiveJS.TabIndex = 1;
            this.ButtonLoadArchiveJS.Text = ".JS";
            this.ButtonLoadArchiveJS.UseVisualStyleBackColor = true;
            this.ButtonLoadArchiveJS.Click += new System.EventHandler(this.buttonJS_Click);
            // 
            // ButtonLoadFromZIP
            // 
            this.ButtonLoadFromZIP.Location = new System.Drawing.Point(48, 60);
            this.ButtonLoadFromZIP.Name = "ButtonLoadFromZIP";
            this.ButtonLoadFromZIP.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoadFromZIP.TabIndex = 2;
            this.ButtonLoadFromZIP.Text = ".ZIP";
            this.ButtonLoadFromZIP.UseVisualStyleBackColor = true;
            this.ButtonLoadFromZIP.Click += new System.EventHandler(this.buttonZIP_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1008, 24);
            this.menuStripMain.TabIndex = 5;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusNumTweets});
            this.statusStripMain.Location = new System.Drawing.Point(0, 439);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMain.TabIndex = 6;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusNumTweets
            // 
            this.toolStripStatusNumTweets.Name = "toolStripStatusNumTweets";
            this.toolStripStatusNumTweets.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusNumTweets.Text = "NumTweets";
            // 
            // groupBoxAPI
            // 
            this.groupBoxAPI.Controls.Add(this.buttonStartAPI);
            this.groupBoxAPI.Controls.Add(this.buttonSettings);
            this.groupBoxAPI.Location = new System.Drawing.Point(19, 128);
            this.groupBoxAPI.Name = "groupBoxAPI";
            this.groupBoxAPI.Size = new System.Drawing.Size(170, 93);
            this.groupBoxAPI.TabIndex = 5;
            this.groupBoxAPI.TabStop = false;
            this.groupBoxAPI.Text = "From API";
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(48, 28);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStartAPI
            // 
            this.buttonStartAPI.Location = new System.Drawing.Point(48, 57);
            this.buttonStartAPI.Name = "buttonStartAPI";
            this.buttonStartAPI.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAPI.TabIndex = 1;
            this.buttonStartAPI.Text = "StartAPI";
            this.buttonStartAPI.UseVisualStyleBackColor = true;
            this.buttonStartAPI.Click += new System.EventHandler(this.buttonStartAPI_Click);
            // 
            // tabStads
            // 
            this.tabStads.Location = new System.Drawing.Point(4, 22);
            this.tabStads.Name = "tabStads";
            this.tabStads.Padding = new System.Windows.Forms.Padding(3);
            this.tabStads.Size = new System.Drawing.Size(784, 389);
            this.tabStads.TabIndex = 1;
            this.tabStads.Text = "Stadistics";
            this.tabStads.UseVisualStyleBackColor = true;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Visible = false;
            // 
            // entitiesDataGridViewTextBoxColumn
            // 
            this.entitiesDataGridViewTextBoxColumn.DataPropertyName = "Entities";
            this.entitiesDataGridViewTextBoxColumn.HeaderText = "Entities";
            this.entitiesDataGridViewTextBoxColumn.Name = "entitiesDataGridViewTextBoxColumn";
            this.entitiesDataGridViewTextBoxColumn.ReadOnly = true;
            this.entitiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // geoDataGridViewTextBoxColumn
            // 
            this.geoDataGridViewTextBoxColumn.DataPropertyName = "Geo";
            this.geoDataGridViewTextBoxColumn.HeaderText = "Geo";
            this.geoDataGridViewTextBoxColumn.Name = "geoDataGridViewTextBoxColumn";
            this.geoDataGridViewTextBoxColumn.ReadOnly = true;
            this.geoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idStrDataGridViewTextBoxColumn
            // 
            this.idStrDataGridViewTextBoxColumn.DataPropertyName = "IdStr";
            this.idStrDataGridViewTextBoxColumn.HeaderText = "IdStr";
            this.idStrDataGridViewTextBoxColumn.Name = "idStrDataGridViewTextBoxColumn";
            this.idStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 600;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Width = 600;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSrcTweets
            // 
            this.bindingSrcTweets.DataSource = typeof(GestTweet.Classes.Tweet);
            // 
            // groupBoxPrevious
            // 
            this.groupBoxPrevious.Controls.Add(this.buttonOpenPrevious);
            this.groupBoxPrevious.Location = new System.Drawing.Point(19, 228);
            this.groupBoxPrevious.Name = "groupBoxPrevious";
            this.groupBoxPrevious.Size = new System.Drawing.Size(170, 53);
            this.groupBoxPrevious.TabIndex = 6;
            this.groupBoxPrevious.TabStop = false;
            this.groupBoxPrevious.Text = "From previous loads";
            // 
            // buttonOpenPrevious
            // 
            this.buttonOpenPrevious.Location = new System.Drawing.Point(48, 20);
            this.buttonOpenPrevious.Name = "buttonOpenPrevious";
            this.buttonOpenPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPrevious.TabIndex = 0;
            this.buttonOpenPrevious.Text = "Open ...";
            this.buttonOpenPrevious.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "MainWindow";
            this.Text = "GestTweet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLoadedTweets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.groupBoxFromArchive.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxAPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSrcTweets)).EndInit();
            this.groupBoxPrevious.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSrcTweets;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageLoadedTweets;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNumTweets;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxFromArchive;
        private System.Windows.Forms.Button ButtonLoadArchiveJS;
        private System.Windows.Forms.Button ButtonLoadFromZIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxAPI;
        private System.Windows.Forms.Button buttonStartAPI;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TabPage tabStads;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPrevious;
        private System.Windows.Forms.Button buttonOpenPrevious;
    }
}

