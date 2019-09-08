namespace LyndaDecryptorUI
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
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
						this.ComboInputPath = new System.Windows.Forms.ComboBox();
						this.label2 = new System.Windows.Forms.Label();
						this.ComboOutputPath = new System.Windows.Forms.ComboBox();
						this.label3 = new System.Windows.Forms.Label();
						this.ComboDbFile = new System.Windows.Forms.ComboBox();
						this.label4 = new System.Windows.Forms.Label();
						this.CmdStartDecryption = new System.Windows.Forms.Button();
						this.CmdExit = new System.Windows.Forms.Button();
						this.TxtOutput = new System.Windows.Forms.RichTextBox();
						this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
						this.RadioFile = new System.Windows.Forms.RadioButton();
						this.RadioFolder = new System.Windows.Forms.RadioButton();
						this.CmdAbout = new System.Windows.Forms.Button();
						this.CmdInputFavorites = new System.Windows.Forms.Button();
						this.CmdBrowseDB = new System.Windows.Forms.Button();
						this.CmdBrowseOutput = new System.Windows.Forms.Button();
						this.CmdBrowseInput = new System.Windows.Forms.Button();
						this.CmdOutputFavorites = new System.Windows.Forms.Button();
						this.CmdDatabaseFavorites = new System.Windows.Forms.Button();
						this.ChkSubtitle = new System.Windows.Forms.CheckBox();
						this.ChkUseDatabase = new System.Windows.Forms.CheckBox();
						this.lblPercent = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// ComboInputPath
						// 
						this.ComboInputPath.FormattingEnabled = true;
						this.ComboInputPath.Location = new System.Drawing.Point(104, 56);
						this.ComboInputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.ComboInputPath.Name = "ComboInputPath";
						this.ComboInputPath.Size = new System.Drawing.Size(508, 23);
						this.ComboInputPath.TabIndex = 3;
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(14, 60);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(65, 15);
						this.label2.TabIndex = 2;
						this.label2.Text = "Input Path:";
						// 
						// ComboOutputPath
						// 
						this.ComboOutputPath.FormattingEnabled = true;
						this.ComboOutputPath.Location = new System.Drawing.Point(104, 98);
						this.ComboOutputPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.ComboOutputPath.Name = "ComboOutputPath";
						this.ComboOutputPath.Size = new System.Drawing.Size(508, 23);
						this.ComboOutputPath.TabIndex = 5;
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(14, 101);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(74, 15);
						this.label3.TabIndex = 4;
						this.label3.Text = "Output Path:";
						// 
						// ComboDbFile
						// 
						this.ComboDbFile.FormattingEnabled = true;
						this.ComboDbFile.Location = new System.Drawing.Point(104, 141);
						this.ComboDbFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.ComboDbFile.Name = "ComboDbFile";
						this.ComboDbFile.Size = new System.Drawing.Size(508, 23);
						this.ComboDbFile.TabIndex = 7;
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(14, 145);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(86, 15);
						this.label4.TabIndex = 6;
						this.label4.Text = "Database File:";
						// 
						// CmdStartDecryption
						// 
						this.CmdStartDecryption.Location = new System.Drawing.Point(414, 373);
						this.CmdStartDecryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdStartDecryption.Name = "CmdStartDecryption";
						this.CmdStartDecryption.Size = new System.Drawing.Size(140, 34);
						this.CmdStartDecryption.TabIndex = 12;
						this.CmdStartDecryption.Text = "Start Decryption";
						this.CmdStartDecryption.UseVisualStyleBackColor = true;
						this.CmdStartDecryption.Click += new System.EventHandler(this.CmdStartDecryption_Click);
						// 
						// CmdExit
						// 
						this.CmdExit.Location = new System.Drawing.Point(561, 373);
						this.CmdExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdExit.Name = "CmdExit";
						this.CmdExit.Size = new System.Drawing.Size(140, 34);
						this.CmdExit.TabIndex = 13;
						this.CmdExit.Text = "Exit";
						this.CmdExit.UseVisualStyleBackColor = true;
						this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
						// 
						// TxtOutput
						// 
						this.TxtOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
						this.TxtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
						this.TxtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.TxtOutput.ForeColor = System.Drawing.Color.Blue;
						this.TxtOutput.Location = new System.Drawing.Point(19, 234);
						this.TxtOutput.Margin = new System.Windows.Forms.Padding(4);
						this.TxtOutput.Name = "TxtOutput";
						this.TxtOutput.ReadOnly = true;
						this.TxtOutput.Size = new System.Drawing.Size(682, 118);
						this.TxtOutput.TabIndex = 14;
						this.TxtOutput.Text = "";
						this.TxtOutput.WordWrap = false;
						// 
						// ProgressBar1
						// 
						this.ProgressBar1.BackColor = System.Drawing.SystemColors.Control;
						this.ProgressBar1.Location = new System.Drawing.Point(19, 194);
						this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
						this.ProgressBar1.Name = "ProgressBar1";
						this.ProgressBar1.Size = new System.Drawing.Size(682, 32);
						this.ProgressBar1.TabIndex = 15;
						// 
						// RadioFile
						// 
						this.RadioFile.Image = global::LyndaDecryptorUI.Properties.Resources.File_16x;
						this.RadioFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.RadioFile.Location = new System.Drawing.Point(261, 16);
						this.RadioFile.Name = "RadioFile";
						this.RadioFile.Size = new System.Drawing.Size(96, 22);
						this.RadioFile.TabIndex = 18;
						this.RadioFile.TabStop = true;
						this.RadioFile.Text = "File Mode";
						this.RadioFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.RadioFile.UseVisualStyleBackColor = true;
						// 
						// RadioFolder
						// 
						this.RadioFolder.Checked = true;
						this.RadioFolder.Image = global::LyndaDecryptorUI.Properties.Resources.Folder_16x;
						this.RadioFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
						this.RadioFolder.Location = new System.Drawing.Point(126, 16);
						this.RadioFolder.Name = "RadioFolder";
						this.RadioFolder.Size = new System.Drawing.Size(115, 19);
						this.RadioFolder.TabIndex = 18;
						this.RadioFolder.TabStop = true;
						this.RadioFolder.Text = "Folder Mode";
						this.RadioFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.RadioFolder.UseVisualStyleBackColor = true;
						// 
						// CmdAbout
						// 
						this.CmdAbout.Image = global::LyndaDecryptorUI.Properties.Resources.StatusInformation_exp_16x;
						this.CmdAbout.Location = new System.Drawing.Point(19, 11);
						this.CmdAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdAbout.Name = "CmdAbout";
						this.CmdAbout.Size = new System.Drawing.Size(35, 28);
						this.CmdAbout.TabIndex = 17;
						this.CmdAbout.UseVisualStyleBackColor = true;
						this.CmdAbout.Click += new System.EventHandler(this.CmdAbout_Click);
						// 
						// CmdInputFavorites
						// 
						this.CmdInputFavorites.Image = global::LyndaDecryptorUI.Properties.Resources.Favorite_16x;
						this.CmdInputFavorites.Location = new System.Drawing.Point(663, 53);
						this.CmdInputFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdInputFavorites.Name = "CmdInputFavorites";
						this.CmdInputFavorites.Size = new System.Drawing.Size(39, 28);
						this.CmdInputFavorites.TabIndex = 16;
						this.CmdInputFavorites.UseVisualStyleBackColor = true;
						this.CmdInputFavorites.Click += new System.EventHandler(this.CmdInputFavorites_Click);
						// 
						// CmdBrowseDB
						// 
						this.CmdBrowseDB.Image = global::LyndaDecryptorUI.Properties.Resources.AddFile_16x;
						this.CmdBrowseDB.Location = new System.Drawing.Point(618, 138);
						this.CmdBrowseDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdBrowseDB.Name = "CmdBrowseDB";
						this.CmdBrowseDB.Size = new System.Drawing.Size(39, 28);
						this.CmdBrowseDB.TabIndex = 11;
						this.CmdBrowseDB.UseVisualStyleBackColor = true;
						this.CmdBrowseDB.Click += new System.EventHandler(this.CmdBrowseDB_Click);
						// 
						// CmdBrowseOutput
						// 
						this.CmdBrowseOutput.Image = global::LyndaDecryptorUI.Properties.Resources.AddFolder_16x;
						this.CmdBrowseOutput.Location = new System.Drawing.Point(618, 95);
						this.CmdBrowseOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdBrowseOutput.Name = "CmdBrowseOutput";
						this.CmdBrowseOutput.Size = new System.Drawing.Size(39, 28);
						this.CmdBrowseOutput.TabIndex = 10;
						this.CmdBrowseOutput.UseVisualStyleBackColor = true;
						this.CmdBrowseOutput.Click += new System.EventHandler(this.CmdBrowseOutput_Click);
						// 
						// CmdBrowseInput
						// 
						this.CmdBrowseInput.Image = global::LyndaDecryptorUI.Properties.Resources.AddFolder_16x;
						this.CmdBrowseInput.Location = new System.Drawing.Point(618, 53);
						this.CmdBrowseInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdBrowseInput.Name = "CmdBrowseInput";
						this.CmdBrowseInput.Size = new System.Drawing.Size(39, 28);
						this.CmdBrowseInput.TabIndex = 9;
						this.CmdBrowseInput.UseVisualStyleBackColor = true;
						this.CmdBrowseInput.Click += new System.EventHandler(this.CmdBrowseInput_Click);
						// 
						// CmdOutputFavorites
						// 
						this.CmdOutputFavorites.Image = global::LyndaDecryptorUI.Properties.Resources.Favorite_16x;
						this.CmdOutputFavorites.Location = new System.Drawing.Point(663, 95);
						this.CmdOutputFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdOutputFavorites.Name = "CmdOutputFavorites";
						this.CmdOutputFavorites.Size = new System.Drawing.Size(39, 28);
						this.CmdOutputFavorites.TabIndex = 19;
						this.CmdOutputFavorites.UseVisualStyleBackColor = true;
						this.CmdOutputFavorites.Click += new System.EventHandler(this.CmdOutputFavorites_Click);
						// 
						// CmdDatabaseFavorites
						// 
						this.CmdDatabaseFavorites.Image = global::LyndaDecryptorUI.Properties.Resources.Favorite_16x;
						this.CmdDatabaseFavorites.Location = new System.Drawing.Point(663, 138);
						this.CmdDatabaseFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.CmdDatabaseFavorites.Name = "CmdDatabaseFavorites";
						this.CmdDatabaseFavorites.Size = new System.Drawing.Size(39, 28);
						this.CmdDatabaseFavorites.TabIndex = 20;
						this.CmdDatabaseFavorites.UseVisualStyleBackColor = true;
						this.CmdDatabaseFavorites.Click += new System.EventHandler(this.CmdDatabaseFavorites_Click);
						// 
						// ChkSubtitle
						// 
						this.ChkSubtitle.AutoSize = true;
						this.ChkSubtitle.Checked = true;
						this.ChkSubtitle.CheckState = System.Windows.Forms.CheckState.Checked;
						this.ChkSubtitle.Location = new System.Drawing.Point(515, 19);
						this.ChkSubtitle.Name = "ChkSubtitle";
						this.ChkSubtitle.Size = new System.Drawing.Size(67, 19);
						this.ChkSubtitle.TabIndex = 21;
						this.ChkSubtitle.Text = "Subtitle";
						this.ChkSubtitle.UseVisualStyleBackColor = true;
						// 
						// ChkUseDatabase
						// 
						this.ChkUseDatabase.AutoSize = true;
						this.ChkUseDatabase.Checked = true;
						this.ChkUseDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
						this.ChkUseDatabase.Location = new System.Drawing.Point(389, 19);
						this.ChkUseDatabase.Name = "ChkUseDatabase";
						this.ChkUseDatabase.Size = new System.Drawing.Size(104, 19);
						this.ChkUseDatabase.TabIndex = 22;
						this.ChkUseDatabase.Text = "Use Database";
						this.ChkUseDatabase.UseVisualStyleBackColor = true;
						// 
						// lblPercent
						// 
						this.lblPercent.AutoSize = true;
						this.lblPercent.BackColor = System.Drawing.Color.Transparent;
						this.lblPercent.ForeColor = System.Drawing.Color.DeepPink;
						this.lblPercent.Location = new System.Drawing.Point(348, 203);
						this.lblPercent.Name = "lblPercent";
						this.lblPercent.Size = new System.Drawing.Size(25, 15);
						this.lblPercent.TabIndex = 23;
						this.lblPercent.Text = "0%";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.SystemColors.Control;
						this.ClientSize = new System.Drawing.Size(714, 419);
						this.Controls.Add(this.lblPercent);
						this.Controls.Add(this.ChkUseDatabase);
						this.Controls.Add(this.ChkSubtitle);
						this.Controls.Add(this.CmdDatabaseFavorites);
						this.Controls.Add(this.CmdOutputFavorites);
						this.Controls.Add(this.RadioFile);
						this.Controls.Add(this.RadioFolder);
						this.Controls.Add(this.CmdAbout);
						this.Controls.Add(this.CmdInputFavorites);
						this.Controls.Add(this.ProgressBar1);
						this.Controls.Add(this.TxtOutput);
						this.Controls.Add(this.ComboDbFile);
						this.Controls.Add(this.CmdExit);
						this.Controls.Add(this.CmdStartDecryption);
						this.Controls.Add(this.CmdBrowseDB);
						this.Controls.Add(this.CmdBrowseOutput);
						this.Controls.Add(this.CmdBrowseInput);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.ComboOutputPath);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.ComboInputPath);
						this.Controls.Add(this.label2);
						this.Cursor = System.Windows.Forms.Cursors.Default;
						this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
						this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
						this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
						this.MaximizeBox = false;
						this.Name = "Form1";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Lynda Decryptor UI";
						this.ResumeLayout(false);
						this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboInputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboOutputPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboDbFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CmdBrowseInput;
        private System.Windows.Forms.Button CmdBrowseOutput;
        private System.Windows.Forms.Button CmdBrowseDB;
        private System.Windows.Forms.Button CmdStartDecryption;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.RichTextBox TxtOutput;
        private System.Windows.Forms.ProgressBar ProgressBar1;
				private System.Windows.Forms.Button CmdInputFavorites;
				private System.Windows.Forms.Button CmdOutputFavorites;
				private System.Windows.Forms.Button CmdDatabaseFavorites;
				private System.Windows.Forms.Button CmdAbout;
				private System.Windows.Forms.RadioButton RadioFolder;
				private System.Windows.Forms.RadioButton RadioFile;
				private System.Windows.Forms.CheckBox ChkSubtitle;
				private System.Windows.Forms.CheckBox ChkUseDatabase;
				private System.Windows.Forms.Label lblPercent;
		}
}