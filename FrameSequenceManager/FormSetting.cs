using System.Diagnostics;

namespace FrameSequenceManager {

    public partial class FormSetting : Form {

        private Config Config { get; }

        public FormSetting(Config config) {
            InitializeComponent();

            Config = config;
            textBoxAEPath.Text = Config.AEPath;
            textBoxLibraryPath.Text = Config.LibraryPath;
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
    }
}
