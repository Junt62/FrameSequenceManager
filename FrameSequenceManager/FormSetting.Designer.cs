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
            labelUserPassword = new Label();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            textBoxUserPassword = new TextBox();
            buttonUserSignIn = new Button();
            buttonUserSignUp = new Button();
            tabControlServerManager = new TabControl();
            tabPageAddressSetting = new TabPage();
            tabPageServerSetting = new TabPage();
            tabPageOther = new TabPage();
            labelServerAddress = new Label();
            textBoxServerAddress = new TextBox();
            buttonServerConnect = new Button();
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
            tableLayoutPanelServerSetting.Controls.Add(labelUserPassword, 0, 2);
            tableLayoutPanelServerSetting.Controls.Add(textBoxUserName, 1, 1);
            tableLayoutPanelServerSetting.Controls.Add(labelUserName, 0, 1);
            tableLayoutPanelServerSetting.Controls.Add(textBoxUserPassword, 1, 2);
            tableLayoutPanelServerSetting.Controls.Add(buttonUserSignIn, 2, 2);
            tableLayoutPanelServerSetting.Controls.Add(buttonUserSignUp, 2, 1);
            tableLayoutPanelServerSetting.Controls.Add(labelServerAddress, 0, 0);
            tableLayoutPanelServerSetting.Controls.Add(textBoxServerAddress, 1, 0);
            tableLayoutPanelServerSetting.Controls.Add(buttonServerConnect, 2, 0);
            tableLayoutPanelServerSetting.Dock = DockStyle.Fill;
            tableLayoutPanelServerSetting.Location = new Point(3, 3);
            tableLayoutPanelServerSetting.Name = "tableLayoutPanelServerSetting";
            tableLayoutPanelServerSetting.RowCount = 3;
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle());
            tableLayoutPanelServerSetting.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelServerSetting.Size = new Size(610, 125);
            tableLayoutPanelServerSetting.TabIndex = 0;
            tableLayoutPanelServerSetting.Visible = false;
            // 
            // labelUserPassword
            // 
            labelUserPassword.AutoSize = true;
            labelUserPassword.Location = new Point(3, 61);
            labelUserPassword.Margin = new Padding(3, 3, 3, 0);
            labelUserPassword.Name = "labelUserPassword";
            labelUserPassword.Padding = new Padding(0, 3, 0, 0);
            labelUserPassword.Size = new Size(35, 20);
            labelUserPassword.TabIndex = 5;
            labelUserPassword.Text = "密码:";
            labelUserPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUserName.Location = new Point(80, 32);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(125, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(3, 32);
            labelUserName.Margin = new Padding(3, 3, 3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Padding = new Padding(0, 3, 0, 0);
            labelUserName.Size = new Size(47, 20);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "用户名:";
            labelUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUserPassword.Location = new Point(80, 61);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.PasswordChar = '*';
            textBoxUserPassword.Size = new Size(125, 23);
            textBoxUserPassword.TabIndex = 6;
            // 
            // buttonUserSignIn
            // 
            buttonUserSignIn.Location = new Point(211, 61);
            buttonUserSignIn.Name = "buttonUserSignIn";
            buttonUserSignIn.Size = new Size(75, 23);
            buttonUserSignIn.TabIndex = 4;
            buttonUserSignIn.Text = "登录";
            buttonUserSignIn.UseVisualStyleBackColor = true;
            // 
            // buttonUserSignUp
            // 
            buttonUserSignUp.Location = new Point(211, 32);
            buttonUserSignUp.Name = "buttonUserSignUp";
            buttonUserSignUp.Size = new Size(75, 23);
            buttonUserSignUp.TabIndex = 7;
            buttonUserSignUp.Text = "注册";
            buttonUserSignUp.UseVisualStyleBackColor = true;
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
            // labelServerAddress
            // 
            labelServerAddress.AutoSize = true;
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
            textBoxServerAddress.Location = new Point(80, 3);
            textBoxServerAddress.Name = "textBoxServerAddress";
            textBoxServerAddress.Size = new Size(125, 23);
            textBoxServerAddress.TabIndex = 9;
            // 
            // buttonServerConnect
            // 
            buttonServerConnect.Location = new Point(211, 3);
            buttonServerConnect.Name = "buttonServerConnect";
            buttonServerConnect.Size = new Size(75, 23);
            buttonServerConnect.TabIndex = 10;
            buttonServerConnect.Text = "连接";
            buttonServerConnect.UseVisualStyleBackColor = true;
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
        private Button buttonUserSignIn;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private TabControl tabControlServerManager;
        private TabPage tabPageAddressSetting;
        private TabPage tabPageServerSetting;
        private Label labelUserPassword;
        private TextBox textBoxUserPassword;
        private Button buttonUserSignUp;
        private Button buttonServerConnect;
        private TextBox textBoxServerAddress;
        private Label labelServerAddress;
        private TabPage tabPageOther;
    }
}