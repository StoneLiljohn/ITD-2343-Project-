namespace LittlejohnWeek7Lab
{
    partial class Form1
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
            proBtn = new Button();
            clrBtn = new Button();
            button4 = new Button();
            sixBtn = new Button();
            octBtn = new Button();
            hexBtn = new Button();
            binBtn = new Button();
            baseTxtbox = new TextBox();
            enterTxtbox = new TextBox();
            resultLbl = new Label();
            exitBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.Controls.Add(proBtn, 7, 0);
            tableLayoutPanel1.Controls.Add(clrBtn, 6, 0);
            tableLayoutPanel1.Controls.Add(button4, 4, 0);
            tableLayoutPanel1.Controls.Add(sixBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(octBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(hexBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(binBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(baseTxtbox, 5, 0);
            tableLayoutPanel1.Location = new Point(1, 243);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(799, 92);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // proBtn
            // 
            proBtn.BackColor = Color.FromArgb(128, 255, 128);
            tableLayoutPanel1.SetColumnSpan(proBtn, 2);
            proBtn.Dock = DockStyle.Fill;
            proBtn.Font = new Font("Segoe UI", 14F);
            proBtn.Location = new Point(619, 3);
            proBtn.Name = "proBtn";
            proBtn.Size = new Size(177, 86);
            proBtn.TabIndex = 11;
            proBtn.Text = "&Process";
            proBtn.UseVisualStyleBackColor = false;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.FromArgb(255, 255, 128);
            clrBtn.Dock = DockStyle.Fill;
            clrBtn.Font = new Font("Segoe UI", 14F);
            clrBtn.Location = new Point(531, 3);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(82, 86);
            clrBtn.TabIndex = 10;
            clrBtn.Text = "&Clear";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(355, 3);
            button4.Name = "button4";
            button4.Size = new Size(82, 86);
            button4.TabIndex = 4;
            button4.Text = "Bas&e 9";
            button4.UseVisualStyleBackColor = false;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = SystemColors.InactiveCaption;
            sixBtn.Dock = DockStyle.Fill;
            sixBtn.Font = new Font("Segoe UI", 14F);
            sixBtn.Location = new Point(267, 3);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(82, 86);
            sixBtn.TabIndex = 3;
            sixBtn.Text = "Ba&se 6";
            sixBtn.UseVisualStyleBackColor = false;
            // 
            // octBtn
            // 
            octBtn.BackColor = SystemColors.InactiveCaption;
            octBtn.Dock = DockStyle.Fill;
            octBtn.Font = new Font("Segoe UI", 14F);
            octBtn.Location = new Point(179, 3);
            octBtn.Name = "octBtn";
            octBtn.Size = new Size(82, 86);
            octBtn.TabIndex = 2;
            octBtn.Text = "&Octal";
            octBtn.UseVisualStyleBackColor = false;
            // 
            // hexBtn
            // 
            hexBtn.BackColor = SystemColors.InactiveCaption;
            hexBtn.Dock = DockStyle.Fill;
            hexBtn.Font = new Font("Segoe UI", 14F);
            hexBtn.Location = new Point(91, 3);
            hexBtn.Name = "hexBtn";
            hexBtn.Size = new Size(82, 86);
            hexBtn.TabIndex = 1;
            hexBtn.Text = "&Hex";
            hexBtn.UseVisualStyleBackColor = false;
            // 
            // binBtn
            // 
            binBtn.BackColor = SystemColors.InactiveCaption;
            binBtn.Dock = DockStyle.Fill;
            binBtn.Font = new Font("Segoe UI", 14F);
            binBtn.Location = new Point(3, 3);
            binBtn.Name = "binBtn";
            binBtn.Size = new Size(82, 86);
            binBtn.TabIndex = 0;
            binBtn.Text = "&Binary ";
            binBtn.UseVisualStyleBackColor = false;
            // 
            // baseTxtbox
            // 
            baseTxtbox.BackColor = SystemColors.InactiveCaption;
            baseTxtbox.Dock = DockStyle.Fill;
            baseTxtbox.Font = new Font("Segoe UI", 14F);
            baseTxtbox.Location = new Point(443, 3);
            baseTxtbox.Multiline = true;
            baseTxtbox.Name = "baseTxtbox";
            baseTxtbox.Size = new Size(82, 86);
            baseTxtbox.TabIndex = 12;
            baseTxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // enterTxtbox
            // 
            enterTxtbox.Font = new Font("Segoe UI", 14F);
            enterTxtbox.Location = new Point(21, 172);
            enterTxtbox.Name = "enterTxtbox";
            enterTxtbox.Size = new Size(760, 32);
            enterTxtbox.TabIndex = 2;
            enterTxtbox.Text = " ";
            // 
            // resultLbl
            // 
            resultLbl.BackColor = SystemColors.ScrollBar;
            resultLbl.Font = new Font("Segoe UI", 14F);
            resultLbl.Location = new Point(21, 20);
            resultLbl.Margin = new Padding(10, 0, 10, 0);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(760, 42);
            resultLbl.TabIndex = 1;
            resultLbl.Text = "Result will show up here";
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            resultLbl.Click += resultLbl_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 128);
            exitBtn.Location = new Point(21, 398);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(101, 40);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(enterTxtbox);
            Controls.Add(resultLbl);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Base-10 to Base-X";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button sixBtn;
        private Button octBtn;
        private Button hexBtn;
        private Button binBtn;
        private Button clrBtn;
        private Button proBtn;
        private TextBox baseTxtbox;
        private TextBox enterTxtbox;
        private Label resultLbl;
        private Button exitBtn;
    }
}
