namespace TrackerUI
{
    partial class InitialSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSettingsForm));
            this.initialSettingsLable = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sqlRadioButton = new System.Windows.Forms.RadioButton();
            this.textFileRadioButton = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.DataConnectionTypeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.browseButton = new System.Windows.Forms.Button();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.Back1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ok1Button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back2Button = new System.Windows.Forms.Button();
            this.ok2Button = new System.Windows.Forms.Button();
            this.CoverLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // initialSettingsLable
            // 
            this.initialSettingsLable.AutoSize = true;
            this.initialSettingsLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialSettingsLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.initialSettingsLable.Location = new System.Drawing.Point(106, 9);
            this.initialSettingsLable.Name = "initialSettingsLable";
            this.initialSettingsLable.Size = new System.Drawing.Size(185, 37);
            this.initialSettingsLable.TabIndex = 14;
            this.initialSettingsLable.Text = "Initial Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 185);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sqlRadioButton);
            this.tabPage1.Controls.Add(this.textFileRadioButton);
            this.tabPage1.Controls.Add(this.nextButton);
            this.tabPage1.Controls.Add(this.DataConnectionTypeLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 159);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sqlRadioButton
            // 
            this.sqlRadioButton.AutoSize = true;
            this.sqlRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlRadioButton.Location = new System.Drawing.Point(190, 76);
            this.sqlRadioButton.Name = "sqlRadioButton";
            this.sqlRadioButton.Size = new System.Drawing.Size(110, 25);
            this.sqlRadioButton.TabIndex = 20;
            this.sqlRadioButton.TabStop = true;
            this.sqlRadioButton.Text = "SQL Server";
            this.sqlRadioButton.UseVisualStyleBackColor = true;
            // 
            // textFileRadioButton
            // 
            this.textFileRadioButton.AutoSize = true;
            this.textFileRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileRadioButton.Location = new System.Drawing.Point(59, 76);
            this.textFileRadioButton.Name = "textFileRadioButton";
            this.textFileRadioButton.Size = new System.Drawing.Size(87, 25);
            this.textFileRadioButton.TabIndex = 19;
            this.textFileRadioButton.TabStop = true;
            this.textFileRadioButton.Text = "TextFile";
            this.textFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(274, 125);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 18;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // DataConnectionTypeLabel
            // 
            this.DataConnectionTypeLabel.AutoSize = true;
            this.DataConnectionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataConnectionTypeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DataConnectionTypeLabel.Location = new System.Drawing.Point(39, 15);
            this.DataConnectionTypeLabel.Name = "DataConnectionTypeLabel";
            this.DataConnectionTypeLabel.Size = new System.Drawing.Size(279, 37);
            this.DataConnectionTypeLabel.TabIndex = 17;
            this.DataConnectionTypeLabel.Text = "Data Connection Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.browseButton);
            this.tabPage2.Controls.Add(this.FolderPathTextBox);
            this.tabPage2.Controls.Add(this.Back1Button);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ok1Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 159);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(274, 64);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 23;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(23, 66);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(230, 20);
            this.FolderPathTextBox.TabIndex = 22;
            // 
            // Back1Button
            // 
            this.Back1Button.Location = new System.Drawing.Point(23, 125);
            this.Back1Button.Name = "Back1Button";
            this.Back1Button.Size = new System.Drawing.Size(75, 23);
            this.Back1Button.TabIndex = 21;
            this.Back1Button.Text = "<< Back";
            this.Back1Button.UseVisualStyleBackColor = true;
            this.Back1Button.Click += new System.EventHandler(this.Back1Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose the Text Files Location";
            // 
            // ok1Button
            // 
            this.ok1Button.Location = new System.Drawing.Point(274, 125);
            this.ok1Button.Name = "ok1Button";
            this.ok1Button.Size = new System.Drawing.Size(75, 23);
            this.ok1Button.TabIndex = 19;
            this.ok1Button.Text = "OK";
            this.ok1Button.UseVisualStyleBackColor = true;
            this.ok1Button.Click += new System.EventHandler(this.ok1Button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.databaseTextBox);
            this.tabPage3.Controls.Add(this.databaseLabel);
            this.tabPage3.Controls.Add(this.testConnectionButton);
            this.tabPage3.Controls.Add(this.serverTextBox);
            this.tabPage3.Controls.Add(this.serverLabel);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.back2Button);
            this.tabPage3.Controls.Add(this.ok2Button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(380, 159);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Enabled = false;
            this.databaseTextBox.Location = new System.Drawing.Point(89, 70);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(158, 20);
            this.databaseTextBox.TabIndex = 33;
            this.databaseTextBox.Text = "Tournaments";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.databaseLabel.Location = new System.Drawing.Point(14, 69);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(74, 21);
            this.databaseLabel.TabIndex = 32;
            this.databaseLabel.Text = "Database";
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(274, 39);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(75, 46);
            this.testConnectionButton.TabIndex = 31;
            this.testConnectionButton.Text = "Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Enabled = false;
            this.serverTextBox.Location = new System.Drawing.Point(89, 39);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(158, 20);
            this.serverTextBox.TabIndex = 28;
            this.serverTextBox.Text = "127.0.0.1";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.serverLabel.Location = new System.Drawing.Point(19, 39);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(55, 21);
            this.serverLabel.TabIndex = 25;
            this.serverLabel.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(74, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Set the SQL Connection data";
            // 
            // back2Button
            // 
            this.back2Button.Location = new System.Drawing.Point(23, 125);
            this.back2Button.Name = "back2Button";
            this.back2Button.Size = new System.Drawing.Size(75, 23);
            this.back2Button.TabIndex = 23;
            this.back2Button.Text = "<< Back";
            this.back2Button.UseVisualStyleBackColor = true;
            this.back2Button.Click += new System.EventHandler(this.back2Button_Click);
            // 
            // ok2Button
            // 
            this.ok2Button.Enabled = false;
            this.ok2Button.Location = new System.Drawing.Point(274, 125);
            this.ok2Button.Name = "ok2Button";
            this.ok2Button.Size = new System.Drawing.Size(75, 23);
            this.ok2Button.TabIndex = 22;
            this.ok2Button.Text = "OK";
            this.ok2Button.UseVisualStyleBackColor = true;
            this.ok2Button.Click += new System.EventHandler(this.ok2Button_Click);
            // 
            // CoverLabel
            // 
            this.CoverLabel.AutoSize = true;
            this.CoverLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoverLabel.Location = new System.Drawing.Point(14, 48);
            this.CoverLabel.Name = "CoverLabel";
            this.CoverLabel.Size = new System.Drawing.Size(250, 21);
            this.CoverLabel.TabIndex = 16;
            this.CoverLabel.Text = "                                                            ";
            // 
            // InitialSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 245);
            this.Controls.Add(this.CoverLabel);
            this.Controls.Add(this.initialSettingsLable);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitialSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Settings";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialSettingsLable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton sqlRadioButton;
        private System.Windows.Forms.RadioButton textFileRadioButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label DataConnectionTypeLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Button Back1Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok1Button;
        private System.Windows.Forms.Label CoverLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button back2Button;
        private System.Windows.Forms.Button ok2Button;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.Label databaseLabel;
    }
}