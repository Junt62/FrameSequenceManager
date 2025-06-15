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

            if(Config.AutoLogin) {
                if(SQLite.IsUsernameExists(Config.Username)) {
                    User = SQLite.QueryUser(Config.Username);
                    string hashedPassword = Password.HashPassword(Config.Password, User.Salt);
                    if(hashedPassword == User.Password) {
                        labelUserInfoUsername2.Text = Config.Username;
                        labelUserInfoStatus2.Text = "ÒÑµÇÂ¼";
                        labelUserInfoStatus2.ForeColor = Color.Green;
                    }
                }
            }
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
