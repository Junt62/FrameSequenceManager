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
            groupBoxAddressSetting = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBoxAddressSetting.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
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
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(612, 58);
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
            textBoxAEPath.Size = new Size(367, 23);
            textBoxAEPath.TabIndex = 1;
            // 
            // buttonAEPathDetect
            // 
            buttonAEPathDetect.Location = new Point(453, 3);
            buttonAEPathDetect.Name = "buttonAEPathDetect";
            buttonAEPathDetect.Size = new Size(75, 23);
            buttonAEPathDetect.TabIndex = 3;
            buttonAEPathDetect.Text = "自动检测";
            buttonAEPathDetect.UseVisualStyleBackColor = true;
            buttonAEPathDetect.Click += ButtonAEPathDetect_Click;
            // 
            // buttonAEPathSetting
            // 
            buttonAEPathSetting.Location = new Point(534, 3);
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
            textBoxLibraryPath.Size = new Size(367, 23);
            textBoxLibraryPath.TabIndex = 15;
            // 
            // buttonLibraryPathOpen
            // 
            buttonLibraryPathOpen.Location = new Point(453, 32);
            buttonLibraryPathOpen.Name = "buttonLibraryPathOpen";
            buttonLibraryPathOpen.Size = new Size(75, 23);
            buttonLibraryPathOpen.TabIndex = 16;
            buttonLibraryPathOpen.Text = "打开";
            buttonLibraryPathOpen.UseVisualStyleBackColor = true;
            buttonLibraryPathOpen.Click += ButtonLibraryPathOpen_Click;
            // 
            // buttonLibraryPathSetting
            // 
            buttonLibraryPathSetting.Location = new Point(534, 32);
            buttonLibraryPathSetting.Name = "buttonLibraryPathSetting";
            buttonLibraryPathSetting.Size = new Size(75, 23);
            buttonLibraryPathSetting.TabIndex = 17;
            buttonLibraryPathSetting.Text = "设置";
            buttonLibraryPathSetting.UseVisualStyleBackColor = true;
            buttonLibraryPathSetting.Click += ButtonLibraryPathSetting_Click;
            // 
            // groupBoxAddressSetting
            // 
            groupBoxAddressSetting.AutoSize = true;
            groupBoxAddressSetting.Controls.Add(tableLayoutPanel1);
            groupBoxAddressSetting.Dock = DockStyle.Fill;
            groupBoxAddressSetting.Location = new Point(3, 3);
            groupBoxAddressSetting.Name = "groupBoxAddressSetting";
            groupBoxAddressSetting.Size = new Size(618, 80);
            groupBoxAddressSetting.TabIndex = 1;
            groupBoxAddressSetting.TabStop = false;
            groupBoxAddressSetting.Text = "路径设置";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBoxAddressSetting, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(624, 234);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 234);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSetting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBoxAddressSetting.ResumeLayout(false);
            groupBoxAddressSetting.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelAEPath;
        private TextBox textBoxAEPath;
        private Button buttonAEPathSetting;
        private Button buttonAEPathDetect;
        private TextBox textBoxLibraryPath;
        private Label labelLibraryPath;
        private Button buttonLibraryPathSetting;
        private Button buttonLibraryPathOpen;
        private GroupBox groupBoxAddressSetting;
        private TableLayoutPanel tableLayoutPanel2;
    }
}