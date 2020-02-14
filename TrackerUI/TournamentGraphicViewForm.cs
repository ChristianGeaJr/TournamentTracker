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
    public partial class TournamentGraphicViewForm : Form
    {
        int lastIndex;

        public TournamentGraphicViewForm()
        {
            InitializeComponent();

            tournamentComboBox.DataSource = GlobalConfig.Connection.GetTournament_All();
            tournamentComboBox.DisplayMember = "TournamentName";

            lastIndex = this.Controls.Count - 1;

        }

 
        private void generateButton_Click(object sender, EventArgs e)
        {
            //ControlCollection auxControl = new ControlCollection(this);

            for (int i = Controls.Count - 1; i > lastIndex; i--)
            {
                Controls.RemoveAt(i);
            }

            TournamentModel tournament = (TournamentModel)tournamentComboBox.SelectedItem;

            int startingPointX = 50;
            int startingPointY = 150;
     
            for (int i = 0; i < tournament.Rounds.Count  ; i++)
            {
                string roundName = $"Round {i + 1}";

                this.Controls.Add(new Label()
                {
                    Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = System.Drawing.Color.Black,
                    Location = new System.Drawing.Point(startingPointX, startingPointY),
                    Name = roundName,
                    Size = new System.Drawing.Size((int)(roundName.Length * 10), 25),
                    TabIndex = 13,
                    Text = roundName,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                });

                startingPointY += 50;



                foreach (MatchupModel matchup in tournament.Rounds[i])
                {

                        if (matchup.Entries.Count == 2)
                        {
                            string teamOneName = (matchup.Entries[0].TeamCompeting == null) ? "Not Yet Determined." : matchup.Entries[0].TeamCompeting.TeamName;
                            string teamTwoName = (matchup.Entries[1].TeamCompeting == null) ? "Not Yet Determined." : matchup.Entries[1].TeamCompeting.TeamName;

                        System.Drawing.Color colorTeamOne = (matchup.Entries[0].Score > matchup.Entries[1].Score) ? Color.Red : Color.CornflowerBlue;
                        System.Drawing.Color colorTeamTwo = (matchup.Entries[1].Score > matchup.Entries[0].Score) ? Color.Red : Color.CornflowerBlue;

                        this.Controls.Add(new Label()
                            {
                                Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                                ForeColor = colorTeamOne,
                                Location = new System.Drawing.Point(startingPointX, startingPointY),
                                Name = teamOneName,
                                Size = new System.Drawing.Size((int)(teamOneName.Length * 10), 25),
                                TabIndex = 13,
                                Text = teamOneName,
                                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                            });

                            startingPointY += 30;

                        this.Controls.Add(new Label()
                        {
                            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(startingPointX + 15, startingPointY),
                            Name = "VS",
                            Size = new System.Drawing.Size((int)("VS".Length * 15), 25),
                            TabIndex = 13,
                            Text = "VS",
                            //BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        });

                        startingPointY += 25;

                        this.Controls.Add(new Label()
                        {
                            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            ForeColor = colorTeamTwo,
                            Location = new System.Drawing.Point(startingPointX, startingPointY),
                            Name = teamTwoName,
                            Size = new System.Drawing.Size((int)(teamTwoName.Length * 10), 25),
                            TabIndex = 13,
                            Text = teamTwoName,
                            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        });

                        startingPointY += 50;
                    }
                    if (matchup.Entries.Count == 1)
                    {
                        string teamOneName = (matchup.Entries[0].TeamCompeting == null) ? "Not Yet Determined." : matchup.Entries[0].TeamCompeting.TeamName;
                        //string teamTwoName = (matchup.Entries[1].TeamCompeting == null) ? "Not Yet Determined." : matchup.Entries[1].TeamCompeting.TeamName;

                        this.Controls.Add(new Label()
                        {
                            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            ForeColor = System.Drawing.Color.Red,
                            Location = new System.Drawing.Point(startingPointX, startingPointY),
                            Name = teamOneName,
                            Size = new System.Drawing.Size((int)(teamOneName.Length * 10), 25),
                            TabIndex = 13,
                            Text = teamOneName,
                            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        });

                        startingPointY += 30;

                        this.Controls.Add(new Label()
                        {
                            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(startingPointX + 15, startingPointY),
                            Name = "VS",
                            Size = new System.Drawing.Size((int)("VS".Length * 15), 25),
                            TabIndex = 13,
                            Text = "VS",
                            //BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        });

                        startingPointY += 25;

                        this.Controls.Add(new Label()
                        {
                            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                            Location = new System.Drawing.Point(startingPointX, startingPointY),
                            Name = "ByeWeek",
                            Size = new System.Drawing.Size((int)("None (ByeWeek)".Length * 9), 25),
                            TabIndex = 13,
                            Text = "None (ByeWeek)",
                            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                        });

                        startingPointY += 50;
                    }


                }

                startingPointX += 200;
                startingPointY = 150;
            }

            bool hasWinner = tournament.Rounds.Last().Last().Entries.Last().TeamCompeting != null;
            TeamModel winner = new TeamModel();
            bool teamOneWinner = false;
            bool teamTwoWinner = false;
            if (tournament.Rounds.Last().Last().Entries.First().Score > tournament.Rounds.Last().Last().Entries.Last().Score)
            {
                teamOneWinner = true;
                winner = tournament.Rounds.Last().Last().Entries.First().TeamCompeting;
            }
            if (tournament.Rounds.Last().Last().Entries.Last().Score > tournament.Rounds.Last().Last().Entries.First().Score)
            {
                teamTwoWinner = true;
                winner = tournament.Rounds.Last().Last().Entries.Last().TeamCompeting;
            }




            if (hasWinner && (teamOneWinner || teamTwoWinner))
            {
                this.Controls.Add(new Label()
                {
                    Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.Black,
                    Location = new System.Drawing.Point(startingPointX, startingPointY),
                    Name = "Winner",
                    Size = new System.Drawing.Size((int)("Winner".Length * 11), 25),
                    TabIndex = 13,
                    Text = "Winner",
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                });

                startingPointY += 50;

                this.Controls.Add(new Label()
                {
                    Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = Color.Red,
                    Location = new System.Drawing.Point(startingPointX, startingPointY),
                    Name = winner.TeamName,
                    Size = new System.Drawing.Size((int)(winner.TeamName.Length * 10), 25),
                    TabIndex = 13,
                    Text = winner.TeamName,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                });
            }
        }
    }
}
