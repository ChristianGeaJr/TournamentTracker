namespace TrackerUI
{
    partial class TournamentsRatioForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentsRatioForm));
            this.tournamentRatioLable = new System.Windows.Forms.Label();
            this.initialDateLabel = new System.Windows.Forms.Label();
            this.initialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finalDateLabel = new System.Windows.Forms.Label();
            this.dateFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.dateCreatedRadioButton = new System.Windows.Forms.RadioButton();
            this.dateFinishedRadioButton = new System.Windows.Forms.RadioButton();
            this.finishedOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.ongoingAndFinishedRadioButton = new System.Windows.Forms.RadioButton();
            this.tournamentFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.ongoingOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeComboBox = new System.Windows.Forms.ComboBox();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winnerComboBox = new System.Windows.Forms.ComboBox();
            this.tournamentsRatioDataGridView = new System.Windows.Forms.DataGridView();
            this.teamModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tournamentMembers = new System.Windows.Forms.DataGridViewButtonColumn();
            this.winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFilterGroupBox.SuspendLayout();
            this.tournamentFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsRatioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tournamentRatioLable
            // 
            this.tournamentRatioLable.AutoSize = true;
            this.tournamentRatioLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentRatioLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentRatioLable.Location = new System.Drawing.Point(57, 6);
            this.tournamentRatioLable.Name = "tournamentRatioLable";
            this.tournamentRatioLable.Size = new System.Drawing.Size(309, 50);
            this.tournamentRatioLable.TabIndex = 13;
            this.tournamentRatioLable.Text = "Tournaments Ratio";
            // 
            // initialDateLabel
            // 
            this.initialDateLabel.AutoSize = true;
            this.initialDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDateLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.initialDateLabel.Location = new System.Drawing.Point(75, 82);
            this.initialDateLabel.Name = "initialDateLabel";
            this.initialDateLabel.Size = new System.Drawing.Size(103, 25);
            this.initialDateLabel.TabIndex = 15;
            this.initialDateLabel.Text = "Initial Date";
            // 
            // initialDateTimePicker
            // 
            this.initialDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.initialDateTimePicker.Location = new System.Drawing.Point(184, 86);
            this.initialDateTimePicker.Name = "initialDateTimePicker";
            this.initialDateTimePicker.Size = new System.Drawing.Size(95, 22);
            this.initialDateTimePicker.TabIndex = 16;
            // 
            // finalDateTimePicker
            // 
            this.finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finalDateTimePicker.Location = new System.Drawing.Point(184, 118);
            this.finalDateTimePicker.Name = "finalDateTimePicker";
            this.finalDateTimePicker.Size = new System.Drawing.Size(95, 22);
            this.finalDateTimePicker.TabIndex = 18;
            // 
            // finalDateLabel
            // 
            this.finalDateLabel.AutoSize = true;
            this.finalDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDateLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.finalDateLabel.Location = new System.Drawing.Point(75, 114);
            this.finalDateLabel.Name = "finalDateLabel";
            this.finalDateLabel.Size = new System.Drawing.Size(96, 25);
            this.finalDateLabel.TabIndex = 17;
            this.finalDateLabel.Text = "Final Date";
            // 
            // dateFilterGroupBox
            // 
            this.dateFilterGroupBox.Controls.Add(this.dateFinishedRadioButton);
            this.dateFilterGroupBox.Controls.Add(this.dateCreatedRadioButton);
            this.dateFilterGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilterGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.dateFilterGroupBox.Location = new System.Drawing.Point(314, 77);
            this.dateFilterGroupBox.Name = "dateFilterGroupBox";
            this.dateFilterGroupBox.Size = new System.Drawing.Size(130, 64);
            this.dateFilterGroupBox.TabIndex = 19;
            this.dateFilterGroupBox.TabStop = false;
            this.dateFilterGroupBox.Text = "Filter date by";
            // 
            // dateCreatedRadioButton
            // 
            this.dateCreatedRadioButton.AutoSize = true;
            this.dateCreatedRadioButton.Checked = true;
            this.dateCreatedRadioButton.ForeColor = System.Drawing.Color.Black;
            this.dateCreatedRadioButton.Location = new System.Drawing.Point(11, 16);
            this.dateCreatedRadioButton.Name = "dateCreatedRadioButton";
            this.dateCreatedRadioButton.Size = new System.Drawing.Size(103, 21);
            this.dateCreatedRadioButton.TabIndex = 0;
            this.dateCreatedRadioButton.TabStop = true;
            this.dateCreatedRadioButton.Text = "Date Created";
            this.dateCreatedRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateFinishedRadioButton
            // 
            this.dateFinishedRadioButton.AutoSize = true;
            this.dateFinishedRadioButton.ForeColor = System.Drawing.Color.Black;
            this.dateFinishedRadioButton.Location = new System.Drawing.Point(11, 37);
            this.dateFinishedRadioButton.Name = "dateFinishedRadioButton";
            this.dateFinishedRadioButton.Size = new System.Drawing.Size(104, 21);
            this.dateFinishedRadioButton.TabIndex = 0;
            this.dateFinishedRadioButton.Text = "Date Finished";
            this.dateFinishedRadioButton.UseVisualStyleBackColor = true;
            // 
            // finishedOnlyRadioButton
            // 
            this.finishedOnlyRadioButton.AutoSize = true;
            this.finishedOnlyRadioButton.ForeColor = System.Drawing.Color.Black;
            this.finishedOnlyRadioButton.Location = new System.Drawing.Point(11, 39);
            this.finishedOnlyRadioButton.Name = "finishedOnlyRadioButton";
            this.finishedOnlyRadioButton.Size = new System.Drawing.Size(103, 21);
            this.finishedOnlyRadioButton.TabIndex = 0;
            this.finishedOnlyRadioButton.Text = "Finished Only";
            this.finishedOnlyRadioButton.UseVisualStyleBackColor = true;
            this.finishedOnlyRadioButton.CheckedChanged += new System.EventHandler(this.finishedOnlyRadioButton_CheckedChanged);
            // 
            // ongoingAndFinishedRadioButton
            // 
            this.ongoingAndFinishedRadioButton.AutoSize = true;
            this.ongoingAndFinishedRadioButton.Checked = true;
            this.ongoingAndFinishedRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ongoingAndFinishedRadioButton.Location = new System.Drawing.Point(11, 19);
            this.ongoingAndFinishedRadioButton.Name = "ongoingAndFinishedRadioButton";
            this.ongoingAndFinishedRadioButton.Size = new System.Drawing.Size(154, 21);
            this.ongoingAndFinishedRadioButton.TabIndex = 0;
            this.ongoingAndFinishedRadioButton.TabStop = true;
            this.ongoingAndFinishedRadioButton.Text = "Ongoing and Finished";
            this.ongoingAndFinishedRadioButton.UseVisualStyleBackColor = true;
            this.ongoingAndFinishedRadioButton.CheckedChanged += new System.EventHandler(this.ongoingAndFinishedRadioButton_CheckedChanged);
            // 
            // tournamentFilterGroupBox
            // 
            this.tournamentFilterGroupBox.Controls.Add(this.ongoingOnlyRadioButton);
            this.tournamentFilterGroupBox.Controls.Add(this.finishedOnlyRadioButton);
            this.tournamentFilterGroupBox.Controls.Add(this.ongoingAndFinishedRadioButton);
            this.tournamentFilterGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentFilterGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tournamentFilterGroupBox.Location = new System.Drawing.Point(53, 153);
            this.tournamentFilterGroupBox.Name = "tournamentFilterGroupBox";
            this.tournamentFilterGroupBox.Size = new System.Drawing.Size(176, 94);
            this.tournamentFilterGroupBox.TabIndex = 20;
            this.tournamentFilterGroupBox.TabStop = false;
            this.tournamentFilterGroupBox.Text = "Filter Tournament by";
            // 
            // ongoingOnlyRadioButton
            // 
            this.ongoingOnlyRadioButton.AutoSize = true;
            this.ongoingOnlyRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ongoingOnlyRadioButton.Location = new System.Drawing.Point(11, 60);
            this.ongoingOnlyRadioButton.Name = "ongoingOnlyRadioButton";
            this.ongoingOnlyRadioButton.Size = new System.Drawing.Size(107, 21);
            this.ongoingOnlyRadioButton.TabIndex = 1;
            this.ongoingOnlyRadioButton.Text = "Ongoing Only";
            this.ongoingOnlyRadioButton.UseVisualStyleBackColor = true;
            this.ongoingOnlyRadioButton.CheckedChanged += new System.EventHandler(this.ongoingOnlyRadioButton_CheckedChanged);
            // 
            // generateButton
            // 
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.generateButton.Location = new System.Drawing.Point(117, 267);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(116, 43);
            this.generateButton.TabIndex = 21;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.clearButton.Location = new System.Drawing.Point(274, 267);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 43);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.Location = new System.Drawing.Point(254, 162);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(89, 25);
            this.entryFeeLabel.TabIndex = 23;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeComboBox
            // 
            this.entryFeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryFeeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entryFeeComboBox.FormattingEnabled = true;
            this.entryFeeComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.entryFeeComboBox.Items.AddRange(new object[] {
            "All",
            ">",
            ">=",
            "=",
            "<",
            "<="});
            this.entryFeeComboBox.Location = new System.Drawing.Point(349, 166);
            this.entryFeeComboBox.Name = "entryFeeComboBox";
            this.entryFeeComboBox.Size = new System.Drawing.Size(54, 21);
            this.entryFeeComboBox.TabIndex = 24;
            this.entryFeeComboBox.SelectedIndexChanged += new System.EventHandler(this.entryFeeComboBox_SelectedIndexChanged);
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Enabled = false;
            this.entryFeeTextBox.Location = new System.Drawing.Point(409, 165);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(76, 22);
            this.entryFeeTextBox.TabIndex = 25;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(254, 192);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(74, 25);
            this.winnerLabel.TabIndex = 26;
            this.winnerLabel.Text = "Winner";
            // 
            // winnerComboBox
            // 
            this.winnerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.winnerComboBox.FormattingEnabled = true;
            this.winnerComboBox.Location = new System.Drawing.Point(341, 195);
            this.winnerComboBox.Name = "winnerComboBox";
            this.winnerComboBox.Size = new System.Drawing.Size(144, 21);
            this.winnerComboBox.TabIndex = 27;
            // 
            // tournamentsRatioDataGridView
            // 
            this.tournamentsRatioDataGridView.AllowUserToAddRows = false;
            this.tournamentsRatioDataGridView.AllowUserToDeleteRows = false;
            this.tournamentsRatioDataGridView.AllowUserToOrderColumns = true;
            this.tournamentsRatioDataGridView.AutoGenerateColumns = false;
            this.tournamentsRatioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentsRatioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tournamentName,
            this.dateCreated,
            this.dateFinished,
            this.entryFee,
            this.tournamentMembers,
            this.winner,
            this.idDataGridViewTextBoxColumn});
            this.tournamentsRatioDataGridView.DataSource = this.teamModelBindingSource;
            this.tournamentsRatioDataGridView.Location = new System.Drawing.Point(12, 338);
            this.tournamentsRatioDataGridView.Name = "tournamentsRatioDataGridView";
            this.tournamentsRatioDataGridView.ReadOnly = true;
            this.tournamentsRatioDataGridView.Size = new System.Drawing.Size(526, 187);
            this.tournamentsRatioDataGridView.TabIndex = 30;
            this.tournamentsRatioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentsRatioDataGridView_CellClick);
            // 
            // teamModelBindingSource
            // 
            this.teamModelBindingSource.DataSource = typeof(TrackerLibrary.Models.TeamModel);
            // 
            // tournamentModelBindingSource
            // 
            this.tournamentModelBindingSource.DataSource = typeof(TrackerLibrary.Models.TournamentModel);
            // 
            // tournamentName
            // 
            this.tournamentName.DataPropertyName = "TournamentName";
            this.tournamentName.HeaderText = "Tourn. Name";
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.ReadOnly = true;
            // 
            // dateCreated
            // 
            this.dateCreated.DataPropertyName = "DateCreated";
            this.dateCreated.HeaderText = "Date Created";
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            this.dateCreated.Width = 70;
            // 
            // dateFinished
            // 
            this.dateFinished.DataPropertyName = "DateFinished";
            this.dateFinished.HeaderText = "Date Finished";
            this.dateFinished.Name = "dateFinished";
            this.dateFinished.ReadOnly = true;
            this.dateFinished.Width = 70;
            // 
            // entryFee
            // 
            this.entryFee.DataPropertyName = "EntryFee";
            this.entryFee.HeaderText = "Entry Fee";
            this.entryFee.Name = "entryFee";
            this.entryFee.ReadOnly = true;
            this.entryFee.Width = 70;
            // 
            // tournamentMembers
            // 
            this.tournamentMembers.HeaderText = "Tourn. Members";
            this.tournamentMembers.Name = "tournamentMembers";
            this.tournamentMembers.ReadOnly = true;
            this.tournamentMembers.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tournamentMembers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tournamentMembers.Text = "Visualize";
            this.tournamentMembers.UseColumnTextForButtonValue = true;
            this.tournamentMembers.Width = 70;
            // 
            // winner
            // 
            this.winner.DataPropertyName = "Winner.TeamName;";
            this.winner.HeaderText = "Winner";
            this.winner.Name = "winner";
            this.winner.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TournamentsRatioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 537);
            this.Controls.Add(this.tournamentsRatioDataGridView);
            this.Controls.Add(this.winnerComboBox);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeComboBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.tournamentFilterGroupBox);
            this.Controls.Add(this.dateFilterGroupBox);
            this.Controls.Add(this.finalDateTimePicker);
            this.Controls.Add(this.finalDateLabel);
            this.Controls.Add(this.initialDateTimePicker);
            this.Controls.Add(this.initialDateLabel);
            this.Controls.Add(this.tournamentRatioLable);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentsRatioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TournamentsRatioForm";
            this.dateFilterGroupBox.ResumeLayout(false);
            this.dateFilterGroupBox.PerformLayout();
            this.tournamentFilterGroupBox.ResumeLayout(false);
            this.tournamentFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsRatioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentRatioLable;
        private System.Windows.Forms.Label initialDateLabel;
        private System.Windows.Forms.DateTimePicker initialDateTimePicker;
        private System.Windows.Forms.DateTimePicker finalDateTimePicker;
        private System.Windows.Forms.Label finalDateLabel;
        private System.Windows.Forms.GroupBox dateFilterGroupBox;
        private System.Windows.Forms.RadioButton dateFinishedRadioButton;
        private System.Windows.Forms.RadioButton dateCreatedRadioButton;
        private System.Windows.Forms.RadioButton finishedOnlyRadioButton;
        private System.Windows.Forms.RadioButton ongoingAndFinishedRadioButton;
        private System.Windows.Forms.GroupBox tournamentFilterGroupBox;
        private System.Windows.Forms.RadioButton ongoingOnlyRadioButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox entryFeeComboBox;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.ComboBox winnerComboBox;
        private System.Windows.Forms.DataGridView tournamentsRatioDataGridView;
        private System.Windows.Forms.BindingSource tournamentModelBindingSource;
        private System.Windows.Forms.BindingSource teamModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tournamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryFee;
        private System.Windows.Forms.DataGridViewButtonColumn tournamentMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn winner;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}