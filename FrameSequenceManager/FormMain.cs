using FrameSequenceManager;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FrameSequenceManager {

    public partial class FormMain : Form {

        public Config Config { get; set; } = new Config();
        public SQLite SQLite { get; set; } = new SQLite();
        public User User { get; set; } = new User();
        public FormSetting FormSetting { get; set; }

        public FormMain() {
            InitializeComponent();
            InitializeVariable();

            FormSetting = new(Config, SQLite);
        }

        private void InitializeVariable() {
            if(!Config.IsConfigFolderExists()) { Config.CreateConfigFolder(); }
            if(!Config.IsLibraryExists()) { Config.CreateLibraryFolder(); }
            if(!Config.IsConfigExists() || !Config.IsConfigLegal()) { Config.CreateConfig(Config); }
            else { Config = Config.LoadConfig() ?? new Config(); }
        }

        private void Button1_Click(object sender, EventArgs e) {

        }

        private void MenuItemSetting_Click(object sender, EventArgs e) {
            FormSetting.ShowDialog();
        }

        private void MenuItemQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
