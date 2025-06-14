using FrameSequenceManager;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FrameSequenceManager {

    public partial class FormMain : Form {

        public Config Config { get; set; } = new Config();

        public FormMain() {
            InitializeComponent();
            InitializeVariable();
        }

        private void InitializeVariable() {
            if(!Config.IsConfigFolderExists()) { Config.CreateConfigFolder(); }
            if(!Config.IsLibraryExists()) { Config.CreateLibraryFolder(); }
            if(!Config.IsConfigExists() || !Config.IsConfigLegal()) { Config.CreateConfig(Config); }
            else { Config = Config.LoadConfig(); }
        }

        private void Button1_Click(object sender, EventArgs e) {

        }

        private void MenuItemSetting_Click(object sender, EventArgs e) {
            FormSetting formSetting = new(Config);
            formSetting.ShowDialog();
        }

        private void MenuItemQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
