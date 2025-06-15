using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SQLite;

namespace FrameSequenceManager {

    public class FrameSequence {
        public int ID { get; set; }
        public string OriginalName { get; set; }
        public int CalculatedName { get; set; }
        public string FrameSequenceCount { get; set; }
        public string[] FrameSequenceNames { get; set; }
        public int FrameCount { get; set; }
        public string Type { get; set; }
        public string Tags { get; set; }
        public int UserID { get; set; }
        public int UsageCount { get; set; }
    }

    public class User {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RegisterTime { get; set; }
        public bool IsBanned { get; set; }
    }

    public class SQLite : Util {

        private string _connectionString { get; set; }
        private string TableFrameSequence { get; } = @"
            CREATE TABLE IF NOT EXISTS FrameSequence (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                OriginalName TEXT NOT NULL,
                CalculatedName TEXT,
                FrameSequenceCount INTEGER NOT NULL,
                FrameSequenceNames TEXT,
                FrameCount INTEGER NOT NULL,
                Type TEXT CHECK (
                    Type IN (
                        '武器',
                        '衣服',
                        '翅膀',
                        '光柱',
                        '称号',
                        '怪物',
                        '宠物',
                        '坐骑',
                        '物品',
                        '技能',
                        '特效'
                    )
                ),
                Tags TEXT,
                Username TEXT NOT NULL,
                UploadTime DATETIME DEFAULT CURRENT_TIMESTAMP,
                UsageCount INTEGER DEFAULT 0,
                FOREIGN KEY (Username) REFERENCES Users (Username)
            );
        ";
        private string TableUser { get; } = @"
            CREATE TABLE IF NOT EXISTS Users (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                Password TEXT NOT NULL,
                Salt TEXT NOT NULL,
                RegisterTime DATETIME DEFAULT CURRENT_TIMESTAMP,
                IsBanned BOOLEAN DEFAULT 0
            );
        ";

        public SQLite() {
            _connectionString = $"Data Source={Config.DatabasePath};Version=3;";
            CreateDatabaseIfNotExists();
        }

        private void CreateDatabaseIfNotExists() {
            try {
                using SQLiteConnection connection = new(_connectionString);
                connection.Open();

                new SQLiteCommand("PRAGMA foreign_keys = ON;", connection).ExecuteNonQuery();

                new SQLiteCommand(TableFrameSequence, connection).ExecuteNonQuery();

                new SQLiteCommand(TableUser, connection).ExecuteNonQuery();

            }
            catch(Exception ex) {
                MessageBox.Show($"错误：{ex}");
                throw;
            }
        }

        public void InsertUser(string username, string password, string salt) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                INSERT INTO Users (Username, Password, Salt)
                VALUES (@Username, @Password, @Salt);
            ";
            using SQLiteCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Salt", salt);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUser(string username) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                DELETE FROM Users 
                WHERE Username = @Username;
            ";
            using SQLiteCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();
        }

        public List<User> QueryUser() {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                SELECT ID, Username, Password, Salt, RegisterTime, IsBanned
                FROM Users;
            ";
            using SQLiteCommand cmd = new(sql, connection);
            using SQLiteDataReader reader = cmd.ExecuteReader();

            List<User> user = [];
            while(reader.Read()) {
                User u = new User {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password")),
                    Salt = reader.GetString(reader.GetOrdinal("Salt")),
                    RegisterTime = reader.GetString(reader.GetOrdinal("RegisterTime")),
                    IsBanned = reader.GetBoolean(reader.GetOrdinal("IsBanned"))
                };
                user.Add(u);
            }
            return user;
        }

        public User QueryUser(string username) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                SELECT * FROM Users
                WHERE Username = @Username;
            ";
            using SQLiteCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            using SQLiteDataReader reader = cmd.ExecuteReader();
            User user = new User();
            while(reader.Read()) {
                user.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
                user.Salt = reader.GetString(reader.GetOrdinal("Salt"));
                user.RegisterTime = reader.GetString(reader.GetOrdinal("RegisterTime"));
                user.IsBanned = reader.GetBoolean(reader.GetOrdinal("IsBanned"));
            }
            return user;
        }

        public bool IsUsernameExists(string username) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                SELECT COUNT(*) FROM Users
                WHERE Username = @Username;
            ";
            using SQLiteCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

        public void InsertFrameSequence(
            string originalName,
            string calculatedName,
            int frameSequenceCount,
            string frameSequenceNames,
            int frameCount,
            string type,
            string tags,
            int userId
        ) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string sql = @"
                INSERT INTO FrameSequence (
                    OriginalName, 
                    CalculatedName, 
                    FrameSequenceCount, 
                    FrameSequenceNames, 
                    FrameCount, 
                    Type, 
                    Tags, 
                    UserID
                ) VALUES (
                    @OriginalName, 
                    @CalculatedName, 
                    @FrameSequenceCount, 
                    @FrameSequenceNames, 
                    @FrameCount, 
                    @Type, 
                    @Tags, 
                    @UserID
                );
            ";
            using SQLiteCommand cmd = new(sql, connection);
            cmd.Parameters.AddWithValue("@OriginalName", originalName);
            cmd.Parameters.AddWithValue("@CalculatedName", calculatedName);
            cmd.Parameters.AddWithValue("@FrameSequenceCount", frameSequenceCount);
            cmd.Parameters.AddWithValue("@FrameSequenceNames", frameSequenceNames);
            cmd.Parameters.AddWithValue("@FrameCount", frameCount);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@Tags", tags);
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.ExecuteNonQuery();
        }

        public void DeleteFrameSequence(string id) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string query = @"
                DELETE FROM FrameSequence 
                WHERE ID = @ID;
            ";
            using SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
        }

        public void UpdateFrameSequence(
            int id,
            string originalName,
            string calculatedName,
            int frameSequenceCount,
            string frameSequenceNames,
            int frameCount,
            string type,
            string tags
        ) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
            string query = @"
                UPDATE FrameSequence SET
                    OriginalName = @OriginalName,
                    CalculatedName = @CalculatedName,
                    FrameSequenceCount = @FrameSequenceCount,
                    FrameSequenceNames = @FrameSequenceNames,
                    FrameCount = @FrameCount,
                    Type = @Type,
                    Tags = @Tags
                WHERE ID = @ID;
            ";
            using SQLiteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@OriginalName", originalName);
            command.Parameters.AddWithValue("@CalculatedName", calculatedName);
            command.Parameters.AddWithValue("@FrameSequenceCount", frameSequenceCount);
            command.Parameters.AddWithValue("@FrameSequenceNames", frameSequenceNames);
            command.Parameters.AddWithValue("@FrameCount", frameCount);
            command.Parameters.AddWithValue("@Type", type);
            command.Parameters.AddWithValue("@Tags", tags);
            command.ExecuteNonQuery();
        }

        public void QueryFrameSequence(int id) {
            using SQLiteConnection connection = new(_connectionString);
            connection.Open();
        }
    }
}
