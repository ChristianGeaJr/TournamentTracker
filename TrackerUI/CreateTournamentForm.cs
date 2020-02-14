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
    public partial class CreateTournamentForm : Form, IPrizeRequester//, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        TournamentDashboardForm _frm;

        public CreateTournamentForm(TournamentDashboardForm frm)
        {
            InitializeComponent();
            InitializeLists();
            _frm = frm;

        }

        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
            
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            if (availableTeams.Count == 0)
            {
                MessageBox.Show("The list is already empty!");
                return;
            }

            if (selectTeamDropDown.SelectedValue == null)
            {
                MessageBox.Show("Pleas, select some Team.");
                return;
            }


            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;
            availableTeams.Remove(t);
            selectedTeams.Add(t);

            InitializeLists();

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this); // this represents this specific instance (instance of CreateTournamentForm).
            frm.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get a PrizeModel back from the Form
            //Take the PrizeModel and put it into our list of Prizes

            selectedPrizes.Add(model);
            InitializeLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Call the CreatePrizeForm
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            InitializeLists();
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            if (selectedTeams.Count == 0)
            {
                MessageBox.Show("The list is already empty!");
                return;
            }

            if (tournamentTeamsListBox.SelectedValue == null)
            {

                MessageBox.Show("Select some team.");
                return;

            }




            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            selectedTeams.Remove(t);
            availableTeams.Add(t);

            InitializeLists();
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            if (selectedPrizes.Count == 0)
            {
                MessageBox.Show("The list is already empty!");
                return;
            }

            if (prizesListBox.SelectedValue == null)
            {

                MessageBox.Show("Select some Prize.");
                return;
            }

            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;
            selectedPrizes.Remove(p);

            InitializeLists();


        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
 
            //Validate data

            if (string.IsNullOrWhiteSpace(tournamentNameTextBox.Text))
            {
                MessageBox.Show("Please, enter the tournament name", "Invalid Tournament name.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tournamentNameTextBox.Focus();
                return;
            }

            decimal fee = 0;
            bool validFee = decimal.TryParse(entryFeeTextBox.Text, out fee);

            if (!validFee)
            {
                MessageBox.Show("You need to enter a valid fee.", "Invalid fee.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Create our Tournament Model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameTextBox.Text;
            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
            tm.Active = 1;


            TournamentLogic.CreateRounds(tm);


            //Create Tournament Entry
            //Create all of the Prizes Entries
            //Create all of the Team Entries

            GlobalConfig.Connection.CreateTournament(tm);
            tm.AlertUsersToNewRownd();

            MessageBox.Show("Tournament Created.");

            TournamentViewerForm frm = new TournamentViewerForm(tm, _frm);
            frm.Show();

            this.Close();

        }
    }
}
