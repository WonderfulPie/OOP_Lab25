using System;
using System.Data.SQLite;

namespace Lab_25_Danylko
{
    public class Database
    {
        private SQLiteConnection connection;

        public Database()
        {
            connection = new SQLiteConnection("Data Source=football_tournament.db;Version=3;");
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void CreateTables()
        {
            string createTeamsTable = "CREATE TABLE IF NOT EXISTS Teams (team_id INTEGER PRIMARY KEY, team_name TEXT NOT NULL, photo_id TEXT)";
            string createPlayersTable = "CREATE TABLE IF NOT EXISTS Players (player_id INTEGER PRIMARY KEY, player_name TEXT NOT NULL, team_id INTEGER, FOREIGN KEY (team_id) REFERENCES Teams (team_id))";
            string createMatchesTable = "CREATE TABLE IF NOT EXISTS Matches (match_id INTEGER PRIMARY KEY, team1_id INTEGER, team2_id INTEGER, score_team1 INTEGER, score_team2 INTEGER, match_date TEXT, FOREIGN KEY (team1_id) REFERENCES Teams (team_id), FOREIGN KEY (team2_id) REFERENCES Teams (team_id))";

            using (var cmd = new SQLiteCommand(createTeamsTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createPlayersTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(createMatchesTable, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public int GetNextAvailableId(string tableName, string idColumnName)
        {
            string query = $"SELECT {idColumnName} FROM {tableName} ORDER BY {idColumnName}";
            using (var cmd = new SQLiteCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                int expectedId = 1;
                while (reader.Read())
                {
                    int currentId = Convert.ToInt32(reader[idColumnName]);
                    if (currentId != expectedId)
                    {
                        break;
                    }
                    expectedId++;
                }
                return expectedId;
            }
        }
    }
}