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
            labelLibraryPath = new Label();
            labelAEPath = new Label();
            textBoxAEPath = new TextBox();
            buttonAEPathDetect = new Button();
            buttonAEPathSetting = new Button();
            textBoxLibraryPath = new TextBox();
            buttonLibraryPathOpen = new Button();
            buttonLibraryPathSetting = new Button();
            tabControlLocal = new TabControl();
            tabPageLocal = new TabPage();
            tabPage2 = new TabPage();
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
            tableLayoutPanel1.Controls.Add(labelLibraryPath, 0, 1);
            tableLayoutPanel1.Controls.Add(labelAEPath, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxAEPath, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAEPathDetect, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonAEPathSetting, 3, 0);
            tableLayoutPanel1.Controls.Add(textBoxLibraryPath, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonLibraryPathOpen, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonLibraryPathSetting, 3, 1);
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
        private Label labelAEPath;
        private TextBox textBoxAEPath;
        private TabControl tabControlLocal;
        private TabPage tabPageLocal;
        private TabPage tabPage2;
        private Button buttonAEPathSetting;
        private Button buttonAEPathDetect;
        private TextBox textBoxLibraryPath;
        private Label labelLibraryPath;
        private Button buttonLibraryPathSetting;
        private Button buttonLibraryPathOpen;
    }
}