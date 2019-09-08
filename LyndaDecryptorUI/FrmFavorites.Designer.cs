namespace LyndaDecryptorUI
{
	partial class FrmFavorites
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
						this.LstLocation = new System.Windows.Forms.ListBox();
						this.GroupBox1 = new System.Windows.Forms.GroupBox();
						this.CmdAdd = new System.Windows.Forms.Button();
						this.CmdRemove = new System.Windows.Forms.Button();
						this.CmdMoveDown = new System.Windows.Forms.Button();
						this.CmdMoveUp = new System.Windows.Forms.Button();
						this.CmdOk = new System.Windows.Forms.Button();
						this.CmdCancel = new System.Windows.Forms.Button();
						this.GroupBox1.SuspendLayout();
						this.SuspendLayout();
						// 
						// LstLocation
						// 
						this.LstLocation.FormattingEnabled = true;
						this.LstLocation.HorizontalScrollbar = true;
						this.LstLocation.ItemHeight = 15;
						this.LstLocation.Location = new System.Drawing.Point(7, 24);
						this.LstLocation.Name = "LstLocation";
						this.LstLocation.Size = new System.Drawing.Size(559, 124);
						this.LstLocation.TabIndex = 1;
						// 
						// GroupBox1
						// 
						this.GroupBox1.Controls.Add(this.CmdAdd);
						this.GroupBox1.Controls.Add(this.CmdRemove);
						this.GroupBox1.Controls.Add(this.CmdMoveDown);
						this.GroupBox1.Controls.Add(this.CmdMoveUp);
						this.GroupBox1.Controls.Add(this.LstLocation);
						this.GroupBox1.Location = new System.Drawing.Point(14, 14);
						this.GroupBox1.Name = "GroupBox1";
						this.GroupBox1.Size = new System.Drawing.Size(618, 169);
						this.GroupBox1.TabIndex = 2;
						this.GroupBox1.TabStop = false;
						this.GroupBox1.Text = "******";
						// 
						// CmdAdd
						// 
						this.CmdAdd.Image = global::LyndaDecryptorUI.Properties.Resources.Plus_16x;
						this.CmdAdd.Location = new System.Drawing.Point(570, 25);
						this.CmdAdd.Name = "CmdAdd";
						this.CmdAdd.Size = new System.Drawing.Size(39, 26);
						this.CmdAdd.TabIndex = 5;
						this.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
						this.CmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.CmdAdd.UseVisualStyleBackColor = true;
						this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
						// 
						// CmdRemove
						// 
						this.CmdRemove.Image = global::LyndaDecryptorUI.Properties.Resources.Remove_16x;
						this.CmdRemove.Location = new System.Drawing.Point(570, 58);
						this.CmdRemove.Name = "CmdRemove";
						this.CmdRemove.Size = new System.Drawing.Size(39, 26);
						this.CmdRemove.TabIndex = 4;
						this.CmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
						this.CmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.CmdRemove.UseVisualStyleBackColor = true;
						this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
						// 
						// CmdMoveDown
						// 
						this.CmdMoveDown.Image = global::LyndaDecryptorUI.Properties.Resources.Download_16x;
						this.CmdMoveDown.Location = new System.Drawing.Point(570, 122);
						this.CmdMoveDown.Name = "CmdMoveDown";
						this.CmdMoveDown.Size = new System.Drawing.Size(39, 26);
						this.CmdMoveDown.TabIndex = 3;
						this.CmdMoveDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
						this.CmdMoveDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.CmdMoveDown.UseMnemonic = false;
						this.CmdMoveDown.UseVisualStyleBackColor = true;
						this.CmdMoveDown.Click += new System.EventHandler(this.CmdMoveDown_Click);
						// 
						// CmdMoveUp
						// 
						this.CmdMoveUp.Image = global::LyndaDecryptorUI.Properties.Resources.Upload_16x;
						this.CmdMoveUp.Location = new System.Drawing.Point(570, 90);
						this.CmdMoveUp.Name = "CmdMoveUp";
						this.CmdMoveUp.Size = new System.Drawing.Size(39, 27);
						this.CmdMoveUp.TabIndex = 2;
						this.CmdMoveUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
						this.CmdMoveUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
						this.CmdMoveUp.UseVisualStyleBackColor = true;
						this.CmdMoveUp.Click += new System.EventHandler(this.CmdMoveUp_Click);
						// 
						// CmdOk
						// 
						this.CmdOk.Location = new System.Drawing.Point(351, 195);
						this.CmdOk.Name = "CmdOk";
						this.CmdOk.Size = new System.Drawing.Size(134, 32);
						this.CmdOk.TabIndex = 3;
						this.CmdOk.Text = "OK";
						this.CmdOk.UseVisualStyleBackColor = true;
						this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
						// 
						// CmdCancel
						// 
						this.CmdCancel.Location = new System.Drawing.Point(491, 195);
						this.CmdCancel.Name = "CmdCancel";
						this.CmdCancel.Size = new System.Drawing.Size(134, 32);
						this.CmdCancel.TabIndex = 4;
						this.CmdCancel.Text = "Cancel";
						this.CmdCancel.UseVisualStyleBackColor = true;
						this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
						// 
						// FrmFavorites
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(645, 239);
						this.Controls.Add(this.CmdCancel);
						this.Controls.Add(this.CmdOk);
						this.Controls.Add(this.GroupBox1);
						this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
						this.Name = "FrmFavorites";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Manage Favorites";
						this.GroupBox1.ResumeLayout(false);
						this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LstLocation;
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.Button CmdRemove;
		private System.Windows.Forms.Button CmdMoveDown;
		private System.Windows.Forms.Button CmdMoveUp;
		private System.Windows.Forms.Button CmdAdd;
		private System.Windows.Forms.Button CmdOk;
		private System.Windows.Forms.Button CmdCancel;
	}
}