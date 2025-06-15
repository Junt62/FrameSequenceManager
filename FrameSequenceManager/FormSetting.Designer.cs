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
            tableLayoutPanelAddressSetting = new TableLayoutPanel();
            labelLibraryPath = new Label();
            labelAEPath = new Label();
            textBoxAEPath = new TextBox();
            buttonAEPathDetect = new Button();
            buttonAEPathSetting = new Button();
            textBoxLibraryPath = new TextBox();
            buttonLibraryPathOpen = new Button();
            buttonLibraryPathSetting = new Button();
            tableLayoutPanelServerSetting = new TableLayoutPanel();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonRegister = new Button();
            labelServerAddress = new Label();
            textBoxServerAddress = new TextBox();
            buttonServerConnect = new Button();
            checkBoxAutoLogin = new CheckBox();
            tabControlServerManager = new TabControl();
            tabPageAddressSetting = new TabPage();
            tabPageServerSetting = new TabPage();
            tabPageOther = new TabPage();
            tableLayoutPanelAddressSetting.SuspendLayout();
            tableLayoutPanelServerSetting.SuspendLayout();
            tabControlServerManager.SuspendLayout();
            tabPageAddressSetting.SuspendLayout();
            tabPageServerSetting.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelAddressSetting
            // 
            tableLayoutPanelAddressSetting.AutoSize = true;
            tableLayoutPanelAddressSetting.ColumnCount = 4;
            tableLayoutPanelAddressSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAddressSetting.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelAddressSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAddressSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelAddressSetting.Controls.Add(labelLibraryPath, 0, 1);
            tableLayoutPanelAddressSetting.Controls.Add(labelAEPath, 0, 0);
            tableLayoutPanelAddressSetting.Controls.Add(textBoxAEPath, 1, 0);
            tableLayoutPanelAddressSetting.Controls.Add(buttonAEPathDetect, 2, 0);
            tableLayoutPanelAddressSetting.Controls.Add(buttonAEPathSetting, 3, 0);
            tableLayoutPanelAddressSetting.Controls.Add(textBoxLibraryPath, 1, 1);
            tableLayoutPanelAddressSetting.Controls.Add(buttonLibraryPathOpen, 2, 1);
            tableLayoutPanelAddressSetting.Controls.Add(buttonLibraryPathSetting, 3, 1);
            tableLayoutPanelAddressSetting.Dock = DockStyle.Fill;
            tableLayoutPanelAddressSetting.Location = new Point(3, 3);
            tableLayoutPanelAddressSetting.Name = "tableLayoutPanelAddressSetting";
            tableLayoutPanelAddressSetting.RowCount = 3;
            tableLayoutPanelAddressSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelAddressSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelAddressSetting.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAddressSetting.Size = new Size(610, 125);
            tableLayoutPanelAddressSetting.TabIndex = 0;
            // 
            // labelLibraryPath
            // 
            labelLibraryPath.AutoSize = true;
            labelLibraryPath.Location = new Point(3, 32);
            labelLibraryPath.Margin = new Padding(3, 3, 3, 0);
            labelLibraryPath.Name = "labelLibraryPath";
            labelLibraryPath.Padding = new Padding(0, 3, 0, 0);
            labelLibraryPath.Size = new Size(71, 20);
            labelLibraryPath.TabIndex = 14;
            labelLibraryPath.Text = "图片库路径:";
            labelLibraryPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAEPath
            // 
            labelAEPath.AutoSize = true;
            labelAEPath.Location = new Point(3, 3);
            labelAEPath.Margin = new Padding(3, 3, 3, 0);
            labelAEPath.Name = "labelAEPath";
            labelAEPath.Padding = new Padding(0, 3, 0, 0);
            labelAEPath.Size = new Size(50, 20);
            labelAEPath.TabIndex = 0;
            labelAEPath.Text = "AE路径:";
            labelAEPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAEPath
            // 
            textBoxAEPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAEPath.Location = new Point(80, 3);
            textBoxAEPath.Name = "textBoxAEPath";
            textBoxAEPath.Size = new Size(365, 23);
            textBoxAEPath.TabIndex = 1;
            // 
            // buttonAEPathDetect
            // 
            buttonAEPathDetect.Location = new Point(451, 3);
            buttonAEPathDetect.Name = "buttonAEPathDetect";
            buttonAEPathDetect.Size = new Size(75, 23);
            buttonAEPathDetect.TabIndex = 3;
            buttonAEPathDetect.Text = "自动检测";
            buttonAEPathDetect.UseVisualStyleBackColor = true;
            buttonAEPathDetect.Click += ButtonAEPathDetect_Click;
            // 
            // buttonAEPathSetting
            // 
            buttonAEPathSetting.Location = new Point(532, 3);
            buttonAEPathSetting.Name = "buttonAEPathSetting";
            buttonAEPathSetting.Size = new Size(75, 23);
            buttonAEPathSetting.TabIndex = 2;
            buttonAEPathSetting.Text = "手动设置";
            buttonAEPathSetting.UseVisualStyleBackColor = true;
            buttonAEPathSetting.Click += ButtonAEPathSetting_Click;
            // 
            // textBoxLibraryPath
            // 
            textBoxLibraryPath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLibraryPath.Location = new Point(80, 32);
            textBoxLibraryPath.Name = "textBoxLibraryPath";
            textBoxLibraryPath.Size = new Size(365, 23);
            textBoxLibraryPath.TabIndex = 15;
            // 
            // buttonLibraryPathOpen
            // 
            buttonLibraryPathOpen.Location = new Point(451, 32);
            buttonLibraryPathOpen.Name = "buttonLibraryPathOpen";
            buttonLibraryPathOpen.Size = new Size(75, 23);
            buttonLibraryPathOpen.TabIndex = 16;
            buttonLibraryPathOpen.Text = "打开";
            buttonLibraryPathOpen.UseVisualStyleBackColor = true;
            buttonLibraryPathOpen.Click += ButtonLibraryPathOpen_Click;
            // 
            // buttonLibraryPathSetting
            // 
            buttonLibraryPathSetting.Location = new Point(532, 32);
            buttonLibraryPathSetting.Name = "buttonLibraryPathSetting";
            buttonLibraryPathSetting.Size = new Size(75, 23);
            buttonLibraryPathSetting.TabIndex = 17;
            buttonLibraryPathSetting.Text = "设置";
            buttonLibraryPathSetting.UseVisualStyleBackColor = true;
            buttonLibraryPathSetting.Click += ButtonLibraryPathSetting_Click;
            // 
            // tableLayoutPanelServerSetting
            // 
            tableLayoutPanelServerSetting.AutoSize = true;
            tableLayoutPanelServerSetting.ColumnCount = 4;
            tableLayoutPanelServerSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelServerSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelServerSetting.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelServerSetting.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelServerSetting.Controls.Add(labelPassword, 0, 2);
            tableLayoutPanelServerSetting.Controls.Add(textBoxUsername, 1, 1);
            tableLayoutPanelServerSetting.Controls.Add(labelUsername, 0, 1);
            tableLayoutPanelServerSetting.Controls.Add(textBoxPassword, 1, 2);
            tableLayoutPanelServerSetting.Controls.Add(buttonLogin, 2, 2);
            tableLayoutPanelServerSetting.Controls.Add(buttonRegister, 2, 1);
            tableLayoutPanelServerSetting.Controls.Add(labelServerAddress, 0, 0);
            tableLayoutPanelServerSetting.Controls.Add(textBoxServerAddress, 1, 0);
            tableLayoutPanelServerSetting.Controls.Add(buttonServerConnect, 2, 0);
            tableLayoutPanelServerSetting.Controls.Add(checkBoxAutoLogin, 3, 2);
            tableLayoutPanelServerSetting.Dock = DockStyle.Fill;
            tableLayoutPanelServerSetting.Location = new Point(3, 3);
            tableLayoutPanelServerSetting.Name = "tableLayoutPanelServerSetting";
            tableLayoutPanelServerSetting.RowCount = 3;
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelServerSetting.Size = new Size(610, 125);
            tableLayoutPanelServerSetting.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(3, 61);
            labelPassword.Margin = new Padding(3, 3, 3, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Padding = new Padding(0, 3, 0, 0);
            labelPassword.Size = new Size(35, 20);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "密码:";
            labelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(80, 32);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(125, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(3, 32);
            labelUsername.Margin = new Padding(3, 3, 3, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Padding = new Padding(0, 3, 0, 0);
            labelUsername.Size = new Size(47, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "用户名:";
            labelUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(80, 61);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(211, 61);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "登录";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(211, 32);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "注册";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += ButtonRegister_Click;
            // 
            // labelServerAddress
            // 
            labelServerAddress.AutoSize = true;
            labelServerAddress.Enabled = false;
            labelServerAddress.Location = new Point(3, 3);
            labelServerAddress.Margin = new Padding(3, 3, 3, 0);
            labelServerAddress.Name = "labelServerAddress";
            labelServerAddress.Padding = new Padding(0, 3, 0, 0);
            labelServerAddress.Size = new Size(71, 20);
            labelServerAddress.TabIndex = 8;
            labelServerAddress.Text = "服务器地址:";
            labelServerAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxServerAddress
            // 
            textBoxServerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxServerAddress.Enabled = false;
            textBoxServerAddress.Location = new Point(80, 3);
            textBoxServerAddress.Name = "textBoxServerAddress";
            textBoxServerAddress.Size = new Size(125, 23);
            textBoxServerAddress.TabIndex = 9;
            // 
            // buttonServerConnect
            // 
            buttonServerConnect.Enabled = false;
            buttonServerConnect.Location = new Point(211, 3);
            buttonServerConnect.Name = "buttonServerConnect";
            buttonServerConnect.Size = new Size(75, 23);
            buttonServerConnect.TabIndex = 10;
            buttonServerConnect.Text = "连接";
            buttonServerConnect.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoLogin
            // 
            checkBoxAutoLogin.AutoSize = true;
            checkBoxAutoLogin.Checked = true;
            checkBoxAutoLogin.CheckState = CheckState.Checked;
            checkBoxAutoLogin.Location = new Point(292, 61);
            checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            checkBoxAutoLogin.Size = new Size(75, 21);
            checkBoxAutoLogin.TabIndex = 11;
            checkBoxAutoLogin.Text = "自动登录";
            checkBoxAutoLogin.UseVisualStyleBackColor = true;
            checkBoxAutoLogin.CheckedChanged += CheckBoxAutoLogin_CheckedChanged;
            // 
            // tabControlServerManager
            // 
            tabControlServerManager.Controls.Add(tabPageAddressSetting);
            tabControlServerManager.Controls.Add(tabPageServerSetting);
            tabControlServerManager.Controls.Add(tabPageOther);
            tabControlServerManager.Dock = DockStyle.Fill;
            tabControlServerManager.Location = new Point(0, 0);
            tabControlServerManager.Name = "tabControlServerManager";
            tabControlServerManager.SelectedIndex = 0;
            tabControlServerManager.Size = new Size(624, 161);
            tabControlServerManager.TabIndex = 5;
            // 
            // tabPageAddressSetting
            // 
            tabPageAddressSetting.BackColor = Color.WhiteSmoke;
            tabPageAddressSetting.Controls.Add(tableLayoutPanelAddressSetting);
            tabPageAddressSetting.Location = new Point(4, 26);
            tabPageAddressSetting.Name = "tabPageAddressSetting";
            tabPageAddressSetting.Padding = new Padding(3);
            tabPageAddressSetting.Size = new Size(616, 131);
            tabPageAddressSetting.TabIndex = 0;
            tabPageAddressSetting.Text = "路径设置";
            // 
            // tabPageServerSetting
            // 
            tabPageServerSetting.BackColor = Color.WhiteSmoke;
            tabPageServerSetting.Controls.Add(tableLayoutPanelServerSetting);
            tabPageServerSetting.Location = new Point(4, 26);
            tabPageServerSetting.Name = "tabPageServerSetting";
            tabPageServerSetting.Padding = new Padding(3);
            tabPageServerSetting.Size = new Size(616, 131);
            tabPageServerSetting.TabIndex = 1;
            tabPageServerSetting.Text = "用户设置";
            // 
            // tabPageOther
            // 
            tabPageOther.BackColor = Color.WhiteSmoke;
            tabPageOther.Location = new Point(4, 26);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Padding = new Padding(3);
            tabPageOther.Size = new Size(616, 131);
            tabPageOther.TabIndex = 2;
            tabPageOther.Text = "其它设置";
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(624, 161);
            Controls.Add(tabControlServerManager);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSetting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            tableLayoutPanelAddressSetting.ResumeLayout(false);
            tableLayoutPanelAddressSetting.PerformLayout();
            tableLayoutPanelServerSetting.ResumeLayout(false);
            tableLayoutPanelServerSetting.PerformLayout();
            tabControlServerManager.ResumeLayout(false);
            tabPageAddressSetting.ResumeLayout(false);
            tabPageAddressSetting.PerformLayout();
            tabPageServerSetting.ResumeLayout(false);
            tabPageServerSetting.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelAddressSetting;
        private Label labelAEPath;
        private TextBox textBoxAEPath;
        private Button buttonAEPathSetting;
        private Button buttonAEPathDetect;
        private TextBox textBoxLibraryPath;
        private Label labelLibraryPath;
        private Button buttonLibraryPathSetting;
        private Button buttonLibraryPathOpen;
        private GroupBox groupBoxAddress;
        private TableLayoutPanel tableLayoutAddress;
        private GroupBox groupBoxUser;
        private TableLayoutPanel tableLayoutPanelServerSetting;
        private Button buttonLogin;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TabControl tabControlServerManager;
        private TabPage tabPageAddressSetting;
        private TabPage tabPageServerSetting;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonRegister;
        private Button buttonServerConnect;
        private TextBox textBoxServerAddress;
        private Label labelServerAddress;
        private TabPage tabPageOther;
        private CheckBox checkBoxAutoLogin;
    }
}