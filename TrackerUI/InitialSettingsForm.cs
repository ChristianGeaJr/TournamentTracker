using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class InitialSettingsForm : Form
    {
        public InitialSettingsForm()
        {
            InitializeComponent();
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "--Select a Folder--";
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderPathTextBox.Text = fbd.SelectedPath;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (textFileRadioButton.Checked == false && sqlRadioButton.Checked == false)
            {
                MessageBox.Show("Please, chose one data connection type.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (textFileRadioButton.Checked)
            {
                tabControl1.SelectTab(1);
            }

            if (sqlRadioButton.Checked)
            {
                tabControl1.SelectTab(2);
            }
        }

        private void Back1Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void back2Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            ok2Button.Enabled = false;
        }

        private void ok1Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderPathTextBox.Text))
            {
                MessageBox.Show("Please, chose some folder.");
                return;
            }

            if (!Directory.Exists($"{FolderPathTextBox.Text}"))
            {
                MessageBox.Show("Please, enter a valid folder.");
                return;
            }


            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TournamentTracker");
            key.SetValue("DataConnection", "TextFile", RegistryValueKind.String);
            key.SetValue("FilePath", FolderPathTextBox.Text);
            key.Close();


            this.Close();
      
        }

        private void ok2Button_Click(object sender, EventArgs e)
        {

                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TournamentTracker");
                //key.SetValue("ConnectionString", "Server=.;Database=Tournaments;Trusted_Connection=true;", RegistryValueKind.String);
                key.SetValue("DataConnection", "SQL", RegistryValueKind.String);
                key.Close();

                this.Close(); 
            

        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {

                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
                    {
                        connection.Open();
                        connection.Close();

                        MessageBox.Show("Connected Successfully", "Database Connection.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ok2Button.Enabled = true;
                    }
                 
                }
                catch (Exception)
                {
                        StringBuilder message = new StringBuilder();
                        message.AppendLine("Connection Faild");
                        message.AppendLine("Check the following items:");
                        message.AppendLine("- If the Server is running.");
                        message.AppendLine("- If the database was successfully restored ");
                        message.AppendLine("with the name \"Tournaments\"");


                        MessageBox.Show(message.ToString(), "Database Connection.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
