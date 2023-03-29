namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.AddNew = new System.Windows.Forms.GroupBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreateTeamLabel.Location = new System.Drawing.Point(38, 25);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(168, 40);
            this.CreateTeamLabel.TabIndex = 2;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(47, 114);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(205, 35);
            this.TeamNameTextBox.TabIndex = 15;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(38, 81);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(118, 30);
            this.TeamNameLabel.TabIndex = 14;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(38, 175);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(197, 30);
            this.SelectTeamMemberLabel.TabIndex = 16;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.Click += new System.EventHandler(this.TournamentNameLabel_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(47, 208);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(288, 38);
            this.SelectTeamMemberDropDown.TabIndex = 18;
            this.SelectTeamMemberDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamMemberDropDown_SelectedIndexChanged);
            // 
            // AddNew
            // 
            this.AddNew.Controls.Add(this.CreateMemberButton);
            this.AddNew.Controls.Add(this.CellPhoneTextBox);
            this.AddNew.Controls.Add(this.CellPhoneLabel);
            this.AddNew.Controls.Add(this.EmailTextBox);
            this.AddNew.Controls.Add(this.EmailLabel);
            this.AddNew.Controls.Add(this.LastNameTextBox);
            this.AddNew.Controls.Add(this.LastNameLabel);
            this.AddNew.Controls.Add(this.FirstNameTextBox);
            this.AddNew.Controls.Add(this.FirstNameLabel);
            this.AddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.AddNew.Location = new System.Drawing.Point(47, 375);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(401, 376);
            this.AddNew.TabIndex = 19;
            this.AddNew.TabStop = false;
            this.AddNew.Text = "Add New Member";
            this.AddNew.Enter += new System.EventHandler(this.AddNew_Enter);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(160, 60);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(205, 35);
            this.FirstNameTextBox.TabIndex = 17;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(35, 60);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(107, 30);
            this.FirstNameLabel.TabIndex = 16;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(159, 117);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(205, 35);
            this.LastNameTextBox.TabIndex = 19;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(35, 117);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(106, 30);
            this.LastNameLabel.TabIndex = 18;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(159, 173);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(205, 35);
            this.EmailTextBox.TabIndex = 21;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(35, 173);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 30);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "Email";
            // 
            // CellPhoneTextBox
            // 
            this.CellPhoneTextBox.Location = new System.Drawing.Point(159, 226);
            this.CellPhoneTextBox.Name = "CellPhoneTextBox";
            this.CellPhoneTextBox.Size = new System.Drawing.Size(205, 35);
            this.CellPhoneTextBox.TabIndex = 23;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CellPhoneLabel.Location = new System.Drawing.Point(35, 226);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(102, 30);
            this.CellPhoneLabel.TabIndex = 22;
            this.CellPhoneLabel.Text = "Cellphone";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(123, 280);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(229, 42);
            this.AddMemberButton.TabIndex = 28;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(85, 289);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(229, 42);
            this.CreateMemberButton.TabIndex = 29;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(508, 114);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(308, 634);
            this.TeamMembersListBox.TabIndex = 29;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(843, 432);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(147, 77);
            this.DeleteSelectedMemberButton.TabIndex = 30;
            this.DeleteSelectedMemberButton.Text = "Delete selected Member";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(361, 790);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(279, 47);
            this.CreateTeamButton.TabIndex = 31;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 866);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.AddNew.ResumeLayout(false);
            this.AddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreateTeamLabel;
        private TextBox TeamNameTextBox;
        private Label TeamNameLabel;
        private Label SelectTeamMemberLabel;
        private ComboBox SelectTeamMemberDropDown;
        private GroupBox AddNew;
        private TextBox FirstNameTextBox;
        private Label FirstNameLabel;
        private TextBox CellPhoneTextBox;
        private Label CellPhoneLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private Button CreateMemberButton;
        private Button AddMemberButton;
        private ListBox TeamMembersListBox;
        private Button DeleteSelectedMemberButton;
        private Button CreateTeamButton;
    }
}