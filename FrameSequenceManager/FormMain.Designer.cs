namespace FrameSequenceManager {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip = new MenuStrip();
            menuItemFile = new ToolStripMenuItem();
            menuItemImport = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuItemSetting = new ToolStripMenuItem();
            menuItemQuit = new ToolStripMenuItem();
            menuItemEdit = new ToolStripMenuItem();
            menuItemRename = new ToolStripMenuItem();
            menuItemDelete = new ToolStripMenuItem();
            menuItemHelp = new ToolStripMenuItem();
            menuItemAbout = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutContent = new TableLayoutPanel();
            groupBoxControl = new GroupBox();
            tableLayoutControl = new TableLayoutPanel();
            button8 = new Button();
            buttonRefresh = new Button();
            button9 = new Button();
            button10 = new Button();
            groupBoxControl2 = new GroupBox();
            tableLayoutControl2 = new TableLayoutPanel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBoxPicture = new GroupBox();
            groupBoxUserInfo = new GroupBox();
            tableLayoutPanelUserInfo = new TableLayoutPanel();
            labelUserInfoUsername2 = new Label();
            labelUserInfoStatus = new Label();
            labelUserInfoStatus2 = new Label();
            labelUserInfoUsername = new Label();
            tableLayoutMain = new TableLayoutPanel();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            tableLayoutContent.SuspendLayout();
            groupBoxControl.SuspendLayout();
            tableLayoutControl.SuspendLayout();
            groupBoxControl2.SuspendLayout();
            tableLayoutControl2.SuspendLayout();
            groupBoxPicture.SuspendLayout();
            groupBoxUserInfo.SuspendLayout();
            tableLayoutPanelUserInfo.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 499);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(248, 17);
            toolStripStatusLabel1.Text = "提示：软件初始化完成，可以开始执行操作。";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ControlLightLight;
            menuStrip.GripMargin = new Padding(0);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemFile, menuItemEdit, menuItemHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(0);
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            menuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemImport, toolStripSeparator1, menuItemSetting, menuItemQuit });
            menuItemFile.Name = "menuItemFile";
            menuItemFile.Size = new Size(58, 24);
            menuItemFile.Text = "文件(&F)";
            // 
            // menuItemImport
            // 
            menuItemImport.Name = "menuItemImport";
            menuItemImport.Size = new Size(116, 22);
            menuItemImport.Text = "导入(&R)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(113, 6);
            // 
            // menuItemSetting
            // 
            menuItemSetting.Name = "menuItemSetting";
            menuItemSetting.Size = new Size(116, 22);
            menuItemSetting.Text = "设置(&S)";
            menuItemSetting.Click += MenuItemSetting_Click;
            // 
            // menuItemQuit
            // 
            menuItemQuit.Name = "menuItemQuit";
            menuItemQuit.Size = new Size(116, 22);
            menuItemQuit.Text = "退出(&X)";
            menuItemQuit.Click += MenuItemQuit_Click;
            // 
            // menuItemEdit
            // 
            menuItemEdit.DropDownItems.AddRange(new ToolStripItem[] { menuItemRename, menuItemDelete });
            menuItemEdit.Name = "menuItemEdit";
            menuItemEdit.Size = new Size(59, 24);
            menuItemEdit.Text = "编辑(&E)";
            // 
            // menuItemRename
            // 
            menuItemRename.Name = "menuItemRename";
            menuItemRename.Size = new Size(128, 22);
            menuItemRename.Text = "重命名(&R)";
            // 
            // menuItemDelete
            // 
            menuItemDelete.Name = "menuItemDelete";
            menuItemDelete.Size = new Size(128, 22);
            menuItemDelete.Text = "删除(&D)";
            // 
            // menuItemHelp
            // 
            menuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout });
            menuItemHelp.Name = "menuItemHelp";
            menuItemHelp.ShortcutKeyDisplayString = "";
            menuItemHelp.Size = new Size(61, 24);
            menuItemHelp.Text = "帮助(&H)";
            // 
            // menuItemAbout
            // 
            menuItemAbout.Name = "menuItemAbout";
            menuItemAbout.ShortcutKeyDisplayString = "";
            menuItemAbout.Size = new Size(116, 22);
            menuItemAbout.Text = "关于(&A)";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(648, 391);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutContent
            // 
            tableLayoutContent.ColumnCount = 2;
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutContent.ColumnStyles.Add(new ColumnStyle());
            tableLayoutContent.Controls.Add(groupBoxControl, 0, 0);
            tableLayoutContent.Controls.Add(groupBoxControl2, 1, 1);
            tableLayoutContent.Controls.Add(groupBoxPicture, 0, 1);
            tableLayoutContent.Controls.Add(groupBoxUserInfo, 1, 0);
            tableLayoutContent.Dock = DockStyle.Fill;
            tableLayoutContent.Location = new Point(0, 24);
            tableLayoutContent.Margin = new Padding(0);
            tableLayoutContent.Name = "tableLayoutContent";
            tableLayoutContent.RowCount = 2;
            tableLayoutContent.RowStyles.Add(new RowStyle());
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutContent.Size = new Size(784, 475);
            tableLayoutContent.TabIndex = 5;
            // 
            // groupBoxControl
            // 
            groupBoxControl.AutoSize = true;
            groupBoxControl.Controls.Add(tableLayoutControl);
            groupBoxControl.Dock = DockStyle.Fill;
            groupBoxControl.Location = new Point(3, 0);
            groupBoxControl.Margin = new Padding(3, 0, 3, 0);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(654, 62);
            groupBoxControl.TabIndex = 5;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "操作选项";
            // 
            // tableLayoutControl
            // 
            tableLayoutControl.AutoSize = true;
            tableLayoutControl.ColumnCount = 9;
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutControl.Controls.Add(button8, 1, 0);
            tableLayoutControl.Controls.Add(buttonRefresh, 0, 0);
            tableLayoutControl.Controls.Add(button9, 2, 0);
            tableLayoutControl.Controls.Add(button10, 3, 0);
            tableLayoutControl.Dock = DockStyle.Fill;
            tableLayoutControl.Location = new Point(3, 19);
            tableLayoutControl.Name = "tableLayoutControl";
            tableLayoutControl.RowCount = 1;
            tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutControl.Size = new Size(648, 40);
            tableLayoutControl.TabIndex = 5;
            // 
            // button8
            // 
            button8.Location = new Point(84, 3);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 6;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(3, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "button7";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(165, 3);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 7;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(246, 3);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 8;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // groupBoxControl2
            // 
            groupBoxControl2.AutoSize = true;
            groupBoxControl2.Controls.Add(tableLayoutControl2);
            groupBoxControl2.Dock = DockStyle.Fill;
            groupBoxControl2.Location = new Point(663, 62);
            groupBoxControl2.Margin = new Padding(3, 0, 3, 0);
            groupBoxControl2.Name = "groupBoxControl2";
            groupBoxControl2.Size = new Size(118, 413);
            groupBoxControl2.TabIndex = 5;
            groupBoxControl2.TabStop = false;
            groupBoxControl2.Text = "groupBox2";
            // 
            // tableLayoutControl2
            // 
            tableLayoutControl2.AutoSize = true;
            tableLayoutControl2.ColumnCount = 1;
            tableLayoutControl2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutControl2.Controls.Add(button6, 0, 5);
            tableLayoutControl2.Controls.Add(button5, 0, 4);
            tableLayoutControl2.Controls.Add(button4, 0, 3);
            tableLayoutControl2.Controls.Add(button3, 0, 2);
            tableLayoutControl2.Controls.Add(button2, 0, 1);
            tableLayoutControl2.Controls.Add(button1, 0, 0);
            tableLayoutControl2.Dock = DockStyle.Fill;
            tableLayoutControl2.Location = new Point(3, 19);
            tableLayoutControl2.Name = "tableLayoutControl2";
            tableLayoutControl2.RowCount = 6;
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.RowStyles.Add(new RowStyle());
            tableLayoutControl2.Size = new Size(112, 391);
            tableLayoutControl2.TabIndex = 5;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(3, 148);
            button6.Name = "button6";
            button6.Size = new Size(106, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(3, 119);
            button5.Name = "button5";
            button5.Size = new Size(106, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(3, 90);
            button4.Name = "button4";
            button4.Size = new Size(106, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(3, 61);
            button3.Name = "button3";
            button3.Size = new Size(106, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 0;
            button1.Text = "导入AE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // groupBoxPicture
            // 
            groupBoxPicture.AutoSize = true;
            groupBoxPicture.Controls.Add(flowLayoutPanel1);
            groupBoxPicture.Dock = DockStyle.Fill;
            groupBoxPicture.Location = new Point(3, 62);
            groupBoxPicture.Margin = new Padding(3, 0, 3, 0);
            groupBoxPicture.Name = "groupBoxPicture";
            groupBoxPicture.Size = new Size(654, 413);
            groupBoxPicture.TabIndex = 0;
            groupBoxPicture.TabStop = false;
            groupBoxPicture.Text = "groupBox1";
            // 
            // groupBoxUserInfo
            // 
            groupBoxUserInfo.AutoSize = true;
            groupBoxUserInfo.Controls.Add(tableLayoutPanelUserInfo);
            groupBoxUserInfo.Dock = DockStyle.Fill;
            groupBoxUserInfo.Location = new Point(663, 3);
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Size = new Size(118, 56);
            groupBoxUserInfo.TabIndex = 6;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "用户信息";
            // 
            // tableLayoutPanelUserInfo
            // 
            tableLayoutPanelUserInfo.AutoSize = true;
            tableLayoutPanelUserInfo.ColumnCount = 2;
            tableLayoutPanelUserInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelUserInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelUserInfo.Controls.Add(labelUserInfoUsername2, 1, 0);
            tableLayoutPanelUserInfo.Controls.Add(labelUserInfoStatus, 0, 1);
            tableLayoutPanelUserInfo.Controls.Add(labelUserInfoStatus2, 1, 1);
            tableLayoutPanelUserInfo.Controls.Add(labelUserInfoUsername, 0, 0);
            tableLayoutPanelUserInfo.Dock = DockStyle.Fill;
            tableLayoutPanelUserInfo.Location = new Point(3, 19);
            tableLayoutPanelUserInfo.Name = "tableLayoutPanelUserInfo";
            tableLayoutPanelUserInfo.RowCount = 2;
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle());
            tableLayoutPanelUserInfo.RowStyles.Add(new RowStyle());
            tableLayoutPanelUserInfo.Size = new Size(112, 34);
            tableLayoutPanelUserInfo.TabIndex = 1;
            // 
            // labelUserInfoUsername2
            // 
            labelUserInfoUsername2.AutoSize = true;
            labelUserInfoUsername2.BackColor = SystemColors.Control;
            labelUserInfoUsername2.Location = new Point(65, 0);
            labelUserInfoUsername2.Name = "labelUserInfoUsername2";
            labelUserInfoUsername2.Size = new Size(40, 17);
            labelUserInfoUsername2.TabIndex = 1;
            labelUserInfoUsername2.Text = "user1";
            // 
            // labelUserInfoStatus
            // 
            labelUserInfoStatus.AutoSize = true;
            labelUserInfoStatus.BackColor = SystemColors.Control;
            labelUserInfoStatus.Location = new Point(3, 17);
            labelUserInfoStatus.Name = "labelUserInfoStatus";
            labelUserInfoStatus.Size = new Size(56, 17);
            labelUserInfoStatus.TabIndex = 2;
            labelUserInfoStatus.Text = "状   态：";
            // 
            // labelUserInfoStatus2
            // 
            labelUserInfoStatus2.AutoSize = true;
            labelUserInfoStatus2.BackColor = SystemColors.Control;
            labelUserInfoStatus2.ForeColor = Color.Red;
            labelUserInfoStatus2.Location = new Point(65, 17);
            labelUserInfoStatus2.Name = "labelUserInfoStatus2";
            labelUserInfoStatus2.Size = new Size(44, 17);
            labelUserInfoStatus2.TabIndex = 3;
            labelUserInfoStatus2.Text = "未登录";
            // 
            // labelUserInfoUsername
            // 
            labelUserInfoUsername.AutoSize = true;
            labelUserInfoUsername.Location = new Point(3, 0);
            labelUserInfoUsername.Name = "labelUserInfoUsername";
            labelUserInfoUsername.Size = new Size(56, 17);
            labelUserInfoUsername.TabIndex = 0;
            labelUserInfoUsername.Text = "用户名：";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(menuStrip, 0, 0);
            tableLayoutMain.Controls.Add(statusStrip, 0, 2);
            tableLayoutMain.Controls.Add(tableLayoutContent, 0, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle());
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle());
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(784, 521);
            tableLayoutMain.TabIndex = 35;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 521);
            Controls.Add(tableLayoutMain);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(600, 420);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "序列图片管理器";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutContent.ResumeLayout(false);
            tableLayoutContent.PerformLayout();
            groupBoxControl.ResumeLayout(false);
            groupBoxControl.PerformLayout();
            tableLayoutControl.ResumeLayout(false);
            groupBoxControl2.ResumeLayout(false);
            groupBoxControl2.PerformLayout();
            tableLayoutControl2.ResumeLayout(false);
            groupBoxPicture.ResumeLayout(false);
            groupBoxPicture.PerformLayout();
            groupBoxUserInfo.ResumeLayout(false);
            groupBoxUserInfo.PerformLayout();
            tableLayoutPanelUserInfo.ResumeLayout(false);
            tableLayoutPanelUserInfo.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemFile;
        private ToolStripMenuItem menuItemImport;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutContent;
        private TableLayoutPanel tableLayoutControl2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBoxControl2;
        private GroupBox groupBoxPicture;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutControl;
        private Button buttonRefresh;
        private Button button10;
        private Button button9;
        private Button button8;
        private GroupBox groupBoxControl;
        private ToolStripMenuItem menuItem1;
        private ToolStripMenuItem menuItemSetting;
        private ToolStripMenuItem menuItemQuit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem menuItemRename;
        private ToolStripMenuItem menuItemDelete;
        private ToolStripMenuItem menuItemHelp;
        private ToolStripMenuItem menuItemAbout;
        private GroupBox groupBoxUserInfo;
        private TableLayoutPanel tableLayoutPanelUserInfo;
        private Label labelUserInfoUsername;
        private Label labelUserInfoStatus;
        private Label labelUserInfoStatus2;
        private Label labelUserInfoUsername2;
    }
}
