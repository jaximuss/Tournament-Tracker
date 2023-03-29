namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.CurrentTournamrntLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.TeamOneLabel = new System.Windows.Forms.Label();
            this.TeamOneScore = new System.Windows.Forms.Label();
            this.TeamTwoScore = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.RoundComboBox = new System.Windows.Forms.ComboBox();
            this.UnplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.TeamScoreOneTextBox = new System.Windows.Forms.TextBox();
            this.TeamScoreTwoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TournamentLabel.Location = new System.Drawing.Point(34, 46);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(169, 40);
            this.TournamentLabel.TabIndex = 0;
            this.TournamentLabel.Text = "Tournament:";
            // 
            // CurrentTournamrntLabel
            // 
            this.CurrentTournamrntLabel.AutoSize = true;
            this.CurrentTournamrntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.CurrentTournamrntLabel.Location = new System.Drawing.Point(209, 46);
            this.CurrentTournamrntLabel.Name = "CurrentTournamrntLabel";
            this.CurrentTournamrntLabel.Size = new System.Drawing.Size(118, 40);
            this.CurrentTournamrntLabel.TabIndex = 1;
            this.CurrentTournamrntLabel.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(34, 122);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(97, 40);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamTwoLabel.Location = new System.Drawing.Point(481, 573);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(170, 40);
            this.TeamTwoLabel.TabIndex = 3;
            this.TeamTwoLabel.Text = "<team two>";
            // 
            // TeamOneLabel
            // 
            this.TeamOneLabel.AutoSize = true;
            this.TeamOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamOneLabel.Location = new System.Drawing.Point(483, 346);
            this.TeamOneLabel.Name = "TeamOneLabel";
            this.TeamOneLabel.Size = new System.Drawing.Size(172, 40);
            this.TeamOneLabel.TabIndex = 4;
            this.TeamOneLabel.Text = "<team one>";
            // 
            // TeamOneScore
            // 
            this.TeamOneScore.AutoSize = true;
            this.TeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamOneScore.Location = new System.Drawing.Point(481, 408);
            this.TeamOneScore.Name = "TeamOneScore";
            this.TeamOneScore.Size = new System.Drawing.Size(81, 40);
            this.TeamOneScore.TabIndex = 5;
            this.TeamOneScore.Text = "score";
            this.TeamOneScore.Click += new System.EventHandler(this.label4_Click);
            // 
            // TeamTwoScore
            // 
            this.TeamTwoScore.AutoSize = true;
            this.TeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.TeamTwoScore.Location = new System.Drawing.Point(483, 632);
            this.TeamTwoScore.Name = "TeamTwoScore";
            this.TeamTwoScore.Size = new System.Drawing.Size(81, 40);
            this.TeamTwoScore.TabIndex = 6;
            this.TeamTwoScore.Text = "score";
            this.TeamTwoScore.Click += new System.EventHandler(this.label5_Click);
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.VersusLabel.Location = new System.Drawing.Point(549, 498);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(72, 40);
            this.VersusLabel.TabIndex = 7;
            this.VersusLabel.Text = "-VS-";
            // 
            // RoundComboBox
            // 
            this.RoundComboBox.FormattingEnabled = true;
            this.RoundComboBox.Location = new System.Drawing.Point(159, 119);
            this.RoundComboBox.Name = "RoundComboBox";
            this.RoundComboBox.Size = new System.Drawing.Size(288, 48);
            this.RoundComboBox.TabIndex = 8;
            // 
            // UnplayedCheckBox
            // 
            this.UnplayedCheckBox.AutoSize = true;
            this.UnplayedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.UnplayedCheckBox.Location = new System.Drawing.Point(117, 202);
            this.UnplayedCheckBox.Name = "UnplayedCheckBox";
            this.UnplayedCheckBox.Size = new System.Drawing.Size(213, 44);
            this.UnplayedCheckBox.TabIndex = 9;
            this.UnplayedCheckBox.Text = "Unplayed Only";
            this.UnplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 40;
            this.MatchUpListBox.Location = new System.Drawing.Point(51, 281);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(323, 404);
            this.MatchUpListBox.TabIndex = 10;
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(811, 473);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(155, 65);
            this.ScoreButton.TabIndex = 11;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TeamScoreOneTextBox
            // 
            this.TeamScoreOneTextBox.Location = new System.Drawing.Point(597, 402);
            this.TeamScoreOneTextBox.Name = "TeamScoreOneTextBox";
            this.TeamScoreOneTextBox.Size = new System.Drawing.Size(178, 46);
            this.TeamScoreOneTextBox.TabIndex = 12;
            this.TeamScoreOneTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamScoreTwoTextBox
            // 
            this.TeamScoreTwoTextBox.Location = new System.Drawing.Point(597, 629);
            this.TeamScoreTwoTextBox.Name = "TeamScoreTwoTextBox";
            this.TeamScoreTwoTextBox.Size = new System.Drawing.Size(178, 46);
            this.TeamScoreTwoTextBox.TabIndex = 13;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 754);
            this.Controls.Add(this.TeamScoreTwoTextBox);
            this.Controls.Add(this.TeamScoreOneTextBox);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.UnplayedCheckBox);
            this.Controls.Add(this.RoundComboBox);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScore);
            this.Controls.Add(this.TeamOneScore);
            this.Controls.Add(this.TeamOneLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.CurrentTournamrntLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TournamentLabel;
        private Label CurrentTournamrntLabel;
        private Label RoundLabel;
        private Label TeamTwoLabel;
        private Label TeamOneLabel;
        private Label TeamOneScore;
        private Label TeamTwoScore;
        private Label VersusLabel;
        private ComboBox RoundComboBox;
        private CheckBox UnplayedCheckBox;
        private ListBox MatchUpListBox;
        private Button ScoreButton;
        private TextBox TeamScoreOneTextBox;
        private TextBox TeamScoreTwoTextBox;
    }
}