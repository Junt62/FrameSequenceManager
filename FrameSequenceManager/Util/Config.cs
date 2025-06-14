using System.Text.Json;
using System.Text.Json.Serialization;

namespace FrameSequenceManager {

    public partial class Config : Util {

        public string AEPath { get; set; }
        public string LibraryPath { get; set; }

        [JsonIgnore] public string AeName { get; } = "AfterFX";
        [JsonIgnore] public string AeNameWithSuffix { get; } = "AfterFX.exe";
        [JsonIgnore] public string Name { get; } = "FrameSequenceManager";
        [JsonIgnore] public string Version { get; } = "1.0.0";
        [JsonIgnore] public string ConfigPath { get; } = @"C:\ProgramData\FrameSequenceManager";
        [JsonIgnore] public string ConfigFilePath { get; } = @"C:\ProgramData\FrameSequenceManager\config.json";
        [JsonIgnore] public string DatabasePath { get; } = @"C:\ProgramData\FrameSequenceManager\FrameSequenceManager.db";
        [JsonIgnore] public string DatabaseType { get; } = "SQLite";

        public Config(string aePath = "", string libraryPath = @"C:\ProgramData\FSMLibrary") {
            AEPath = aePath;
            LibraryPath = libraryPath;
        }

        public bool IsConfigFolderExists() {
            if(Directory.Exists(ConfigPath)) { return true; }
            else { return false; }
        }

        public void CreateConfigFolder() {
            Directory.CreateDirectory(ConfigPath);
        }

        public bool IsLibraryExists() {
            if(Directory.Exists(LibraryPath)) { return true; }
            else { return false; }
        }

        public void CreateLibraryFolder() {
            Directory.CreateDirectory(LibraryPath);
        }

        public bool IsConfigExists() {
            if(File.Exists(ConfigFilePath)) { return true; }
            else { return false; }
        }

        public bool IsConfigLegal() {
            string json = File.ReadAllText(ConfigFilePath);
            Config? deserializeJson = JsonSerializer.Deserialize<Config>(json);
            if(deserializeJson is not null) { return true; }
            else { return false; }
        }

        public void CreateConfig(Config config) {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigFilePath, json);
        }

        public void WriteConfig(Config config) {
            CreateConfig(config);
        }

        public Config LoadConfig() {
            string json = File.ReadAllText(ConfigFilePath);
            return JsonSerializer.Deserialize<Config>(json) ?? new Config();
        }
    }
}