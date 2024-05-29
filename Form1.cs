using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab_25_Danylko
{
    public partial class Form1 : Form
    {
        private Database db;

        public Form1()
        {
            InitializeComponent();
            db = new Database();
            db.OpenConnection();
            db.CreateTables();
            LoadTeams();
        }

        private void LoadTeams()
        {
            comboBoxPlayerTeams.Items.Clear();
            comboBoxMatchTeam1.Items.Clear();
            comboBoxMatchTeam2.Items.Clear();
            comboBoxTeams.Items.Clear();

            string query = "SELECT * FROM Teams ORDER BY team_id";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string teamName = reader["team_name"].ToString();
                    int teamId = Convert.ToInt32(reader["team_id"]);
                    comboBoxPlayerTeams.Items.Add(new ComboBoxItem(teamName, teamId));
                    comboBoxMatchTeam1.Items.Add(new ComboBoxItem(teamName, teamId));
                    comboBoxMatchTeam2.Items.Add(new ComboBoxItem(teamName, teamId));
                    comboBoxTeams.Items.Add(new ComboBoxItem(teamName, teamId));
                }
            }
            UpdateReports();
        }

        private void btnBrowsePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPhotoId.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamName.Text) || string.IsNullOrEmpty(txtPhotoId.Text))
            {
                MessageBox.Show("Введіть назву команди та виберіть фото.");
                return;
            }

            string teamName = txtTeamName.Text;
            string photoId = txtPhotoId.Text;

            // Check for duplicate team name
            string checkQuery = "SELECT COUNT(*) FROM Teams WHERE team_name = @team_name";
            using (var cmd = new SQLiteCommand(checkQuery, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@team_name", teamName);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Команда з такою назвою вже існує.");
                    return;
                }
            }

            int teamId = db.GetNextAvailableId("Teams", "team_id");

            string query = "INSERT INTO Teams (team_id, team_name, photo_id) VALUES (@team_id, @team_name, @photo_id)";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@team_id", teamId);
                cmd.Parameters.AddWithValue("@team_name", teamName);
                cmd.Parameters.AddWithValue("@photo_id", photoId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Команда додана!");
            LoadTeams();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerName.Text) || comboBoxPlayerTeams.SelectedItem == null)
            {
                MessageBox.Show("Введіть ім'я гравця і виберіть команду!");
                return;
            }

            string playerName = txtPlayerName.Text;
            ComboBoxItem selectedTeam = (ComboBoxItem)comboBoxPlayerTeams.SelectedItem;

            // Check for duplicate player name in the same team
            string checkQuery = "SELECT COUNT(*) FROM Players WHERE player_name = @player_name AND team_id = @team_id";
            using (var cmd = new SQLiteCommand(checkQuery, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@player_name", playerName);
                cmd.Parameters.AddWithValue("@team_id", selectedTeam.Value);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Гравця з таким ім'ям вже було додано до цієї команди!");
                    return;
                }
            }

            int playerId = db.GetNextAvailableId("Players", "player_id");

            string query = "INSERT INTO Players (player_id, player_name, team_id) VALUES (@player_id, @player_name, @team_id)";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@player_id", playerId);
                cmd.Parameters.AddWithValue("@player_name", playerName);
                cmd.Parameters.AddWithValue("@team_id", selectedTeam.Value);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Гравець доданий!");
            UpdateReports();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (comboBoxMatchTeam1.SelectedItem == null || comboBoxMatchTeam2.SelectedItem == null ||
                string.IsNullOrEmpty(txtScoreTeam1.Text) || string.IsNullOrEmpty(txtScoreTeam2.Text) ||
                string.IsNullOrEmpty(txtMatchDate.Text))
            {
                MessageBox.Show("Заповніть всі поля даних про матч!");
                return;
            }

            ComboBoxItem team1 = (ComboBoxItem)comboBoxMatchTeam1.SelectedItem;
            ComboBoxItem team2 = (ComboBoxItem)comboBoxMatchTeam2.SelectedItem;
            int scoreTeam1 = int.Parse(txtScoreTeam1.Text);
            int scoreTeam2 = int.Parse(txtScoreTeam2.Text);
            string matchDate = txtMatchDate.Text;

            // Check for duplicate match
            string checkQuery = "SELECT COUNT(*) FROM Matches WHERE team1_id = @team1_id AND team2_id = @team2_id AND match_date = @match_date";
            using (var cmd = new SQLiteCommand(checkQuery, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@team1_id", team1.Value);
                cmd.Parameters.AddWithValue("@team2_id", team2.Value);
                cmd.Parameters.AddWithValue("@match_date", matchDate);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Матч з обраними командами і датою вже існує.");
                    return;
                }
            }

            int matchId = db.GetNextAvailableId("Matches", "match_id");

            string query = "INSERT INTO Matches (match_id, team1_id, team2_id, score_team1, score_team2, match_date) VALUES (@match_id, @team1_id, @team2_id, @score_team1, @score_team2, @match_date)";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@match_id", matchId);
                cmd.Parameters.AddWithValue("@team1_id", team1.Value);
                cmd.Parameters.AddWithValue("@team2_id", team2.Value);
                cmd.Parameters.AddWithValue("@score_team1", scoreTeam1);
                cmd.Parameters.AddWithValue("@score_team2", scoreTeam2);
                cmd.Parameters.AddWithValue("@match_date", matchDate);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Матч доданий!");
            UpdateReports();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxReports.SelectedItem == null)
            {
                MessageBox.Show("Виберіть об'єкт видалення.");
                return;
            }

            ListBoxItem selectedItem = (ListBoxItem)listBoxReports.SelectedItem;
            string query = string.Empty;

            if (radioButtonTeams.Checked)
            {
                // Получаем идентификатор команды из строки
                int id = int.Parse(selectedItem.Text.Split(':')[0]);

                // Удаляем все матчи, связанные с командой
                string deleteMatchesQuery = "DELETE FROM Matches WHERE team1_id = @id OR team2_id = @id";
                using (var cmd = new SQLiteCommand(deleteMatchesQuery, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                query = "DELETE FROM Teams WHERE team_id = @id";
                using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record deleted!");
            }
            else if (radioButtonPlayers.Checked)
            {
                // Получаем имя игрока из строки
                string playerName = selectedItem.Text;

                // Получаем идентификатор команды из выбранного элемента в ComboBox
                ComboBoxItem selectedTeam = (ComboBoxItem)comboBoxTeams.SelectedItem;
                int teamId = selectedTeam.Value;

                // Удаляем игрока по имени и идентификатору команды
                query = "DELETE FROM Players WHERE player_name = @player_name AND team_id = @team_id";
                using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@player_name", playerName);
                    cmd.Parameters.AddWithValue("@team_id", teamId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Player deleted!");
            }
            else if (radioButtonMatches.Checked)
            {
                // Получаем идентификатор матча из строки
                int id = int.Parse(selectedItem.Text.Split(':')[0]);

                query = "DELETE FROM Matches WHERE match_id = @id";
                using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Запис видалено!");
            }

            UpdateReports();
        }

        private void UpdateReports()
        {
            listBoxReports.Items.Clear();
            if (radioButtonTeams.Checked)
            {
                string query = "SELECT * FROM Teams";
                using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string teamName = reader["team_name"].ToString();
                        string photoId = reader["photo_id"].ToString();
                        listBoxReports.Items.Add(new ListBoxItem($"{reader["team_id"]}: {teamName}", photoId));
                    }
                }
            }
            else if (radioButtonPlayers.Checked)
            {
                comboBoxTeams.Visible = true;
                if (comboBoxTeams.SelectedItem != null)
                {
                    ComboBoxItem selectedTeam = (ComboBoxItem)comboBoxTeams.SelectedItem;
                    string query = "SELECT * FROM Players WHERE team_id = @team_id";
                    using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@team_id", selectedTeam.Value);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBoxReports.Items.Add(new ListBoxItem($"{reader["player_name"]}", null));
                            }
                        }
                    }
                }
            }
            else if (radioButtonMatches.Checked)
            {
                string query = "SELECT * FROM Matches";
                using (var cmd = new SQLiteCommand(query, db.GetConnection()))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int team1Id = Convert.ToInt32(reader["team1_id"]);
                        int team2Id = Convert.ToInt32(reader["team2_id"]);
                        string team1Name = GetTeamNameById(team1Id);
                        string team2Name = GetTeamNameById(team2Id);
                        string photoId1 = GetPhotoIdById(team1Id);
                        string photoId2 = GetPhotoIdById(team2Id);
                        listBoxReports.Items.Add(new ListBoxItem($"{reader["match_id"]}: {team1Name} vs {team2Name} - {reader["score_team1"]}:{reader["score_team2"]} о {reader["match_date"]}", photoId1, photoId2));
                    }
                }
            }
        }

        private string GetTeamNameById(int teamId)
        {
            string query = "SELECT team_name FROM Teams WHERE team_id = @team_id";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@team_id", teamId);
                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }

        private string GetPhotoIdById(int teamId)
        {
            string query = "SELECT photo_id FROM Teams WHERE team_id = @team_id";
            using (var cmd = new SQLiteCommand(query, db.GetConnection()))
            {
                cmd.Parameters.AddWithValue("@team_id", teamId);
                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTeams.Visible = radioButtonPlayers.Checked;
            UpdateReports();
        }

        private void comboBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayers.Checked)
            {
                UpdateReports();
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; }
            public int Value { get; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private class ListBoxItem
        {
            public string Text { get; }
            public string PhotoId1 { get; }
            public string PhotoId2 { get; }

            public ListBoxItem(string text, string photoId1, string photoId2 = null)
            {
                Text = text;
                PhotoId1 = photoId1;
                PhotoId2 = photoId2;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void listBoxReports_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            var item = (ListBoxItem)listBoxReports.Items[e.Index];
            e.Graphics.DrawString(item.Text, e.Font, Brushes.Black, e.Bounds);

            if (!string.IsNullOrEmpty(item.PhotoId1) && File.Exists(item.PhotoId1))
            {
                Image img = Image.FromFile(item.PhotoId1);
                e.Graphics.DrawImage(img, new Rectangle(e.Bounds.Right - 50, e.Bounds.Top, 50, 50));
            }

            if (!string.IsNullOrEmpty(item.PhotoId2) && File.Exists(item.PhotoId2))
            {
                Image img = Image.FromFile(item.PhotoId2);
                e.Graphics.DrawImage(img, new Rectangle(e.Bounds.Right - 100, e.Bounds.Top, 50, 50));
            }

            e.DrawFocusRectangle();
        }

        private void listBoxReports_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 60;
        }
    }
}
