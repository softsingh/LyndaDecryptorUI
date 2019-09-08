using System;
using System.IO;
using System.Windows.Forms;

using LyndaDecryptorUI.Properties;
using static LyndaDecryptorUI.Utils;

namespace LyndaDecryptorUI
{
		public partial class FrmFavorites : Form
		{
				FavoriteType FavType;

				public FrmFavorites(FavoriteType ft)
				{
						InitializeComponent();
						FavType = ft;

						int count, i;

						switch (FavType) 
						{
								case FavoriteType.Input:

										this.GroupBox1.Text = "Input Favorites";
										count = Settings.Default.InputLocation.Count;

										for (i = 0; i < count; i++)
												LstLocation.Items.Add(Settings.Default.InputLocation[i]);

										break;

								case FavoriteType.Output:

										this.GroupBox1.Text = "Output Favorites";
										count = Settings.Default.OutputLocation.Count;

										for (i = 0; i < count; i++)
												LstLocation.Items.Add(Settings.Default.OutputLocation[i]);

										break;

								case FavoriteType.Database:

										this.GroupBox1.Text = "Database Favorites";
										count = Settings.Default.DatabaseFile.Count;

										for (i = 0; i < count; i++)
												LstLocation.Items.Add(Settings.Default.DatabaseFile[i]);

										break;

								default:

										MessageBox.Show("Invalid Favorite Location Type");
										this.Close();
										break;
						}
						
				}

				private void CmdAdd_Click(object sender, EventArgs e)
				{
						int i, count;
						count = LstLocation.Items.Count;

						string DefaultFolder;
						FolderBrowserDialog FolderDlg;
						DialogResult result;

						switch (FavType)
						{
								case FavoriteType.Input:

										if (Settings.Default.InputLocation.Count > 0 && 
												Directory.Exists(Settings.Default.InputLocation[0]))
												DefaultFolder = Settings.Default.InputLocation[0];
										else
												DefaultFolder = DEFAULT_INPUT_FOLDER;

										FolderDlg = new FolderBrowserDialog
										{
												ShowNewFolderButton = false,
												Description = "Select Input Folder",
												SelectedPath = DefaultFolder
										};

										// Show the FolderBrowserDialog.  
										result = FolderDlg.ShowDialog();

										if (result == DialogResult.OK)
										{
												for (i = 0; i < count; i++)
												{
														if (LstLocation.Items[i].ToString() == FolderDlg.SelectedPath)
														{
																LstLocation.Items.RemoveAt(i);
																break;
														}
												}

												LstLocation.Items.Insert(0, FolderDlg.SelectedPath);

												if (LstLocation.Items.Count > NUM_FAVOURITES)
												{
														count = LstLocation.Items.Count - NUM_FAVOURITES;

														for (i = 0; i < count; i++)
																LstLocation.Items.RemoveAt(LstLocation.Items.Count - 1);
												}

												LstLocation.SelectedIndex = 0;
										}

										break;

								case FavoriteType.Output:

										if (Settings.Default.OutputLocation.Count > 0 && 
												Directory.Exists(Settings.Default.OutputLocation[0]))
												DefaultFolder = Settings.Default.OutputLocation[0];
										else
												DefaultFolder = DEFAULT_OUTPUT_FOLDER;

										FolderDlg = new FolderBrowserDialog
										{
												ShowNewFolderButton = false,
												Description = "Select Output Folder",
												SelectedPath = DefaultFolder
										};

										// Show the FolderBrowserDialog.  
										result = FolderDlg.ShowDialog();

										if (result == DialogResult.OK)
										{
												for (i = 0; i < count; i++)
												{
														if (LstLocation.Items[i].ToString() == FolderDlg.SelectedPath)
														{
																LstLocation.Items.RemoveAt(i);
																break;
														}
												}

												LstLocation.Items.Insert(0, FolderDlg.SelectedPath);

												if (LstLocation.Items.Count > NUM_FAVOURITES)
												{
														count = LstLocation.Items.Count - NUM_FAVOURITES;

														for (i = 0; i < count; i++)
																LstLocation.Items.RemoveAt(LstLocation.Items.Count - 1);
												}

												LstLocation.SelectedIndex = 0;
										}

										break;

								case FavoriteType.Database:

										if (Settings.Default.DatabaseFile.Count > 0 && 
												Directory.Exists(Settings.Default.DatabaseFile[0]))
												DefaultFolder = Settings.Default.DatabaseFile[0];
										else
												DefaultFolder = DEFAULT_DATABASE_FOLDER;

										OpenFileDialog FileDlg = new OpenFileDialog
										{
												InitialDirectory = DefaultFolder,
												Title = "Browse Database File",

												CheckFileExists = true,
												CheckPathExists = true,

												DefaultExt = "sqlite",
												Filter = "database files (*.sqlite)|*.sqlite",
												RestoreDirectory = true,

												ReadOnlyChecked = true,
												ShowReadOnly = true
										};

										// Show the FolderBrowserDialog.  
										result = FileDlg.ShowDialog();

										if (result == DialogResult.OK)
										{
												for (i = 0; i < count; i++)
												{
														if (LstLocation.Items[i].ToString() == FileDlg.FileName)
														{
																LstLocation.Items.RemoveAt(i);
																break;
														}
												}

												LstLocation.Items.Insert(0, FileDlg.FileName);

												if (LstLocation.Items.Count > NUM_FAVOURITES)
												{
														count = LstLocation.Items.Count - NUM_FAVOURITES;

														for (i = 0; i < count; i++)
																LstLocation.Items.RemoveAt(LstLocation.Items.Count - 1);
												}

												LstLocation.SelectedIndex = 0;
										}

										break;
						}
						
				}

				private void CmdRemove_Click(object sender, EventArgs e)
				{
						int SelectedIndex = LstLocation.SelectedIndex;

						if (SelectedIndex != -1)
						{
								LstLocation.Items.RemoveAt(SelectedIndex);
						}
				}

				private void CmdMoveDown_Click(object sender, EventArgs e)
				{
						int SelectedIndex = LstLocation.SelectedIndex;

						if (SelectedIndex < LstLocation.Items.Count - 1 & SelectedIndex != -1)
						{
								LstLocation.Items.Insert(SelectedIndex + 2, LstLocation.Items[SelectedIndex]);
								LstLocation.Items.RemoveAt(SelectedIndex);
								LstLocation.SelectedIndex = SelectedIndex + 1;
						}
				}

				private void CmdMoveUp_Click(object sender, EventArgs e)
				{
						int SelectedIndex = LstLocation.SelectedIndex;

						if (SelectedIndex > 0)
						{
								LstLocation.Items.Insert(SelectedIndex - 1, LstLocation.Items[SelectedIndex]);
								LstLocation.Items.RemoveAt(SelectedIndex + 1);
								LstLocation.SelectedIndex = SelectedIndex - 1;
						}
				}

				private void CmdOk_Click(object sender, EventArgs e)
				{
						int count, i;
						count = LstLocation.Items.Count;

						switch (FavType)
						{
								case FavoriteType.Input:

										Settings.Default.InputLocation.Clear();

										for (i = 0; i < count; i++)
												Settings.Default.InputLocation.Add(LstLocation.Items[i].ToString());

										break;

								case FavoriteType.Output:

										Settings.Default.OutputLocation.Clear();

										for (i = 0; i < count; i++)
												Settings.Default.OutputLocation.Add(LstLocation.Items[i].ToString());

										break;

								case FavoriteType.Database:

										Settings.Default.DatabaseFile.Clear();

										for (i = 0; i < count; i++)
												Settings.Default.DatabaseFile.Add(LstLocation.Items[i].ToString());

										break;
						}
						
						Settings.Default.Save();
						this.Close();
				}

				private void CmdCancel_Click(object sender, EventArgs e)
				{
						this.Close();
				}
		}
}
