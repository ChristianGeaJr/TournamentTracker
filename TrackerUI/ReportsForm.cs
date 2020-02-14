using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class ReportsForm : Form
    {

        public ReportsForm()
        {
            InitializeComponent();

        }

        private void tournamentsRatioButton_Click(object sender, EventArgs e)
        {
            TournamentsRatioForm frm = new TournamentsRatioForm();
            frm.Show();
        }

        private void tournamentsGraphicViewButton_Click(object sender, EventArgs e)
        {
            TournamentGraphicViewForm frm = new TournamentGraphicViewForm();
            frm.Show();
        }
    }
}
