using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using static LyndaDecryptorUI.Utils;
using LyndaDecryptorUI.Properties;
using System.Threading;

namespace LyndaDecryptorUI
{
    public enum Mode
    {
        None = 0,
        File,
        Folder
    };

    public enum FavoriteType
    {
        All,
        Input,
        Output,
        Database
    };

    public struct Msg
    {
        public string Text;
        public Color TextColor;
    };

    public partial class Form1 : Form
    {
                
        CancellationTokenSource cts;
        CancellationToken ct;

        public Form1()
        {
            InitializeComponent();

            if (Settings.Default.FolderMode == true)
                RadioFolder.Checked = true;
            else
                RadioFile.Checked = true;

            if (Settings.Default.UseDatabase == true)
                ChkUseDatabase.Checked = true;
            else
                ChkUseDatabase.Checked = false;

            if (Settings.Default.Subtitle == true)
                ChkSubtitle.Checked = true;
            else
                ChkSubtitle.Checked = false;

            UpdateComboBox(FavoriteType.All);
        }

        private bool CheckInput()
        {
            if(RadioFolder.Checked == true)
            {
                if (!Directory.Exists(ComboInputPath.Text))
                {
                    MessageBox.Show("Invalid Input Folder", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }

                if (!Directory.Exists(ComboOutputPath.Text))
                {
                    MessageBox.Show("Invalid Output Folder", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                if (!File.Exists(ComboInputPath.Text))
                {
                    MessageBox.Show("Invalid Input File", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            
            if (ChkUseDatabase.Checked == true && !File.Exists(ComboDbFile.Text))
            {
                MessageBox.Show("Invalid Database File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void UpdateComboBox(FavoriteType FavType, bool ClearText = true)
        {
            int count, i;

            if(FavType == FavoriteType.All || FavType == FavoriteType.Input)
            {
                if(ClearText ==true)
                    ComboInputPath.Text = "";

                ComboInputPath.Items.Clear();
                count = Settings.Default.InputLocation.Count;

                for (i = 0; i < count; i++)
                    ComboInputPath.Items.Add(Settings.Default.InputLocation[i]);
            }

            if (FavType == FavoriteType.All || FavType == FavoriteType.Output)
            {
                if (ClearText == true)
                    ComboOutputPath.Text = "";

                ComboOutputPath.Items.Clear();
                count = Settings.Default.OutputLocation.Count;

                for (i = 0; i < count; i++)
                    ComboOutputPath.Items.Add(Settings.Default.OutputLocation[i]);
            }

            if (FavType == FavoriteType.All || FavType == FavoriteType.Database)
            {
                if (ClearText == true)
                    ComboDbFile.Text = "";

                ComboDbFile.Items.Clear();
                count = Settings.Default.DatabaseFile.Count;

                for (i = 0; i < count; i++)
                    ComboDbFile.Items.Add(Settings.Default.DatabaseFile[i]);
            }
        }

        private async void CmdStartDecryption_Click(object sender, EventArgs e)
        {
            if (CheckInput() == false)
                return;

            var ProgressPercent = new Progress<int>(Percent =>
            {
                ProgressBar1.Value = Percent;
                lblPercent.Text = Percent + "%";
            });

            var ProgressConsole = new Progress<Msg>(msg =>
            {
                TxtOutput.SelectionStart = TxtOutput.TextLength;
                TxtOutput.SelectionLength = 0;

                TxtOutput.SelectionColor = msg.TextColor;
                TxtOutput.AppendText(msg.Text + "\n");
                TxtOutput.SelectionColor = TxtOutput.ForeColor;
                TxtOutput.ScrollToCaret();
            });

            Utils.ProgressConsole = ProgressConsole;

            Decryptor decryptor;
            var decryptorOptions = new DecryptorOptions()
            {
                UsageMode = RadioFolder.Checked ? Mode.Folder : Mode.File,
                UseOutputFolder = ComboOutputPath.Text == "" ? false : true,
                UseDatabase = ComboDbFile.Text == "" ? false : true,
                RemoveFilesAfterDecryption = false,

                InputPath = ComboInputPath.Text,
                OutputPath = ComboOutputPath.Text == "" ? Path.ChangeExtension(ComboInputPath.Text, ".mp4") : ComboOutputPath.Text,
                OutputFolder = ComboOutputPath.Text == "" ? Path.GetDirectoryName(ComboInputPath.Text) : ComboOutputPath.Text,
                DatabasePath = ComboDbFile.Text,
                SubTitle = ChkSubtitle.Checked ? true : false
            };

            CmdStartDecryption.Text = "Decrypting....";
            CmdStartDecryption.Enabled = false;
            CmdExit.Text = "Cancel";
            running = true;
            cts = new CancellationTokenSource();
            ct = cts.Token;

            try
            {
                decryptor = new Decryptor(decryptorOptions, ProgressPercent, ct);
                decryptor.InitDecryptor(ENCRYPTION_KEY);

                if (decryptorOptions.UsageMode == Mode.Folder)
                    await decryptor.DecryptAll(decryptorOptions.InputPath, decryptorOptions.OutputFolder);

                else if (decryptorOptions.UsageMode == Mode.File)
                    decryptor.Decrypt(decryptorOptions.InputPath, decryptorOptions.OutputPath);
            }
            catch (OperationCanceledException Ex)
            {
                MessageBox.Show("[CANCEL] Operation Cancelled: " + Ex.Message);
                WriteToConsole("[CANCEL] Operation Cancelled: " + Ex.Message + Environment.NewLine, Color.Yellow);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("[START] Error occured: " + Ex.Message);
                WriteToConsole("[START] Error occured: " + Ex.Message + Environment.NewLine, Color.Red);
            }
            finally
            {
                CmdStartDecryption.Text = "Start Decryption";
                CmdStartDecryption.Enabled = true;
                CmdExit.Text = "Exit";
                running = false;
                cts.Dispose();
            }
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            if(running == true)
            {
                cts.Cancel();
                running = false;
                CmdExit.Text = "Exit";
                return;
            }

            if (RadioFolder.Checked == true)
                Settings.Default.FolderMode = true;
            else
                Settings.Default.FolderMode = false;

            if (ChkUseDatabase.Checked == true)
                Settings.Default.UseDatabase = true;
            else
                Settings.Default.UseDatabase = false;

            if (ChkSubtitle.Checked == true)
                Settings.Default.Subtitle = true;
            else
                Settings.Default.Subtitle = false;

            int count, i;

            count = ComboInputPath.Items.Count;
            Settings.Default.InputLocation.Clear();

            for (i = 0; i < count; i++)
            Settings.Default.InputLocation.Add(ComboInputPath.Items[i].ToString());

            count = ComboOutputPath.Items.Count;
            Settings.Default.OutputLocation.Clear();

            for (i = 0; i < count; i++)
            Settings.Default.OutputLocation.Add(ComboOutputPath.Items[i].ToString());

            count = ComboDbFile.Items.Count;
            Settings.Default.DatabaseFile.Clear();

            for (i = 0; i < count; i++)
            Settings.Default.DatabaseFile.Add(ComboDbFile.Items[i].ToString());

            Settings.Default.Save();
            Close();
        }

        private void CmdBrowseInput_Click(object sender, EventArgs e)
        {
            string InputFolder;
            int i, count;

            count = Settings.Default.InputLocation.Count;

            if (count > 0 && Directory.Exists(Settings.Default.InputLocation[0]))
                InputFolder = Settings.Default.InputLocation[0];
            else
                InputFolder = DEFAULT_INPUT_FOLDER;

            count = ComboInputPath.Items.Count;

            if (RadioFolder.Checked == true)
            {
                FolderBrowserDialog FolderDlg = new FolderBrowserDialog
                {
                    ShowNewFolderButton = false,
                    Description="Select Input Folder",
                    SelectedPath = InputFolder
                };

                // Show the FolderBrowserDialog.  
                DialogResult result = FolderDlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    for (i = 0; i < count; i++)
                    {
                        if (ComboInputPath.Items[i].ToString() == FolderDlg.SelectedPath)
                        {
                            ComboInputPath.Items.RemoveAt(i);
                            break;
                        }
                    }
                                                                        
                    ComboInputPath.Items.Insert(0, FolderDlg.SelectedPath);

                    if (ComboInputPath.Items.Count > NUM_FAVOURITES)
                    {
                        count = ComboInputPath.Items.Count - NUM_FAVOURITES;

                        for (i = 0; i < count; i++)
                            ComboInputPath.Items.RemoveAt(ComboInputPath.Items.Count - 1);
                    }

                    ComboInputPath.SelectedIndex = 0;
                }
            }
            else
            {
                OpenFileDialog FileDlg = new OpenFileDialog
                {
                    InitialDirectory = InputFolder,
                    Title = "Select Encrypted Video File",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "lynda",
                    Filter = "Lynda files (*.lynda)|*.lynda|Video2Brain files (*.ldcw)|*.ldcw",
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (FileDlg.ShowDialog() == DialogResult.OK)
                {
                    ComboInputPath.Text = FileDlg.FileName;
                }
            }
        }

        private void CmdBrowseOutput_Click(object sender, EventArgs e)
        {
            string OutputFolder;
            int count;

            count = Settings.Default.OutputLocation.Count;

            if (count > 0 && Directory.Exists(Settings.Default.OutputLocation[0]))
                OutputFolder = Settings.Default.OutputLocation[0];
            else
                OutputFolder = DEFAULT_OUTPUT_FOLDER;

            FolderBrowserDialog FolderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = OutputFolder
            };

            // Show the FolderBrowserDialog.  
            DialogResult result = FolderDlg.ShowDialog();

            count = ComboOutputPath.Items.Count;

            if (result == DialogResult.OK)
            {
                for (int i = 0; i < count; i++)
                {
                    if (ComboOutputPath.Items[i].ToString() == FolderDlg.SelectedPath)
                    {
                        ComboOutputPath.Items.RemoveAt(i);
                        break;
                    }
                }

                ComboOutputPath.Items.Insert(0, FolderDlg.SelectedPath);

                if (ComboOutputPath.Items.Count > NUM_FAVOURITES)
                {
                        count = ComboOutputPath.Items.Count - NUM_FAVOURITES;

                        for (int i = 0; i < count; i++)
                                ComboOutputPath.Items.RemoveAt(ComboOutputPath.Items.Count - 1);
                }

                ComboOutputPath.SelectedIndex = 0;
            }
        }

        private void CmdBrowseDB_Click(object sender, EventArgs e)
        {
            string DbFolder;
            int count;

            count = Settings.Default.DatabaseFile.Count;
       
            if (count > 0 && Directory.Exists(Settings.Default.DatabaseFile[0]))
                DbFolder = Settings.Default.DatabaseFile[0];
            else
                DbFolder = DEFAULT_DATABASE_FOLDER;

            OpenFileDialog FileDlg = new OpenFileDialog
            {
                InitialDirectory = DbFolder,
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
            DialogResult result = FileDlg.ShowDialog();

            count = ComboDbFile.Items.Count;

            if (result == DialogResult.OK)
            {
                for (int i = 0; i < count; i++)
                {
                    if (ComboDbFile.Items[i].ToString() == FileDlg.FileName)
                    {
                        ComboDbFile.Items.RemoveAt(i);
                        break;
                    }
                }

                ComboDbFile.Items.Insert(0, FileDlg.FileName);

                if (ComboDbFile.Items.Count > NUM_FAVOURITES)
                {
                    count = ComboDbFile.Items.Count - NUM_FAVOURITES;

                    for (int i = 0; i < count; i++)
                        ComboDbFile.Items.RemoveAt(ComboDbFile.Items.Count - 1);
                }

                ComboDbFile.SelectedIndex = 0;
            }
        }

        private void CmdInputFavorites_Click(object sender, EventArgs e)
        {
            FrmFavorites MyFrmFavorites = new FrmFavorites(FavoriteType.Input);
            MyFrmFavorites.ShowDialog();
            UpdateComboBox(FavoriteType.Input);
        }

        private void CmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lynda Decryptor UI Version 1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmdOutputFavorites_Click(object sender, EventArgs e)
        {
            FrmFavorites MyFrmFavorites = new FrmFavorites(FavoriteType.Output);
            MyFrmFavorites.ShowDialog();
            UpdateComboBox(FavoriteType.Output);
        }

        private void CmdDatabaseFavorites_Click(object sender, EventArgs e)
        {
            FrmFavorites MyFrmFavorites = new FrmFavorites(FavoriteType.Database);
            MyFrmFavorites.ShowDialog();
            UpdateComboBox(FavoriteType.Database);
        }
    }
}
