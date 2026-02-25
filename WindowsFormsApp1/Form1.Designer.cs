namespace WindowsFormsApp1 // DİKKAT: BURAYA KENDİ PROJE ADINI YAZMAYI UNUTMA!
{
    partial class Form1
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
            this.cmbFileType = new System.Windows.Forms.ComboBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.prgProcess = new System.Windows.Forms.ProgressBar();
            this.lblDistinctWords = new System.Windows.Forms.Label();
            this.lblPunctuations = new System.Windows.Forms.Label();
            this.dgvFrequencies = new System.Windows.Forms.DataGridView();
            this.WordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.ofdFileSelector = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFileType
            // 
            this.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileType.FormattingEnabled = true;
            this.cmbFileType.Items.AddRange(new object[] {
            ".txt",
            ".docx"});
            this.cmbFileType.Location = new System.Drawing.Point(23, 21);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Size = new System.Drawing.Size(137, 24);
            this.cmbFileType.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Enabled = false;
            this.btnLoadFile.Location = new System.Drawing.Point(183, 20);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(114, 27);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // prgProcess
            // 
            this.prgProcess.Location = new System.Drawing.Point(23, 64);
            this.prgProcess.Name = "prgProcess";
            this.prgProcess.Size = new System.Drawing.Size(846, 21);
            this.prgProcess.TabIndex = 2;
            // 
            // lblDistinctWords
            // 
            this.lblDistinctWords.AutoSize = true;
            this.lblDistinctWords.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDistinctWords.Location = new System.Drawing.Point(23, 107);
            this.lblDistinctWords.Name = "lblDistinctWords";
            this.lblDistinctWords.Size = new System.Drawing.Size(193, 23);
            this.lblDistinctWords.TabIndex = 3;
            this.lblDistinctWords.Text = "Total Distinct Words: 0";
            // 
            // lblPunctuations
            // 
            this.lblPunctuations.AutoSize = true;
            this.lblPunctuations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPunctuations.Location = new System.Drawing.Point(229, 107);
            this.lblPunctuations.Name = "lblPunctuations";
            this.lblPunctuations.Size = new System.Drawing.Size(177, 23);
            this.lblPunctuations.TabIndex = 4;
            this.lblPunctuations.Text = "Total Punctuations: 0";
            // 
            // dgvFrequencies
            // 
            this.dgvFrequencies.AllowUserToAddRows = false;
            this.dgvFrequencies.AllowUserToDeleteRows = false;
            this.dgvFrequencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordColumn,
            this.CountColumn});
            this.dgvFrequencies.Location = new System.Drawing.Point(23, 139);
            this.dgvFrequencies.Name = "dgvFrequencies";
            this.dgvFrequencies.ReadOnly = true;
            this.dgvFrequencies.RowHeadersVisible = false;
            this.dgvFrequencies.RowHeadersWidth = 51;
            this.dgvFrequencies.RowTemplate.Height = 25;
            this.dgvFrequencies.Size = new System.Drawing.Size(400, 320);
            this.dgvFrequencies.TabIndex = 5;
            // 
            // WordColumn
            // 
            this.WordColumn.HeaderText = "Word";
            this.WordColumn.MinimumWidth = 6;
            this.WordColumn.Name = "WordColumn";
            this.WordColumn.ReadOnly = true;
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Count";
            this.CountColumn.MinimumWidth = 6;
            this.CountColumn.Name = "CountColumn";
            this.CountColumn.ReadOnly = true;
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.ItemHeight = 16;
            this.lstLogs.Location = new System.Drawing.Point(457, 139);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(411, 324);
            this.lstLogs.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 488);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.dgvFrequencies);
            this.Controls.Add(this.lblPunctuations);
            this.Controls.Add(this.lblDistinctWords);
            this.Controls.Add(this.prgProcess);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.cmbFileType);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Content Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFileType;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ProgressBar prgProcess;
        private System.Windows.Forms.Label lblDistinctWords;
        private System.Windows.Forms.Label lblPunctuations;
        private System.Windows.Forms.DataGridView dgvFrequencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.OpenFileDialog ofdFileSelector;
    }
}