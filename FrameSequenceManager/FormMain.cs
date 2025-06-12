using System.Diagnostics;

namespace FrameSequenceManager {
    public partial class FormMain : Form {

        public const string AeName = "AfterFX";
        public const string AeNameWithSuffix = "AfterFX.exe";
        public static string? AePath { get; set; }

        public FormMain() {
            InitializeComponent();

            AePath = Utils.GetAePath();
        }

        private void Button1_Click(object sender, EventArgs e) {

            using(OpenFileDialog dlg = new OpenFileDialog()) {
                dlg.Title = "ѡ��Ҫ������ļ�";
                dlg.Filter = "����֧�ֵ��ļ�|*.png;*.jpg;*.jpeg;*.psd;*.ai;*.mp4;*.mov;*.avi|�����ļ�|*.*";

                if(dlg.ShowDialog() == DialogResult.OK) {
                    string filePath = dlg.FileName;
                    //filePath = Directory.GetParent(filePath).FullName;
                    string jsxPath = Path.Combine(Path.GetTempPath(), "ae_import_temp.jsx");

                    // ����jsx�ű�
                    string jsx = $@"
                        var importFile = new File(""{filePath.Replace(@"\", @"\\")}"");
                        app.project.importFile(new ImportOptions(importFile));
                    ";
                    File.WriteAllText(jsxPath, jsx);

                    // ����AEִ�нű�
                    if(!File.Exists(AePath)) {
                        MessageBox.Show("δ�ҵ�AE��������·����" + AePath);
                        return;
                    }
                    string arguments = $"-NoProfile -Command \"& \\\"{AePath}\\\" -r \\\"{jsxPath}\\\"\"";

                    try {
                        ProcessStartInfo psi = new ProcessStartInfo {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -Command \"& \\\"{AePath}\\\" -r \\\"{jsxPath}\\\"\"",
                            UseShellExecute = false,
                            RedirectStandardError = true,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };
                        Process proc = Process.Start(psi);
                    }
                    catch(Exception ex) {
                        MessageBox.Show("����ʧ�ܣ�" + ex.Message);
                    }
                }
            }
        }

        private void MenuItemSetting_Click(object sender, EventArgs e) {
            FormSetting formSetting = new FormSetting();
            formSetting.ShowDialog();
        }

        private void MenuItemQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
