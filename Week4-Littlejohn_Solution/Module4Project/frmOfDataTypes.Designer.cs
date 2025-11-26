namespace Module4Project
{
    partial class frmOfDataTypes
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
            exitBtn = new Button();
            sqrtBtn = new Button();
            roundBtn = new Button();
            powBtn = new Button();
            clearBtn = new Button();
            decimalBtn = new Button();
            doubleBtn = new Button();
            floatBtn = new Button();
            longBtn = new Button();
            intBtn = new Button();
            shortBtn = new Button();
            byteBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(exitBtn, 3, 2);
            tableLayoutPanel1.Controls.Add(sqrtBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(roundBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(powBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(clearBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(decimalBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(doubleBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(floatBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(longBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(intBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(shortBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(byteBtn, 0, 0);
            tableLayoutPanel1.Location = new Point(159, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(499, 151);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Black;
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Font = new Font("Segoe UI", 12F);
            exitBtn.ForeColor = Color.DarkSalmon;
            exitBtn.Location = new Point(375, 103);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(121, 45);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // sqrtBtn
            // 
            sqrtBtn.BackColor = Color.Pink;
            sqrtBtn.Dock = DockStyle.Fill;
            sqrtBtn.Font = new Font("Segoe UI", 12F);
            sqrtBtn.Location = new Point(251, 103);
            sqrtBtn.Name = "sqrtBtn";
            sqrtBtn.Size = new Size(118, 45);
            sqrtBtn.TabIndex = 10;
            sqrtBtn.Text = "S&qaure Root";
            sqrtBtn.UseVisualStyleBackColor = false;
            sqrtBtn.Click += sqrtBtn_Click;
            // 
            // roundBtn
            // 
            roundBtn.BackColor = Color.Pink;
            roundBtn.Dock = DockStyle.Fill;
            roundBtn.Font = new Font("Segoe UI", 12F);
            roundBtn.Location = new Point(127, 103);
            roundBtn.Name = "roundBtn";
            roundBtn.Size = new Size(118, 45);
            roundBtn.TabIndex = 9;
            roundBtn.Text = "&Round";
            roundBtn.UseVisualStyleBackColor = false;
            roundBtn.Click += roundBtn_Click;
            // 
            // powBtn
            // 
            powBtn.BackColor = Color.Pink;
            powBtn.Dock = DockStyle.Fill;
            powBtn.Font = new Font("Segoe UI", 12F);
            powBtn.Location = new Point(3, 103);
            powBtn.Name = "powBtn";
            powBtn.Size = new Size(118, 45);
            powBtn.TabIndex = 8;
            powBtn.Text = "E&xponent";
            powBtn.UseVisualStyleBackColor = false;
            powBtn.Click += powBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.DarkSalmon;
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 12F);
            clearBtn.Location = new Point(375, 53);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(121, 44);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "&Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // decimalBtn
            // 
            decimalBtn.BackColor = Color.PaleTurquoise;
            decimalBtn.Dock = DockStyle.Fill;
            decimalBtn.Font = new Font("Segoe UI", 12F);
            decimalBtn.Location = new Point(251, 53);
            decimalBtn.Name = "decimalBtn";
            decimalBtn.Size = new Size(118, 44);
            decimalBtn.TabIndex = 6;
            decimalBtn.Text = "D&ecimal";
            decimalBtn.UseVisualStyleBackColor = false;
            decimalBtn.Click += decimalBtn_Click;
            // 
            // doubleBtn
            // 
            doubleBtn.BackColor = Color.PaleTurquoise;
            doubleBtn.Dock = DockStyle.Fill;
            doubleBtn.Font = new Font("Segoe UI", 12F);
            doubleBtn.Location = new Point(127, 53);
            doubleBtn.Name = "doubleBtn";
            doubleBtn.Size = new Size(118, 44);
            doubleBtn.TabIndex = 5;
            doubleBtn.Text = "&Double";
            doubleBtn.UseVisualStyleBackColor = false;
            doubleBtn.Click += doubleBtn_Click;
            // 
            // floatBtn
            // 
            floatBtn.BackColor = Color.PaleTurquoise;
            floatBtn.Dock = DockStyle.Fill;
            floatBtn.Font = new Font("Segoe UI", 12F);
            floatBtn.Location = new Point(3, 53);
            floatBtn.Name = "floatBtn";
            floatBtn.Size = new Size(118, 44);
            floatBtn.TabIndex = 4;
            floatBtn.Text = "&Float";
            floatBtn.UseVisualStyleBackColor = false;
            floatBtn.Click += floatBtn_Click;
            // 
            // longBtn
            // 
            longBtn.BackColor = Color.PaleGreen;
            longBtn.Dock = DockStyle.Fill;
            longBtn.Font = new Font("Segoe UI", 12F);
            longBtn.Location = new Point(375, 3);
            longBtn.Name = "longBtn";
            longBtn.Size = new Size(121, 44);
            longBtn.TabIndex = 3;
            longBtn.Text = "&Long";
            longBtn.UseVisualStyleBackColor = false;
            longBtn.Click += longBtn_Click;
            // 
            // intBtn
            // 
            intBtn.BackColor = Color.PaleGreen;
            intBtn.Dock = DockStyle.Fill;
            intBtn.Font = new Font("Segoe UI", 12F);
            intBtn.Location = new Point(251, 3);
            intBtn.Name = "intBtn";
            intBtn.Size = new Size(118, 44);
            intBtn.TabIndex = 2;
            intBtn.Text = "&Int";
            intBtn.UseVisualStyleBackColor = false;
            intBtn.Click += intBtn_Click;
            // 
            // shortBtn
            // 
            shortBtn.BackColor = Color.PaleGreen;
            shortBtn.Dock = DockStyle.Fill;
            shortBtn.Font = new Font("Segoe UI", 12F);
            shortBtn.Location = new Point(127, 3);
            shortBtn.Name = "shortBtn";
            shortBtn.Size = new Size(118, 44);
            shortBtn.TabIndex = 1;
            shortBtn.Text = "&Short";
            shortBtn.UseVisualStyleBackColor = false;
            shortBtn.Click += shortBtn_Click;
            // 
            // byteBtn
            // 
            byteBtn.BackColor = Color.PaleGreen;
            byteBtn.Dock = DockStyle.Fill;
            byteBtn.Font = new Font("Segoe UI", 12F);
            byteBtn.Location = new Point(3, 3);
            byteBtn.Name = "byteBtn";
            byteBtn.Size = new Size(118, 44);
            byteBtn.TabIndex = 0;
            byteBtn.Text = "&Byte";
            byteBtn.UseVisualStyleBackColor = false;
            byteBtn.Click += byteBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSteelBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 224);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(159, 248);
            label2.Name = "label2";
            label2.Size = new Size(499, 39);
            label2.TabIndex = 2;
            label2.Text = "Example Calculations using these variable types";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // frmOfDataTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "frmOfDataTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Week 4 - Data Types";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button byteBtn;
        private Button sqrtBtn;
        private Button roundBtn;
        private Button powBtn;
        private Button clearBtn;
        private Button decimalBtn;
        private Button doubleBtn;
        private Button floatBtn;
        private Button longBtn;
        private Button intBtn;
        private Button shortBtn;
        private Button exitBtn;
        private Label label1;
        private Label label2;
    }
}
