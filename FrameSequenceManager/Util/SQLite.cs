using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameSequenceManager {

    public class SQLite : Util {

        private string _connectionString { get; set; }
        private string TableFrameSequence { get; } = @"
            CREATE TABLE
                IF NOT EXISTS FrameSequence (
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
                    UserID INTEGER NOT NULL,
                    UploadTime DATETIME DEFAULT CURRENT_TIMESTAMP,
                    UsageCount INTEGER DEFAULT 0,
                    FOREIGN KEY (UserID) REFERENCES Users (ID)
                );
        ";
        private string TableUser { get; } = @"
            CREATE TABLE
                IF NOT EXISTS Users (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    RegisterTime DATETIME DEFAULT CURRENT_TIMESTAMP,
                    IsBanned BOOLEAN DEFAULT 0
                );
        ";

        public SQLite(string sqlitePath) {
            _connectionString = $"Data Source={sqlitePath};Version=3;";
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
    }
}
