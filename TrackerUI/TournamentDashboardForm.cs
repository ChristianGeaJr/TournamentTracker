using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        public List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        public void InitializeLists()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm tournament = new CreateTournamentForm(this);
            tournament.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExistingTournamentDropDown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm, this);
            frm.Show();
        }

        private void repportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.Show();
        }

        private void clearSettingsButton_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Are you sure you want to reset the Initial Settings?");
            message.AppendLine("Your tournament data is not going to be deleted.");
            message.AppendLine("If you set the current data connection type again");
            message.AppendLine("your saved data will be accesible.");

            DialogResult result = MessageBox.Show(message.ToString(), "Reset Initial Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TournamentTracker");
                key.SetValue("DataConnection", "SQL", RegistryValueKind.String);
                key.DeleteValue("DataConnection");
                key.Close();
                Application.Restart();
            }
            
        }

        private void clearSettingsButton_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
