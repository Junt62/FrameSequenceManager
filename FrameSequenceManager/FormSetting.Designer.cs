namespace FrameSequenceManager {
    partial class FormSetting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelCurrentPath = new Label();
            labelAePath = new Label();
            textBoxCurrentPath = new TextBox();
            textBoxAePath = new TextBox();
            buttonAePathSetting = new Button();
            buttonAePathDetect = new Button();
            labelDataBase = new Label();
            textBoxDataBase = new TextBox();
            labelLibrary = new Label();
            textBoxLibrary = new TextBox();
            buttonDataBaseTest = new Button();
            buttonDataBaseSetting = new Button();
            buttonLibraryTest = new Button();
            buttonLibrarySetting = new Button();
            tabControlLocal = new TabControl();
            tabPageLocal = new TabPage();
            tabPage2 = new TabPage();
            labelConfig = new Label();
            textBoxConfig = new TextBox();
            buttonConfigOpen = new Button();
            buttonConfigSetting = new Button();
            tableLayoutPanel1.SuspendLayout();
            tabControlLocal.SuspendLayout();
            tabPageLocal.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonConfigSetting, 3, 4);
            tableLayoutPanel1.Controls.Add(buttonConfigOpen, 2, 4);
            tableLayoutPanel1.Controls.Add(textBoxConfig, 1, 4);
            tableLayoutPanel1.Controls.Add(labelConfig, 0, 4);
            tableLayoutPanel1.Controls.Add(labelCurrentPath, 0, 0);
            tableLayoutPanel1.Controls.Add(labelAePath, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxCurrentPath, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxAePath, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonAePathSetting, 3, 1);
            tableLayoutPanel1.Controls.Add(buttonAePathDetect, 2, 1);
            tableLayoutPanel1.Controls.Add(labelDataBase, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxDataBase, 1, 2);
            tableLayoutPanel1.Controls.Add(labelLibrary, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxLibrary, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonDataBaseTest, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonDataBaseSetting, 3, 2);
            tableLayoutPanel1.Controls.Add(buttonLibraryTest, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonLibrarySetting, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(610, 225);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCurrentPath
            // 
            labelCurrentPath.AutoSize = true;
            labelCurrentPath.Location = new Point(3, 3);
            labelCurrentPath.Margin = new Padding(3, 3, 3, 0);
            labelCurrentPath.Name = "labelCurrentPath";
            labelCurrentPath.Padding = new Padding(0, 3, 0, 0);
            labelCurrentPath.Size = new Size(59, 20);
            labelCurrentPath.TabIndex = 12;
            labelCurrentPath.Text = "软件路径:";
            labelCurrentPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAePath
            // 
            labelAePath.AutoSize = true;
            labelAePath.Location = new Point(3, 32);
            labelAePath.Margin = new Padding(3, 3, 3, 0);
            labelAePath.Name = "labelAePath";
            labelAePath.Padding = new Padding(0, 3, 0, 0);
            labelAePath.Size = new Size(50, 20);
            labelAePath.TabIndex = 0;
            labelAePath.Text = "AE路径:";
            labelAePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCurrentPath
            // 
            textBoxCurrentPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCurrentPath.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.SetColumnSpan(textBoxCurrentPath, 3);
            textBoxCurrentPath.Location = new Point(92, 3);
            textBoxCurrentPath.Name = "textBoxCurrentPath";
            textBoxCurrentPath.ReadOnly = true;
            textBoxCurrentPath.Size = new Size(515, 23);
            textBoxCurrentPath.TabIndex = 13;
            // 
            // textBoxAePath
            // 
            textBoxAePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAePath.Location = new Point(92, 32);
            textBoxAePath.Name = "textBoxAePath";
            textBoxAePath.Size = new Size(353, 23);
            textBoxAePath.TabIndex = 1;
            // 
            // buttonAePathSetting
            // 
            buttonAePathSetting.Location = new Point(532, 32);
            buttonAePathSetting.Name = "buttonAePathSetting";
            buttonAePathSetting.Size = new Size(75, 23);
            buttonAePathSetting.TabIndex = 2;
            buttonAePathSetting.Text = "设置";
            buttonAePathSetting.UseVisualStyleBackColor = true;
            buttonAePathSetting.Click += ButtonAePathChoose_Click;
            // 
            // buttonAePathDetect
            // 
            buttonAePathDetect.Location = new Point(451, 32);
            buttonAePathDetect.Name = "buttonAePathDetect";
            buttonAePathDetect.Size = new Size(75, 23);
            buttonAePathDetect.TabIndex = 3;
            buttonAePathDetect.Text = "自动检测";
            buttonAePathDetect.UseVisualStyleBackColor = true;
            buttonAePathDetect.Click += ButtonAePathDetect_Click;
            // 
            // labelDataBase
            // 
            labelDataBase.AutoSize = true;
            labelDataBase.Location = new Point(3, 61);
            labelDataBase.Margin = new Padding(3, 3, 3, 0);
            labelDataBase.Name = "labelDataBase";
            labelDataBase.Padding = new Padding(0, 3, 0, 0);
            labelDataBase.Size = new Size(71, 20);
            labelDataBase.TabIndex = 4;
            labelDataBase.Text = "数据库路径:";
            labelDataBase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDataBase.Location = new Point(92, 61);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.Size = new Size(353, 23);
            textBoxDataBase.TabIndex = 6;
            // 
            // labelLibrary
            // 
            labelLibrary.AutoSize = true;
            labelLibrary.Location = new Point(3, 90);
            labelLibrary.Margin = new Padding(3, 3, 3, 0);
            labelLibrary.Name = "labelLibrary";
            labelLibrary.Padding = new Padding(0, 3, 0, 0);
            labelLibrary.Size = new Size(71, 20);
            labelLibrary.TabIndex = 5;
            labelLibrary.Text = "图片库路径:";
            labelLibrary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxLibrary
            // 
            textBoxLibrary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLibrary.Location = new Point(92, 90);
            textBoxLibrary.Name = "textBoxLibrary";
            textBoxLibrary.Size = new Size(353, 23);
            textBoxLibrary.TabIndex = 7;
            // 
            // buttonDataBaseTest
            // 
            buttonDataBaseTest.Location = new Point(451, 61);
            buttonDataBaseTest.Name = "buttonDataBaseTest";
            buttonDataBaseTest.Size = new Size(75, 23);
            buttonDataBaseTest.TabIndex = 10;
            buttonDataBaseTest.Text = "测试";
            buttonDataBaseTest.UseVisualStyleBackColor = true;
            // 
            // buttonDataBaseSetting
            // 
            buttonDataBaseSetting.Location = new Point(532, 61);
            buttonDataBaseSetting.Name = "buttonDataBaseSetting";
            buttonDataBaseSetting.Size = new Size(75, 23);
            buttonDataBaseSetting.TabIndex = 8;
            buttonDataBaseSetting.Text = "设置";
            buttonDataBaseSetting.UseVisualStyleBackColor = true;
            // 
            // buttonLibraryTest
            // 
            buttonLibraryTest.Location = new Point(451, 90);
            buttonLibraryTest.Name = "buttonLibraryTest";
            buttonLibraryTest.Size = new Size(75, 23);
            buttonLibraryTest.TabIndex = 11;
            buttonLibraryTest.Text = "测试";
            buttonLibraryTest.UseVisualStyleBackColor = true;
            // 
            // buttonLibrarySetting
            // 
            buttonLibrarySetting.Location = new Point(532, 90);
            buttonLibrarySetting.Name = "buttonLibrarySetting";
            buttonLibrarySetting.Size = new Size(75, 23);
            buttonLibrarySetting.TabIndex = 9;
            buttonLibrarySetting.Text = "设置";
            buttonLibrarySetting.UseVisualStyleBackColor = true;
            // 
            // tabControlLocal
            // 
            tabControlLocal.Controls.Add(tabPageLocal);
            tabControlLocal.Controls.Add(tabPage2);
            tabControlLocal.Dock = DockStyle.Fill;
            tabControlLocal.Location = new Point(0, 0);
            tabControlLocal.Name = "tabControlLocal";
            tabControlLocal.SelectedIndex = 0;
            tabControlLocal.Size = new Size(624, 261);
            tabControlLocal.TabIndex = 4;
            // 
            // tabPageLocal
            // 
            tabPageLocal.BackColor = Color.WhiteSmoke;
            tabPageLocal.Controls.Add(tableLayoutPanel1);
            tabPageLocal.Location = new Point(4, 26);
            tabPageLocal.Name = "tabPageLocal";
            tabPageLocal.Padding = new Padding(3);
            tabPageLocal.Size = new Size(616, 231);
            tabPageLocal.TabIndex = 0;
            tabPageLocal.Text = "路径设置";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(616, 231);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // labelConfig
            // 
            labelConfig.AutoSize = true;
            labelConfig.Location = new Point(3, 119);
            labelConfig.Margin = new Padding(3, 3, 3, 0);
            labelConfig.Name = "labelConfig";
            labelConfig.Padding = new Padding(0, 3, 0, 0);
            labelConfig.Size = new Size(83, 20);
            labelConfig.TabIndex = 14;
            labelConfig.Text = "配置文件路径:";
            labelConfig.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxConfig
            // 
            textBoxConfig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConfig.Location = new Point(92, 119);
            textBoxConfig.Name = "textBoxConfig";
            textBoxConfig.Size = new Size(353, 23);
            textBoxConfig.TabIndex = 15;
            // 
            // buttonConfigOpen
            // 
            buttonConfigOpen.Location = new Point(451, 119);
            buttonConfigOpen.Name = "buttonConfigOpen";
            buttonConfigOpen.Size = new Size(75, 23);
            buttonConfigOpen.TabIndex = 16;
            buttonConfigOpen.Text = "打开";
            buttonConfigOpen.UseVisualStyleBackColor = true;
            // 
            // buttonConfigSetting
            // 
            buttonConfigSetting.Location = new Point(532, 119);
            buttonConfigSetting.Name = "buttonConfigSetting";
            buttonConfigSetting.Size = new Size(75, 23);
            buttonConfigSetting.TabIndex = 17;
            buttonConfigSetting.Text = "设置";
            buttonConfigSetting.UseVisualStyleBackColor = true;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 261);
            Controls.Add(tabControlLocal);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormSetting";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControlLocal.ResumeLayout(false);
            tabPageLocal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelAePath;
        private TextBox textBoxAePath;
        private TabControl tabControlLocal;
        private TabPage tabPageLocal;
        private TabPage tabPage2;
        private Button buttonDataBaseTest;
        private TextBox textBoxDataBase;
        private Label labelDataBase;
        private Label labelLibrary;
        private TextBox textBoxLibrary;
        private Button buttonDataBaseSetting;
        private Button buttonLibrarySetting;
        private Button buttonLibraryTest;
        private TextBox textBoxCurrentPath;
        private Label labelCurrentPath;
        private Button buttonAePathSetting;
        private Button buttonAePathDetect;
        private TextBox textBoxConfig;
        private Label labelConfig;
        private Button buttonConfigSetting;
        private Button buttonConfigOpen;
    }
}