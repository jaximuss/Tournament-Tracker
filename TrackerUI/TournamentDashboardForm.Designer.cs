namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SelectTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            this.TournamentDashboardLabel.AutoSize = true;
            this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TournamentDashboardLabel.Location = new System.Drawing.Point(149, 54);
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Size = new System.Drawing.Size(303, 40);
            this.TournamentDashboardLabel.TabIndex = 31;
            this.TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(177, 335);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(247, 91);
            this.CreateTournamentButton.TabIndex = 33;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LoadButton.Location = new System.Drawing.Point(194, 255);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(212, 47);
            this.LoadButton.TabIndex = 34;
            this.LoadButton.Text = "Load Tournament";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // SelectTournamentDropdown
            // 
            this.SelectTournamentDropdown.FormattingEnabled = true;
            this.SelectTournamentDropdown.Location = new System.Drawing.Point(90, 192);
            this.SelectTournamentDropdown.Name = "SelectTournamentDropdown";
            this.SelectTournamentDropdown.Size = new System.Drawing.Size(420, 38);
            this.SelectTournamentDropdown.TabIndex = 35;
            this.SelectTournamentDropdown.Text = " ";
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(132, 138);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(337, 40);
            this.LoadExistingTournamentLabel.TabIndex = 36;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament ";
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 484);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.SelectTournamentDropdown);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TournamentDashboardLabel;
        private Button CreateTournamentButton;
        private Button LoadButton;
        private ComboBox SelectTournamentDropdown;
        private Label LoadExistingTournamentLabel;
    }
}