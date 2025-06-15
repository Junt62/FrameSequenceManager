using System.Diagnostics;

namespace FrameSequenceManager {

    public partial class FormSetting : Form {

        private Config Config { get; }
        private SQLite SQLite { get; set; }

        public FormSetting(Config config, SQLite sqlite) {
            InitializeComponent();

            Config = config;
            SQLite = sqlite;

            textBoxAEPath.Text = Config.AEPath;
            textBoxLibraryPath.Text = Config.LibraryPath;
            textBoxUsername.Text = Config.Username;
            textBoxPassword.Text = Config.Password;
        }

        private void ButtonAEPathDetect_Click(object sender, EventArgs e) {
            textBoxAEPath.Text = string.Empty;

            Config.AEPath = Util.GetAfterFXPath(Config.AeName);
            if(!string.IsNullOrEmpty(Config.AEPath)) {
                textBoxAEPath.Text = Config.AEPath;
                Config.WriteConfig(Config);
                MessageBox.Show("成功：检测到AE程序");
            }
            else {
                MessageBox.Show("错误：未检测到AE，请启动AE后再试");
            }
        }

        private void ButtonAEPathSetting_Click(object sender, EventArgs e) {
            using OpenFileDialog dlg = new OpenFileDialog() {
                Title = "选择AE程序路径",
                Filter = "所有支持的文件|*.exe"
            };

            if(dlg.ShowDialog() == DialogResult.OK) {
                if(Path.GetFileName(dlg.FileName).Equals(Config.AeNameWithSuffix, StringComparison.OrdinalIgnoreCase)) {
                    Config.AEPath = dlg.FileName;
                    Config.WriteConfig(Config);
                    textBoxAEPath.Text = Config.AEPath;
                    MessageBox.Show("成功：已设置AE程序路径");
                }
                else {
                    MessageBox.Show("错误：选择的程序不正确");
                }
            }
        }

        private void ButtonLibraryPathOpen_Click(object sender, EventArgs e) {
            Process.Start("explorer.exe", Config.LibraryPath);
        }

        private void ButtonLibraryPathSetting_Click(object sender, EventArgs e) {
            using FolderBrowserDialog dlg = new FolderBrowserDialog() {
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };

            if(dlg.ShowDialog() == DialogResult.OK) {
                Config.LibraryPath = dlg.SelectedPath;
                Config.WriteConfig(Config);
                textBoxLibraryPath.Text = Config.LibraryPath;
                MessageBox.Show("成功：已设置新的图片库文件夹");
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e) {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if(username.Length < 3) {
                MessageBox.Show("错误：用户名长度不能小于3位");
                return;
            }
            if(username.Length > 10) {
                MessageBox.Show("错误：用户名长度不能大于10位");
                return;
            }
            if(password.Length < 6) {
                MessageBox.Show("错误：密码长度不能小于6位");
                return;
            }
            if(password.Length > 30) {
                MessageBox.Show("错误：密码长度不能大于30位");
                return;
            }

            string salt = Password.GenerateSalt();
            if(!SQLite.IsUsernameExists(username)) {
                SQLite.InsertUser(username, Password.HashPassword(password, salt), salt);
                Config.Username = username;
                Config.Password = password;
                Config.WriteConfig(Config);
                MessageBox.Show("成功：注册成功");
            }
            else {
                MessageBox.Show("失败：用户名已存在");
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e) {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User user;
            if(SQLite.IsUsernameExists(username)) {
                user = SQLite.QueryUser(username);
                string hashedPassword = Password.HashPassword(password, user.Salt);
                if(hashedPassword == user.Password) {
                    Config.Username = username;
                    Config.Password = password;
                    Config.WriteConfig(Config);
                    MessageBox.Show("成功：登录成功");
                    return;
                }
            }
            MessageBox.Show("错误：用户名或密码错误");
        }
    }
}
