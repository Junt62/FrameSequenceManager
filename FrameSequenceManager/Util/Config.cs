using System.Text.Json;
using System.Text.Json.Serialization;

namespace FrameSequenceManager {

    public partial class Config(
            string aePath = "",
            string libraryPath = @"C:\ProgramData\FSMLibrary",
            string username = "user1",
            string password = "123456",
            bool autologin = true
        ) : Util {

        public string AEPath { get; set; } = aePath;
        public string LibraryPath { get; set; } = libraryPath;
        public string Username { get; set; } = username;
        public string Password { get; set; } = password;
        public bool AutoLogin { get; set; } = autologin;

        [JsonIgnore] public static string AeName { get; } = "AfterFX";
        [JsonIgnore] public static string AeNameWithSuffix { get; } = "AfterFX.exe";
        [JsonIgnore] public static string Name { get; } = "FrameSequenceManager";
        [JsonIgnore] public static string Version { get; } = "1.0.0";
        [JsonIgnore] public static string ConfigPath { get; } = @"C:\ProgramData\FrameSequenceManager";
        [JsonIgnore] public static string ConfigFilePath { get; } = @"C:\ProgramData\FrameSequenceManager\config.json";
        [JsonIgnore] public static string DatabasePath { get; } = @"C:\ProgramData\FrameSequenceManager\sqlite.db";
        [JsonIgnore] public static string DatabaseType { get; } = "SQLite";

        public static bool IsConfigFolderExists() {
            if(Directory.Exists(ConfigPath)) { return true; }
            else { return false; }
        }

        public static void CreateConfigFolder() {
            Directory.CreateDirectory(ConfigPath);
        }

        public bool IsLibraryExists() {
            if(Directory.Exists(LibraryPath)) { return true; }
            else { return false; }
        }

        public void CreateLibraryFolder() {
            Directory.CreateDirectory(LibraryPath);
        }

        public static bool IsConfigExists() {
            if(File.Exists(ConfigFilePath)) { return true; }
            else { return false; }
        }

        public static bool IsConfigLegal() {
            string json = File.ReadAllText(ConfigFilePath);
            using JsonDocument document = JsonDocument.Parse(json);

            var properties = typeof(Config).GetProperties();
            foreach(var property in properties) {
                if(!document.RootElement.TryGetProperty(property.Name, out _)) {
                    return false;
                }
            }
            return true;
        }

        public static void CreateConfig(Config config) {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigFilePath, json);
        }

        public static void WriteConfig(Config config) {
            CreateConfig(config);
        }

        public static Config? LoadConfig() {
            string json = File.ReadAllText(ConfigFilePath);
            return JsonSerializer.Deserialize<Config>(json);
        }
    }
}