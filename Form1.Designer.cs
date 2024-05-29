namespace Lab_25_Danylko
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtPhotoId = new System.Windows.Forms.TextBox();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.comboBoxPlayerTeams = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.comboBoxMatchTeam1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMatchTeam2 = new System.Windows.Forms.ComboBox();
            this.txtScoreTeam1 = new System.Windows.Forms.TextBox();
            this.txtScoreTeam2 = new System.Windows.Forms.TextBox();
            this.txtMatchDate = new System.Windows.Forms.TextBox();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.radioButtonTeams = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayers = new System.Windows.Forms.RadioButton();
            this.radioButtonMatches = new System.Windows.Forms.RadioButton();
            this.comboBoxTeams = new System.Windows.Forms.ComboBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblPhotoId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTeamName.Location = new System.Drawing.Point(29, 72);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(200, 30);
            this.txtTeamName.TabIndex = 0;
            // 
            // txtPhotoId
            // 
            this.txtPhotoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhotoId.Location = new System.Drawing.Point(29, 127);
            this.txtPhotoId.Name = "txtPhotoId";
            this.txtPhotoId.Size = new System.Drawing.Size(200, 30);
            this.txtPhotoId.TabIndex = 1;
            // 
            // btnBrowsePhoto
            // 
            this.btnBrowsePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowsePhoto.Location = new System.Drawing.Point(235, 126);
            this.btnBrowsePhoto.Name = "btnBrowsePhoto";
            this.btnBrowsePhoto.Size = new System.Drawing.Size(75, 28);
            this.btnBrowsePhoto.TabIndex = 2;
            this.btnBrowsePhoto.Text = "Пошук";
            this.btnBrowsePhoto.UseVisualStyleBackColor = true;
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTeam.Location = new System.Drawing.Point(70, 166);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(145, 41);
            this.btnAddTeam.TabIndex = 3;
            this.btnAddTeam.Text = "Додати команду";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPlayerName.Location = new System.Drawing.Point(386, 86);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(200, 30);
            this.txtPlayerName.TabIndex = 4;
            // 
            // comboBoxPlayerTeams
            // 
            this.comboBoxPlayerTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayerTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPlayerTeams.FormattingEnabled = true;
            this.comboBoxPlayerTeams.Location = new System.Drawing.Point(385, 139);
            this.comboBoxPlayerTeams.Name = "comboBoxPlayerTeams";
            this.comboBoxPlayerTeams.Size = new System.Drawing.Size(200, 33);
            this.comboBoxPlayerTeams.TabIndex = 5;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddPlayer.Location = new System.Drawing.Point(414, 173);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(148, 43);
            this.btnAddPlayer.TabIndex = 6;
            this.btnAddPlayer.Text = "Додати гравця";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // comboBoxMatchTeam1
            // 
            this.comboBoxMatchTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatchTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMatchTeam1.FormattingEnabled = true;
            this.comboBoxMatchTeam1.Location = new System.Drawing.Point(29, 285);
            this.comboBoxMatchTeam1.Name = "comboBoxMatchTeam1";
            this.comboBoxMatchTeam1.Size = new System.Drawing.Size(200, 33);
            this.comboBoxMatchTeam1.TabIndex = 7;
            // 
            // comboBoxMatchTeam2
            // 
            this.comboBoxMatchTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatchTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMatchTeam2.FormattingEnabled = true;
            this.comboBoxMatchTeam2.Location = new System.Drawing.Point(29, 343);
            this.comboBoxMatchTeam2.Name = "comboBoxMatchTeam2";
            this.comboBoxMatchTeam2.Size = new System.Drawing.Size(200, 33);
            this.comboBoxMatchTeam2.TabIndex = 8;
            // 
            // txtScoreTeam1
            // 
            this.txtScoreTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScoreTeam1.Location = new System.Drawing.Point(161, 397);
            this.txtScoreTeam1.Name = "txtScoreTeam1";
            this.txtScoreTeam1.Size = new System.Drawing.Size(41, 30);
            this.txtScoreTeam1.TabIndex = 9;
            // 
            // txtScoreTeam2
            // 
            this.txtScoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScoreTeam2.Location = new System.Drawing.Point(233, 397);
            this.txtScoreTeam2.Name = "txtScoreTeam2";
            this.txtScoreTeam2.Size = new System.Drawing.Size(42, 30);
            this.txtScoreTeam2.TabIndex = 10;
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMatchDate.Location = new System.Drawing.Point(29, 458);
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(200, 30);
            this.txtMatchDate.TabIndex = 11;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMatch.Location = new System.Drawing.Point(61, 490);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(141, 45);
            this.btnAddMatch.TabIndex = 12;
            this.btnAddMatch.Text = "Додати матч";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // listBoxReports
            // 
            this.listBoxReports.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.Location = new System.Drawing.Point(314, 253);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(456, 199);
            this.listBoxReports.TabIndex = 13;
            this.listBoxReports.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxReports_DrawItem);
            this.listBoxReports.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxReports_MeasureItem);
            // 
            // radioButtonTeams
            // 
            this.radioButtonTeams.AutoSize = true;
            this.radioButtonTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTeams.Location = new System.Drawing.Point(314, 460);
            this.radioButtonTeams.Name = "radioButtonTeams";
            this.radioButtonTeams.Size = new System.Drawing.Size(117, 29);
            this.radioButtonTeams.TabIndex = 14;
            this.radioButtonTeams.TabStop = true;
            this.radioButtonTeams.Text = "Команди";
            this.radioButtonTeams.UseVisualStyleBackColor = true;
            this.radioButtonTeams.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPlayers
            // 
            this.radioButtonPlayers.AutoSize = true;
            this.radioButtonPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPlayers.Location = new System.Drawing.Point(314, 490);
            this.radioButtonPlayers.Name = "radioButtonPlayers";
            this.radioButtonPlayers.Size = new System.Drawing.Size(92, 29);
            this.radioButtonPlayers.TabIndex = 15;
            this.radioButtonPlayers.TabStop = true;
            this.radioButtonPlayers.Text = "Гравці";
            this.radioButtonPlayers.UseVisualStyleBackColor = true;
            this.radioButtonPlayers.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonMatches
            // 
            this.radioButtonMatches.AutoSize = true;
            this.radioButtonMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMatches.Location = new System.Drawing.Point(314, 524);
            this.radioButtonMatches.Name = "radioButtonMatches";
            this.radioButtonMatches.Size = new System.Drawing.Size(86, 29);
            this.radioButtonMatches.TabIndex = 16;
            this.radioButtonMatches.TabStop = true;
            this.radioButtonMatches.Text = "Матчі";
            this.radioButtonMatches.UseVisualStyleBackColor = true;
            this.radioButtonMatches.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // comboBoxTeams
            // 
            this.comboBoxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTeams.FormattingEnabled = true;
            this.comboBoxTeams.Location = new System.Drawing.Point(398, 490);
            this.comboBoxTeams.Name = "comboBoxTeams";
            this.comboBoxTeams.Size = new System.Drawing.Size(200, 33);
            this.comboBoxTeams.TabIndex = 17;
            this.comboBoxTeams.Visible = false;
            this.comboBoxTeams.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeams_SelectedIndexChanged);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeamName.Location = new System.Drawing.Point(25, 49);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(232, 25);
            this.lblTeamName.TabIndex = 18;
            this.lblTeamName.Text = "Введіть назву команди:";
            // 
            // lblPhotoId
            // 
            this.lblPhotoId.AutoSize = true;
            this.lblPhotoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhotoId.Location = new System.Drawing.Point(26, 101);
            this.lblPhotoId.Name = "lblPhotoId";
            this.lblPhotoId.Size = new System.Drawing.Size(160, 25);
            this.lblPhotoId.TabIndex = 19;
            this.lblPhotoId.Text = "Додайте фото:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(448, 537);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 55);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(382, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введіть ім\'я гравця:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(382, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Виберіть команду:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Виберіть команду 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Виберіть команду 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(208, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Введіть час:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Введіть дату:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(808, 632);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPhotoId);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.comboBoxTeams);
            this.Controls.Add(this.radioButtonMatches);
            this.Controls.Add(this.radioButtonPlayers);
            this.Controls.Add(this.radioButtonTeams);
            this.Controls.Add(this.listBoxReports);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.txtMatchDate);
            this.Controls.Add(this.txtScoreTeam2);
            this.Controls.Add(this.txtScoreTeam1);
            this.Controls.Add(this.comboBoxMatchTeam2);
            this.Controls.Add(this.comboBoxMatchTeam1);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.comboBoxPlayerTeams);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnBrowsePhoto);
            this.Controls.Add(this.txtPhotoId);
            this.Controls.Add(this.txtTeamName);
            this.Name = "Form1";
            this.Text = "Football Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtPhotoId;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ComboBox comboBoxPlayerTeams;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ComboBox comboBoxMatchTeam1;
        private System.Windows.Forms.ComboBox comboBoxMatchTeam2;
        private System.Windows.Forms.TextBox txtScoreTeam1;
        private System.Windows.Forms.TextBox txtScoreTeam2;
        private System.Windows.Forms.TextBox txtMatchDate;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.RadioButton radioButtonTeams;
        private System.Windows.Forms.RadioButton radioButtonPlayers;
        private System.Windows.Forms.RadioButton radioButtonMatches;
        private System.Windows.Forms.ComboBox comboBoxTeams;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblPhotoId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}