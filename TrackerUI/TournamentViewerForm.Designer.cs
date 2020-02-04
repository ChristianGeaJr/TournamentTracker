namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.HeaderLable = new System.Windows.Forms.Label();
            this.tournamentNameLable = new System.Windows.Forms.Label();
            this.roundLable = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoNameLabel = new System.Windows.Forms.Label();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLable
            // 
            this.HeaderLable.AutoSize = true;
            this.HeaderLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.HeaderLable.Location = new System.Drawing.Point(22, 9);
            this.HeaderLable.Name = "HeaderLable";
            this.HeaderLable.Size = new System.Drawing.Size(224, 50);
            this.HeaderLable.TabIndex = 0;
            this.HeaderLable.Text = "Tournament: ";
            // 
            // tournamentNameLable
            // 
            this.tournamentNameLable.AutoSize = true;
            this.tournamentNameLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentNameLable.Location = new System.Drawing.Point(220, 9);
            this.tournamentNameLable.Name = "tournamentNameLable";
            this.tournamentNameLable.Size = new System.Drawing.Size(156, 50);
            this.tournamentNameLable.TabIndex = 1;
            this.tournamentNameLable.Text = "<None>";
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.roundLable.Location = new System.Drawing.Point(24, 75);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(94, 37);
            this.roundLable.TabIndex = 2;
            this.roundLable.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(124, 74);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(221, 38);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(124, 118);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(209, 41);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.UnplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.UnplayedOnlyCheckBox_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(31, 174);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(314, 242);
            this.matchupListBox.TabIndex = 5;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // TeamOneNameLabel
            // 
            this.TeamOneNameLabel.AutoSize = true;
            this.TeamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamOneNameLabel.Location = new System.Drawing.Point(394, 174);
            this.TeamOneNameLabel.Name = "TeamOneNameLabel";
            this.TeamOneNameLabel.Size = new System.Drawing.Size(171, 37);
            this.TeamOneNameLabel.TabIndex = 6;
            this.TeamOneNameLabel.Text = "<Team One>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(394, 227);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(88, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score:";
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(479, 229);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreTextBox.TabIndex = 8;
            // 
            // TeamTwoNameLabel
            // 
            this.TeamTwoNameLabel.AutoSize = true;
            this.TeamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamTwoNameLabel.Location = new System.Drawing.Point(394, 332);
            this.TeamTwoNameLabel.Name = "TeamTwoNameLabel";
            this.TeamTwoNameLabel.Size = new System.Drawing.Size(171, 37);
            this.TeamTwoNameLabel.TabIndex = 6;
            this.TeamTwoNameLabel.Text = "<Team Two>";
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(394, 385);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(88, 37);
            this.TeamTwoScoreLabel.TabIndex = 7;
            this.TeamTwoScoreLabel.Text = "Score:";
            // 
            // TeamTwoScoreTextBox
            // 
            this.TeamTwoScoreTextBox.Location = new System.Drawing.Point(479, 387);
            this.TeamTwoScoreTextBox.Name = "TeamTwoScoreTextBox";
            this.TeamTwoScoreTextBox.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreTextBox.TabIndex = 8;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.versusLabel.Location = new System.Drawing.Point(448, 286);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(70, 37);
            this.versusLabel.TabIndex = 9;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(594, 282);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(99, 50);
            this.scoreButton.TabIndex = 10;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 474);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.TeamTwoScoreTextBox);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamOneScoreTextBox);
            this.Controls.Add(this.TeamTwoNameLabel);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneNameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.tournamentNameLable);
            this.Controls.Add(this.HeaderLable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLable;
        private System.Windows.Forms.Label tournamentNameLable;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label TeamOneNameLabel;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreTextBox;
        private System.Windows.Forms.Label TeamTwoNameLabel;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.TextBox TeamTwoScoreTextBox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

