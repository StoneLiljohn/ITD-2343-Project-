namespace Week2_Littlejohn_Project
{
    partial class frmFall2025
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            headerLabel = new Label();
            inputBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            exitBtn = new Button();
            saveBtn = new Button();
            wipeBtn = new Button();
            cancelBtn = new Button();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            midLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(headerLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(inputBox, 1, 0);
            tableLayoutPanel1.Location = new Point(1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(800, 41);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Segoe UI", 16F);
            headerLabel.Location = new Point(3, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(294, 41);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Enter Text Here";
            headerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputBox
            // 
            inputBox.Dock = DockStyle.Fill;
            inputBox.Font = new Font("Segoe UI", 16F);
            inputBox.Location = new Point(303, 3);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(494, 36);
            inputBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(exitBtn, 3, 0);
            tableLayoutPanel2.Controls.Add(saveBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(wipeBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(cancelBtn, 2, 0);
            tableLayoutPanel2.Location = new Point(1, 400);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 52);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.None;
            exitBtn.BackColor = Color.Yellow;
            exitBtn.ForeColor = Color.Gray;
            exitBtn.Location = new Point(625, 11);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(150, 30);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.BackColor = Color.MistyRose;
            saveBtn.Location = new Point(225, 11);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(150, 30);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "&Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // wipeBtn
            // 
            wipeBtn.Anchor = AnchorStyles.None;
            wipeBtn.BackColor = SystemColors.Window;
            wipeBtn.Location = new Point(25, 11);
            wipeBtn.Name = "wipeBtn";
            wipeBtn.Size = new Size(150, 30);
            wipeBtn.TabIndex = 0;
            wipeBtn.Text = "&Wipe Clear";
            wipeBtn.UseVisualStyleBackColor = false;
            wipeBtn.Click += wipeBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.None;
            cancelBtn.BackColor = Color.DimGray;
            cancelBtn.ForeColor = Color.Yellow;
            cancelBtn.Location = new Point(425, 11);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(150, 30);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Can&cel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(289, 169);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(midLabel, 0, 0);
            tableLayoutPanel3.Location = new Point(1, 44);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(800, 350);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // midLabel
            // 
            midLabel.Dock = DockStyle.Fill;
            midLabel.Font = new Font("Leelawadee UI", 32F);
            midLabel.Location = new Point(3, 0);
            midLabel.Name = "midLabel";
            midLabel.Size = new Size(794, 350);
            midLabel.TabIndex = 0;
            midLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmFall2025
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmFall2025";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFall2025";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label headerLabel;
        private TextBox inputBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button cancelBtn;
        private Button exitBtn;
        private Button saveBtn;
        private Button wipeBtn;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label midLabel;
    }
}
