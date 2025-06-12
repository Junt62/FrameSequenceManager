using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameSequenceManager {
    public partial class FormSetting : Form {
        public FormSetting() {
            InitializeComponent();

            InitializeValue();
        }

        private void InitializeValue() {
            textBoxCurrentPath.Text = AppDomain.CurrentDomain.BaseDirectory;
            textBoxAePath.Text = !string.IsNullOrEmpty(FormMain.AePath) ? FormMain.AePath : string.Empty;
            textBoxDataBase.Text = "";
            textBoxLibrary.Text = "";
            textBoxConfig.Text = "";
        }

        private void ButtonAePathDetect_Click(object sender, EventArgs e) {
            textBoxAePath.Text = string.Empty;

            FormMain.AePath = Utils.GetAePath();
            if(!string.IsNullOrEmpty(FormMain.AePath))
                textBoxAePath.Text = FormMain.AePath;
            else
                MessageBox.Show("未检测到AE，请启动AE后再试");
        }

        private void ButtonAePathChoose_Click(object sender, EventArgs e) {
            textBoxAePath.Text = string.Empty;

            using OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "选择AE程序路径";
            dlg.Filter = "所有支持的文件|*.exe";

            if(dlg.ShowDialog() == DialogResult.OK) {
                if(Path.GetFileName(dlg.FileName).Equals(FormMain.AeNameWithSuffix, StringComparison.OrdinalIgnoreCase)) {
                    FormMain.AePath = dlg.FileName;
                    textBoxAePath.Text = FormMain.AePath;
                }
                else {
                    MessageBox.Show("错误：选择的程序不正确");
                }
            }
        }
    }
}
