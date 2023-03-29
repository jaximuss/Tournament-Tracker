namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.TournamentCreateLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeTextBox = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TeamsAndPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrizeslistBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentCreateLabel
            // 
            this.TournamentCreateLabel.AutoSize = true;
            this.TournamentCreateLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentCreateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TournamentCreateLabel.Location = new System.Drawing.Point(60, 28);
            this.TournamentCreateLabel.Name = "TournamentCreateLabel";
            this.TournamentCreateLabel.Size = new System.Drawing.Size(251, 40);
            this.TournamentCreateLabel.TabIndex = 1;
            this.TournamentCreateLabel.Text = "Create Tournament";
            this.TournamentCreateLabel.Click += new System.EventHandler(this.TournamentLabel_Click);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(60, 109);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(176, 30);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // TournamentNameTextBox
            // 
            this.TournamentNameTextBox.Location = new System.Drawing.Point(69, 142);
            this.TournamentNameTextBox.Name = "TournamentNameTextBox";
            this.TournamentNameTextBox.Size = new System.Drawing.Size(205, 35);
            this.TournamentNameTextBox.TabIndex = 13;
            // 
            // EntryFeeTextBox
            // 
            this.EntryFeeTextBox.Location = new System.Drawing.Point(172, 212);
            this.EntryFeeTextBox.Name = "EntryFeeTextBox";
            this.EntryFeeTextBox.Size = new System.Drawing.Size(102, 35);
            this.EntryFeeTextBox.TabIndex = 15;
            this.EntryFeeTextBox.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(69, 212);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(97, 30);
            this.EntryFeeLabel.TabIndex = 14;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(60, 316);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(288, 38);
            this.SelectTeamDropDown.TabIndex = 17;
            this.SelectTeamDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamDropDown_SelectedIndexChanged);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(60, 283);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(116, 30);
            this.SelectTeamLabel.TabIndex = 16;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(253, 283);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(169, 30);
            this.CreateNewTeamLink.TabIndex = 18;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(82, 398);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(229, 42);
            this.AddTeamButton.TabIndex = 19;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(82, 475);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(229, 42);
            this.CreatePrizeButton.TabIndex = 20;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(468, 109);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(308, 154);
            this.TournamentPlayersListBox.TabIndex = 21;
            // 
            // TeamsAndPlayersLabel
            // 
            this.TeamsAndPlayersLabel.AutoSize = true;
            this.TeamsAndPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamsAndPlayersLabel.Location = new System.Drawing.Point(468, 66);
            this.TeamsAndPlayersLabel.Name = "TeamsAndPlayersLabel";
            this.TeamsAndPlayersLabel.Size = new System.Drawing.Size(148, 30);
            this.TeamsAndPlayersLabel.TabIndex = 22;
            this.TeamsAndPlayersLabel.Text = "Teams / Players";
            // 
            // DeleteSelectedPlayerButton
            // 
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.DeleteSelectedPlayerButton.Location = new System.Drawing.Point(798, 142);
            this.DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            this.DeleteSelectedPlayerButton.Size = new System.Drawing.Size(147, 77);
            this.DeleteSelectedPlayerButton.TabIndex = 23;
            this.DeleteSelectedPlayerButton.Text = "Delete selected";
            this.DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(798, 475);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(147, 76);
            this.DeleteSelectedPrizeButton.TabIndex = 26;
            this.DeleteSelectedPrizeButton.Text = "Delete selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(468, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Prizes";
            // 
            // PrizeslistBox
            // 
            this.PrizeslistBox.FormattingEnabled = true;
            this.PrizeslistBox.ItemHeight = 30;
            this.PrizeslistBox.Location = new System.Drawing.Point(468, 431);
            this.PrizeslistBox.Name = "PrizeslistBox";
            this.PrizeslistBox.Size = new System.Drawing.Size(308, 154);
            this.PrizeslistBox.TabIndex = 24;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(388, 614);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(229, 42);
            this.CreateTournamentButton.TabIndex = 27;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 707);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrizeslistBox);
            this.Controls.Add(this.DeleteSelectedPlayerButton);
            this.Controls.Add(this.TeamsAndPlayersLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeTextBox);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameTextBox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.TournamentCreateLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TournamentCreateLabel;
        private Label TournamentNameLabel;
        private TextBox TournamentNameTextBox;
        private TextBox EntryFeeTextBox;
        private Label EntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayersListBox;
        private Label TeamsAndPlayersLabel;
        private Button DeleteSelectedPlayerButton;
        private Button DeleteSelectedPrizeButton;
        private Label label1;
        private ListBox PrizeslistBox;
        private Button CreateTournamentButton;
    }
}