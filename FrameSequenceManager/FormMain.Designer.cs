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
            menuItemSetting = new ToolStripMenuItem();
            menuItemQuit = new ToolStripMenuItem();
            menuItemEdit = new ToolStripMenuItem();
            menuItemHelp = new ToolStripMenuItem();
            menuItemAbout = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutContent = new TableLayoutPanel();
            groupBoxControl = new GroupBox();
            tableLayoutControl = new TableLayoutPanel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            groupBoxControl2 = new GroupBox();
            tableLayoutControl2 = new TableLayoutPanel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBoxPicture = new GroupBox();
            tableLayoutMain = new TableLayoutPanel();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            tableLayoutContent.SuspendLayout();
            groupBoxControl.SuspendLayout();
            tableLayoutControl.SuspendLayout();
            groupBoxControl2.SuspendLayout();
            tableLayoutControl2.SuspendLayout();
            groupBoxPicture.SuspendLayout();
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
            menuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemImport, menuItemSetting, menuItemQuit });
            menuItemFile.Name = "menuItemFile";
            menuItemFile.Size = new Size(44, 24);
            menuItemFile.Text = "文件";
            // 
            // menuItemImport
            // 
            menuItemImport.Name = "menuItemImport";
            menuItemImport.Size = new Size(180, 22);
            menuItemImport.Text = "导入";
            // 
            // menuItemSetting
            // 
            menuItemSetting.Name = "menuItemSetting";
            menuItemSetting.Size = new Size(180, 22);
            menuItemSetting.Text = "设置";
            menuItemSetting.Click += MenuItemSetting_Click;
            // 
            // menuItemQuit
            // 
            menuItemQuit.Name = "menuItemQuit";
            menuItemQuit.Size = new Size(180, 22);
            menuItemQuit.Text = "退出";
            menuItemQuit.Click += MenuItemQuit_Click;
            // 
            // menuItemEdit
            // 
            menuItemEdit.Name = "menuItemEdit";
            menuItemEdit.Size = new Size(44, 24);
            menuItemEdit.Text = "编辑";
            // 
            // menuItemHelp
            // 
            menuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout });
            menuItemHelp.Name = "menuItemHelp";
            menuItemHelp.ShortcutKeyDisplayString = "";
            menuItemHelp.Size = new Size(44, 24);
            menuItemHelp.Text = "帮助";
            // 
            // menuItemAbout
            // 
            menuItemAbout.Name = "menuItemAbout";
            menuItemAbout.ShortcutKeyDisplayString = "";
            menuItemAbout.Size = new Size(100, 22);
            menuItemAbout.Text = "关于";
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
            flowLayoutPanel1.Size = new Size(679, 373);
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
            tableLayoutContent.SetColumnSpan(groupBoxControl, 2);
            groupBoxControl.Controls.Add(tableLayoutControl);
            groupBoxControl.Dock = DockStyle.Fill;
            groupBoxControl.Location = new Point(3, 0);
            groupBoxControl.Margin = new Padding(3, 0, 3, 0);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(778, 80);
            groupBoxControl.TabIndex = 5;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "groupBox1";
            // 
            // tableLayoutControl
            // 
            tableLayoutControl.AutoSize = true;
            tableLayoutControl.ColumnCount = 2;
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
            tableLayoutControl.Controls.Add(button10, 1, 1);
            tableLayoutControl.Controls.Add(button9, 0, 1);
            tableLayoutControl.Controls.Add(button8, 1, 0);
            tableLayoutControl.Controls.Add(button7, 0, 0);
            tableLayoutControl.Dock = DockStyle.Fill;
            tableLayoutControl.Location = new Point(3, 19);
            tableLayoutControl.Name = "tableLayoutControl";
            tableLayoutControl.RowCount = 2;
            tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutControl.Size = new Size(772, 58);
            tableLayoutControl.TabIndex = 5;
            // 
            // button10
            // 
            button10.Location = new Point(84, 32);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 8;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(3, 32);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 7;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
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
            // button7
            // 
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 5;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBoxControl2
            // 
            groupBoxControl2.AutoSize = true;
            groupBoxControl2.Controls.Add(tableLayoutControl2);
            groupBoxControl2.Dock = DockStyle.Right;
            groupBoxControl2.Location = new Point(694, 80);
            groupBoxControl2.Margin = new Padding(3, 0, 3, 0);
            groupBoxControl2.Name = "groupBoxControl2";
            groupBoxControl2.Size = new Size(87, 395);
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
            tableLayoutControl2.Size = new Size(81, 373);
            tableLayoutControl2.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(3, 148);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 119);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 90);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 32);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
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
            groupBoxPicture.Location = new Point(3, 80);
            groupBoxPicture.Margin = new Padding(3, 0, 3, 0);
            groupBoxPicture.Name = "groupBoxPicture";
            groupBoxPicture.Size = new Size(685, 395);
            groupBoxPicture.TabIndex = 0;
            groupBoxPicture.TabStop = false;
            groupBoxPicture.Text = "groupBox1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 521);
            Controls.Add(tableLayoutMain);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(600, 420);
            Name = "Form1";
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
        private ToolStripMenuItem menuItemEdit;
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
        private Button button7;
        private Button button10;
        private Button button9;
        private Button button8;
        private GroupBox groupBoxControl;
        private ToolStripMenuItem menuItem1;
        private ToolStripMenuItem menuItemHelp;
        private ToolStripMenuItem menuItemAbout;
        private ToolStripMenuItem menuItemSetting;
        private ToolStripMenuItem menuItemQuit;
    }
}
