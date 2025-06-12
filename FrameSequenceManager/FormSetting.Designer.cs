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
            buttonAePathAuto = new Button();
            labelAePath = new Label();
            textBoxAePath = new TextBox();
            buttonAePathChoose = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonAePathAuto, 2, 0);
            tableLayoutPanel1.Controls.Add(labelAePath, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxAePath, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAePathChoose, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(584, 261);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAePathAuto
            // 
            buttonAePathAuto.Location = new Point(425, 3);
            buttonAePathAuto.Name = "buttonAePathAuto";
            buttonAePathAuto.Size = new Size(75, 23);
            buttonAePathAuto.TabIndex = 3;
            buttonAePathAuto.Text = "自动读取";
            buttonAePathAuto.UseVisualStyleBackColor = true;
            buttonAePathAuto.Click += ButtonAePathAuto_Click;
            // 
            // labelAePath
            // 
            labelAePath.AutoSize = true;
            labelAePath.Location = new Point(3, 3);
            labelAePath.Margin = new Padding(3, 3, 3, 0);
            labelAePath.Name = "labelAePath";
            labelAePath.Padding = new Padding(0, 3, 0, 0);
            labelAePath.Size = new Size(50, 20);
            labelAePath.TabIndex = 0;
            labelAePath.Text = "AE路径:";
            labelAePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAePath
            // 
            textBoxAePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAePath.Location = new Point(59, 3);
            textBoxAePath.Name = "textBoxAePath";
            textBoxAePath.Size = new Size(360, 23);
            textBoxAePath.TabIndex = 1;
            // 
            // buttonAePathChoose
            // 
            buttonAePathChoose.Location = new Point(506, 3);
            buttonAePathChoose.Name = "buttonAePathChoose";
            buttonAePathChoose.Size = new Size(75, 23);
            buttonAePathChoose.TabIndex = 2;
            buttonAePathChoose.Text = "手动选择";
            buttonAePathChoose.UseVisualStyleBackColor = true;
            buttonAePathChoose.Click += ButtonAePathChoose_Click;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormSetting";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "设置";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAePathAuto;
        private Label labelAePath;
        private TextBox textBoxAePath;
        private Button buttonAePathChoose;
    }
}