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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        TournamentDashboardForm _frm;


        public TournamentViewerForm(TournamentModel tournamentModel, TournamentDashboardForm frm)
        {
            InitializeComponent();
            tournament = tournamentModel;
            tournament.OnTournamentComplet += Tournament_OnTournamentComplet;

            LoadFormData();
            LoadRounds();
            _frm = frm;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _frm.tournaments = GlobalConfig.Connection.GetTournament_All();
            _frm.InitializeLists();
        }

        private void Tournament_OnTournamentComplet(object sender, DateTime e)
        {
            this.Close();
            //_frm.tournaments = GlobalConfig.Connection.GetTournament_All();
            //_frm.InitializeLists();


        }

        private void LoadFormData()
        {
            tournamentNameLable.Text = tournament.TournamentName;
        }

        private void InitializeRoundLists()
        {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;

        }

        private void InitializeMatchupsLists()
        {

            matchupListBox.DataSource = null;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()// <= The bug was cought in this place (19:00:00)
        {
            //rounds = new List<int>();
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound) // The matchup round doesn't change for every matchup. That's why we can use the first one.
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                    //There should be a round number for every single round we have.
                }
            }

            InitializeRoundLists();
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)roundDropDown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round) 
                {
                    //selectedMatchups = matchups;              
                    //new piece of code
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !UnplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }

                    //end new piece of code  
                }
            }

            InitializeMatchupsLists();

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);
            TeamOneNameLabel.Visible = isVisible;
            TeamOneScoreLabel.Visible = isVisible;
            TeamOneScoreTextBox.Visible = isVisible;

            TeamTwoNameLabel.Visible = isVisible;
            TeamTwoScoreLabel.Visible = isVisible;
            TeamTwoScoreTextBox.Visible = isVisible;

            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            if (m != null) // <= added code line
            {
                for (int i = 0; i < m.Entries.Count; i++) 
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            TeamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                            TeamOneScoreTextBox.Text = m.Entries[0].Score.ToString();

                            TeamTwoNameLabel.Text = "<bye>";
                            TeamTwoScoreTextBox.Text = "0";
                        }
                        else
                        {
                            TeamOneNameLabel.Text = "Not set yet.";
                            TeamOneScoreTextBox.Text = "";

                        }

                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            TeamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                            TeamTwoScoreTextBox.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            TeamTwoNameLabel.Text = "Not set yet.";
                            TeamTwoScoreTextBox.Text = "";
                        }

                    }
                }
            } // <=
        } 

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }

        private void UnplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }


        private string ValidData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(TeamOneScoreTextBox.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(TeamTwoScoreTextBox.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "The Score One value is not a valid number.";
                //return output;
            }

            else if (!scoreTwoValid)
            {
                output = "The Score Two value is not a valid number.";
                //return output;
            }

            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score for either team.";
                //return output;
            }

            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in our application";
                //return output;
            }

            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage);
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            if (m != null) // <= added code line
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {

                            bool scoreValid = double.TryParse(TeamOneScoreTextBox.Text, out teamOneScore);

                            if (scoreValid)
                            {
                                m.Entries[0].Score = teamOneScore;
                            }
                            else
                            {
                                MessageBox.Show("Enter a valid score for team 1;");
                                return;
                            }
                            
                        }
                       

                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {

                            bool scoreValid = double.TryParse(TeamTwoScoreTextBox.Text, out teamTwoScore);

                            if (scoreValid)
                            {
                                m.Entries[1].Score = teamTwoScore;
                            }
                            else
                            {
                                MessageBox.Show("Enter a valid score for team 2;");
                                return;
                            }

                        }
                        

                    }
                }


                try
                {
                    TournamentLogic.UpdateTournamentResults(tournament);

                }
                catch (Exception ex)
                {

                    //throw;
                    MessageBox.Show($"The application had the following error: {ex.Message}");
                    return;
                }
            } // <=

            

            LoadMatchups();


        }
    }
}
