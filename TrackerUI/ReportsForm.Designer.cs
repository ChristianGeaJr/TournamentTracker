namespace TrackerUI
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.tournamentsRatioButton = new System.Windows.Forms.Button();
            this.reportsLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentsRatioButton
            // 
            this.tournamentsRatioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentsRatioButton.Location = new System.Drawing.Point(32, 100);
            this.tournamentsRatioButton.Name = "tournamentsRatioButton";
            this.tournamentsRatioButton.Size = new System.Drawing.Size(353, 42);
            this.tournamentsRatioButton.TabIndex = 0;
            this.tournamentsRatioButton.Text = "Tournaments Ratio";
            this.tournamentsRatioButton.UseVisualStyleBackColor = true;
            this.tournamentsRatioButton.Click += new System.EventHandler(this.tournamentsRatioButton_Click);
            // 
            // reportsLable
            // 
            this.reportsLable.AutoSize = true;
            this.reportsLable.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLable.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.reportsLable.Location = new System.Drawing.Point(127, 23);
            this.reportsLable.Name = "reportsLable";
            this.reportsLable.Size = new System.Drawing.Size(143, 50);
            this.reportsLable.TabIndex = 12;
            this.reportsLable.Text = "Reports";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Relation of Something Else";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Relation of Something Else";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportsLable);
            this.Controls.Add(this.tournamentsRatioButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tournamentsRatioButton;
        private System.Windows.Forms.Label reportsLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}