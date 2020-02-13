namespace TrackerUI
{
    partial class TournamentGraphicViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentGraphicViewForm));
            this.reportsLable = new System.Windows.Forms.Label();
            this.tournamentComboBox = new System.Windows.Forms.ComboBox();
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.TesteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportsLable
            // 
            this.reportsLable.AutoSize = true;
            this.reportsLable.BackColor = System.Drawing.Color.Transparent;
            this.reportsLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.reportsLable.Location = new System.Drawing.Point(96, 9);
            this.reportsLable.Name = "reportsLable";
            this.reportsLable.Size = new System.Drawing.Size(460, 50);
            this.reportsLable.TabIndex = 13;
            this.reportsLable.Text = "Tournaments Graphical View";
            // 
            // tournamentComboBox
            // 
            this.tournamentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tournamentComboBox.FormattingEnabled = true;
            this.tournamentComboBox.Location = new System.Drawing.Point(222, 87);
            this.tournamentComboBox.Name = "tournamentComboBox";
            this.tournamentComboBox.Size = new System.Drawing.Size(217, 29);
            this.tournamentComboBox.TabIndex = 29;
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(103, 87);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(113, 25);
            this.tournamentLabel.TabIndex = 28;
            this.tournamentLabel.Text = "Tournament";
            // 
            // generateButton
            // 
            this.generateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.generateButton.Location = new System.Drawing.Point(476, 77);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(116, 43);
            this.generateButton.TabIndex = 30;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // TesteLabel
            // 
            this.TesteLabel.AutoSize = true;
            this.TesteLabel.BackColor = System.Drawing.Color.White;
            this.TesteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TesteLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TesteLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesteLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TesteLabel.Location = new System.Drawing.Point(621, 78);
            this.TesteLabel.Name = "TesteLabel";
            this.TesteLabel.Size = new System.Drawing.Size(96, 42);
            this.TesteLabel.TabIndex = 31;
            this.TesteLabel.Text = "label1";
            // 
            // TournamentGraphicViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 657);
            this.Controls.Add(this.TesteLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.tournamentComboBox);
            this.Controls.Add(this.tournamentLabel);
            this.Controls.Add(this.reportsLable);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentGraphicViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TournamentGraphicViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportsLable;
        private System.Windows.Forms.ComboBox tournamentComboBox;
        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label TesteLabel;
    }
}