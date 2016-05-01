namespace GestTweet
{
    partial class PreviousLoadsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfExportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfTweetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeExportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfExportDataGridViewTextBoxColumn,
            this.directoryNameDataGridViewTextBoxColumn,
            this.numOfTweetsDataGridViewTextBoxColumn,
            this.typeExportDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 474);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GestTweet.Classes.SavedExports.GestTweetExport);
            // 
            // dateOfExportDataGridViewTextBoxColumn
            // 
            this.dateOfExportDataGridViewTextBoxColumn.DataPropertyName = "dateOfExport";
            this.dateOfExportDataGridViewTextBoxColumn.HeaderText = "dateOfExport";
            this.dateOfExportDataGridViewTextBoxColumn.Name = "dateOfExportDataGridViewTextBoxColumn";
            this.dateOfExportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directoryNameDataGridViewTextBoxColumn
            // 
            this.directoryNameDataGridViewTextBoxColumn.DataPropertyName = "DirectoryName";
            this.directoryNameDataGridViewTextBoxColumn.HeaderText = "DirectoryName";
            this.directoryNameDataGridViewTextBoxColumn.Name = "directoryNameDataGridViewTextBoxColumn";
            this.directoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfTweetsDataGridViewTextBoxColumn
            // 
            this.numOfTweetsDataGridViewTextBoxColumn.DataPropertyName = "NumOfTweets";
            this.numOfTweetsDataGridViewTextBoxColumn.HeaderText = "NumOfTweets";
            this.numOfTweetsDataGridViewTextBoxColumn.Name = "numOfTweetsDataGridViewTextBoxColumn";
            this.numOfTweetsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeExportDataGridViewTextBoxColumn
            // 
            this.typeExportDataGridViewTextBoxColumn.DataPropertyName = "typeExport";
            this.typeExportDataGridViewTextBoxColumn.HeaderText = "typeExport";
            this.typeExportDataGridViewTextBoxColumn.Name = "typeExportDataGridViewTextBoxColumn";
            this.typeExportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PreviousLoadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviousLoadsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PreviousLoadsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfExportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfTweetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeExportDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}