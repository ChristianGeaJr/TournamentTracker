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
    public partial class TournamentsRatioForm : Form
    {

         private List<TeamModel> teams = new List<TeamModel>() { new TeamModel() { TeamName = "***" } };
        private List<TournamentModel> tournaments = new List<TournamentModel>();

     

        public TournamentsRatioForm()
        {
            InitializeComponent();
            entryFeeComboBox.SelectedIndex = 0;

            teams.AddRange(GlobalConfig.Connection.GetTeam_All());

            winnerComboBox.DataSource = teams;
            winnerComboBox.DisplayMember = "TeamName";


        }
        
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                int dateFilter = 0;

                if (dateCreatedRadioButton.Checked)
                {
                    dateFilter = 1;
                }
                if (dateFinishedRadioButton.Checked)
                {
                    dateFilter = 2;
                }
                DateTime initialDate = initialDateTimePicker.Value;
                DateTime finalDate = finalDateTimePicker.Value;

                int tournamentFilter = 0;

                   if (ongoingAndFinishedRadioButton.Checked)
                {
                    tournamentFilter = 1;
                }
                if (finishedOnlyRadioButton.Checked)
                {
                    tournamentFilter = 2;
                }
                if (ongoingOnlyRadioButton.Checked)
                {
                    tournamentFilter = 3;
                }

                string entryFeeFilter = (entryFeeComboBox.SelectedItem.ToString() == "All") ? "0" : entryFeeComboBox.SelectedItem.ToString();

                decimal? entryFee = null;

                if (entryFeeFilter == "0")
                {
                    entryFee = null;
                }
                else
                {
                    entryFee = decimal.Parse(entryFeeTextBox.Text);
                }


            TeamModel winner = (TeamModel)winnerComboBox.SelectedItem;

             tournaments = GlobalConfig.Connection.TournamentRatio(dateFilter, initialDate, finalDate, tournamentFilter, entryFeeFilter, entryFee, winner.Id);

            tournamentsRatioDataGridView.DataSource = tournaments;

            int i = 0;
            foreach (TournamentModel tournament in tournaments)
            {
                if (tournament.Winner != null)
                {
                    tournamentsRatioDataGridView["winner", i].Value = tournament.Winner.TeamName;
                }
                
                i += 1;
            }

            if (tournaments.Count == 0)
            {
                MessageBox.Show("0 Results!", "", 0, icon:MessageBoxIcon.Information);
            }

        }//<= isValidForm()

        }

        private bool isValidForm()
        {
                

            if (initialDateTimePicker.Value.AddMilliseconds(-100) > finalDateTimePicker.Value)
            {
                MessageBox.Show("Initial date cannot be bigger then final date", "Attention!", 0, icon: MessageBoxIcon.Exclamation);
                initialDateTimePicker.Focus();
                return false;
            }


            decimal entryFeeValue;
            if (entryFeeComboBox.SelectedItem.ToString() != "All" && decimal.TryParse(entryFeeTextBox.Text, out entryFeeValue) == false)
            {
                MessageBox.Show("Entry Fee must be a valid number.", "Attention!", 0, icon: MessageBoxIcon.Exclamation);
                entryFeeTextBox.Focus();
                return false;
            }

            return true;
        }

        private void entryFeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entryFeeComboBox.SelectedItem.ToString() != "All")
            {
                entryFeeTextBox.Enabled = true;
            }
            else
            {
                entryFeeTextBox.Text = "";
                entryFeeTextBox.Enabled = false;
            }
        }

        private void ongoingOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ongoingOnlyRadioButton.Checked)
            {
                dateCreatedRadioButton.Checked = true;
                dateCreatedRadioButton.Enabled = false;
                dateFinishedRadioButton.Enabled = false;
                winnerComboBox.SelectedIndex = 0;
                winnerComboBox.Enabled = false;

            }

        }

        private void finishedOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateCreatedRadioButton.Enabled = true;
            dateFinishedRadioButton.Enabled = true;
            winnerComboBox.Enabled = true;
        }

        private void ongoingAndFinishedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateCreatedRadioButton.Enabled = true;
            dateFinishedRadioButton.Enabled = true;
            winnerComboBox.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            initialDateTimePicker.Value = DateTime.Now;
            finalDateTimePicker.Value = DateTime.Now;

            dateCreatedRadioButton.Checked = true;
            ongoingAndFinishedRadioButton.Checked = true;

            entryFeeTextBox.Text = "";
            entryFeeComboBox.SelectedIndex = 0;

            winnerComboBox.SelectedIndex = 0;

            tournamentsRatioDataGridView.DataSource = null;
        }

        private void tournamentsRatioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                StringBuilder enteredTeams = new StringBuilder();
                foreach (TeamModel team in tournaments[e.RowIndex].EnteredTeams)
                {
                    enteredTeams.AppendLine(team.TeamName);
                }
                MessageBox.Show(enteredTeams.ToString(), "Entered Teams.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
