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
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        CreateTournamentForm callingForm;
        //ITeamRequester callingForm;


        public CreateTeamForm(CreateTournamentForm caller)
        {

            InitializeComponent();
            callingForm = caller;
            //CreateSampleData();
            WireUpLists();
        }

        //private void CreateSampleData()
        //{
        //    availableTeamMembers.Add(new PersonModel() { FirstName = "Tim", LastName = "Correy" });
        //    availableTeamMembers.Add(new PersonModel() { FirstName = "Sue", LastName = "Storm" });

        //    selectedTeamMembers.Add(new PersonModel() { FirstName = "Jane", LastName = "Smith" });
        //    selectedTeamMembers.Add(new PersonModel() { FirstName = "Bill", LastName = "Jhones" });
        //}
        

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersLlistBox.DataSource = null;
            teamMembersLlistBox.DataSource = selectedTeamMembers;
            teamMembersLlistBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameTextBox.Text;
                p.LastName = lastNameTextBox.Text;
                p.EmailAddress = emailTextBox.Text;
                p.CellphoneNumber = cellphoneTextBox.Text;

               GlobalConfig.Connection.CreatePerson(p); //This way we can capture back the ID

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellphoneTextBox.Text = "";


            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Add validation to the Create Member Form

            if (firstNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {


            if (availableTeamMembers.Count == 0)
            {
                MessageBox.Show("The list is already empty!");
                return;
            }

                if (selectTeamMemberDropDown.SelectedValue == null)
            {
                MessageBox.Show("Pleas, select some Team Member");
                return;
            }

                       
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem; // C# provides the casting from the object type to the desired type, but the explicit casting must be declared
            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);
            
                WireUpLists();
            
        

            

        }

        private void removeSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {


            if (selectedTeamMembers.Count == 0)
            {
                MessageBox.Show("The list is already empty!");
                return;
            }

            if (teamMembersLlistBox.SelectedValue == null)
            {

                MessageBox.Show("Select some team Member");
                return;

            }

            


                PersonModel p = (PersonModel)teamMembersLlistBox.SelectedItem;
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(teamNameTextBox.Text))
            {
                MessageBox.Show("Enter the Team Name");
                return;
            }

            if (selectedTeamMembers.Count == 0)
            {
                MessageBox.Show("Please, select some Team Member");
                return;
            }


            TeamModel model = new TeamModel();
            model.TeamMembers = selectedTeamMembers;
            model.TeamName = teamNameTextBox.Text;

            GlobalConfig.Connection.CreateTeam(model);

            callingForm.TeamComplete(model);
            

            this.Close();

            // TODO - If we aren't closing this form after creation, reset the form.

            //foreach (var teamMember in selectedTeamMembers)
            //{
            //    availableTeamMembers.Add(teamMember);
            //}

            //selectedTeamMembers.Clear();
            //teamNameTextBox.Text = "";


            //WireUpLists();

            //MessageBox.Show("The team was created!");
            
        }
    }
}
