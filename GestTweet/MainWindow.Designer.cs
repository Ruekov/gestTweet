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
            this.tabStads = new System.Windows.Forms.TabPage();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTweetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromjsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromPreviousLoadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusNumTweets = new System.Windows.Forms.ToolStripStatusLabel();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSrcTweets = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageLoadedTweets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSrcTweets)).BeginInit();
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
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2Collapsed = true;
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
            this.panel1.Size = new System.Drawing.Size(1008, 415);
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
            this.tabControlMain.Size = new System.Drawing.Size(1008, 415);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageLoadedTweets
            // 
            this.tabPageLoadedTweets.Controls.Add(this.dataGridViewMain);
            this.tabPageLoadedTweets.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoadedTweets.Name = "tabPageLoadedTweets";
            this.tabPageLoadedTweets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoadedTweets.Size = new System.Drawing.Size(1000, 389);
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
            this.dataGridViewMain.Size = new System.Drawing.Size(994, 383);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // tabStads
            // 
            this.tabStads.Location = new System.Drawing.Point(4, 22);
            this.tabStads.Name = "tabStads";
            this.tabStads.Padding = new System.Windows.Forms.Padding(3);
            this.tabStads.Size = new System.Drawing.Size(1000, 389);
            this.tabStads.TabIndex = 1;
            this.tabStads.Text = "Stadistics";
            this.tabStads.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loadTweetsToolStripMenuItem});
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // loadTweetsToolStripMenuItem
            // 
            this.loadTweetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromjsToolStripMenuItem,
            this.fromzipToolStripMenuItem,
            this.fromAPIToolStripMenuItem,
            this.fromPreviousLoadsToolStripMenuItem});
            this.loadTweetsToolStripMenuItem.Name = "loadTweetsToolStripMenuItem";
            this.loadTweetsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadTweetsToolStripMenuItem.Text = "Load tweets";
            // 
            // fromjsToolStripMenuItem
            // 
            this.fromjsToolStripMenuItem.Name = "fromjsToolStripMenuItem";
            this.fromjsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromjsToolStripMenuItem.Text = "From .js";
            this.fromjsToolStripMenuItem.Click += new System.EventHandler(this.fromjsToolStripMenuItem_Click);
            // 
            // fromzipToolStripMenuItem
            // 
            this.fromzipToolStripMenuItem.Name = "fromzipToolStripMenuItem";
            this.fromzipToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromzipToolStripMenuItem.Text = "From .zip";
            this.fromzipToolStripMenuItem.Click += new System.EventHandler(this.fromzipToolStripMenuItem_Click);
            // 
            // fromAPIToolStripMenuItem
            // 
            this.fromAPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.loadAPIToolStripMenuItem});
            this.fromAPIToolStripMenuItem.Name = "fromAPIToolStripMenuItem";
            this.fromAPIToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromAPIToolStripMenuItem.Text = "API";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // loadAPIToolStripMenuItem
            // 
            this.loadAPIToolStripMenuItem.Name = "loadAPIToolStripMenuItem";
            this.loadAPIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadAPIToolStripMenuItem.Text = "Load API";
            this.loadAPIToolStripMenuItem.Click += new System.EventHandler(this.loadAPIToolStripMenuItem_Click);
            // 
            // fromPreviousLoadsToolStripMenuItem
            // 
            this.fromPreviousLoadsToolStripMenuItem.Name = "fromPreviousLoadsToolStripMenuItem";
            this.fromPreviousLoadsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.fromPreviousLoadsToolStripMenuItem.Text = "From previous loads";
            this.fromPreviousLoadsToolStripMenuItem.Click += new System.EventHandler(this.fromPreviousLoadsToolStripMenuItem_Click);
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
            this.bindingSrcTweets.CurrentChanged += new System.EventHandler(this.bindingSrcTweets_CurrentChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageLoadedTweets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSrcTweets)).EndInit();
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
        private System.Windows.Forms.TabPage tabStads;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTweetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromjsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadAPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromPreviousLoadsToolStripMenuItem;
    }
}

