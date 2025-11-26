using System.Drawing;

namespace LittlejohnLab_Project
{
    /*
    Name: Stone Littlejohn
    Class: ITD 2343 – Object Oriented Programming with C#
    Due Date: 09/23/2025
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            lblTheDominator = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            brownBtn = new Button();
            goldBtn = new Button();
            greenBtn = new Button();
            pinkBtn = new Button();
            violetBtn = new Button();
            indigoBtn = new Button();
            blueBtn = new Button();
            orangeBtn = new Button();
            redBtn = new Button();
            exitBtn = new Button();
            clearBtn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTheDominator, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(534, 761);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btn9, 2, 2);
            tableLayoutPanel2.Controls.Add(btn8, 1, 2);
            tableLayoutPanel2.Controls.Add(btn7, 0, 2);
            tableLayoutPanel2.Controls.Add(btn6, 2, 1);
            tableLayoutPanel2.Controls.Add(btn5, 1, 1);
            tableLayoutPanel2.Controls.Add(btn4, 0, 1);
            tableLayoutPanel2.Controls.Add(btn3, 2, 0);
            tableLayoutPanel2.Controls.Add(btn2, 1, 0);
            tableLayoutPanel2.Controls.Add(btn1, 0, 0);
            tableLayoutPanel2.Location = new Point(90, 463);
            tableLayoutPanel2.Margin = new Padding(90, 3, 90, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(354, 224);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonHighlight;
            btn9.Dock = DockStyle.Fill;
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(256, 168);
            btn9.Margin = new Padding(20);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 36);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.Dock = DockStyle.Fill;
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(138, 168);
            btn8.Margin = new Padding(20);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 36);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Dock = DockStyle.Fill;
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(20, 168);
            btn7.Margin = new Padding(20);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 36);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonHighlight;
            btn6.Dock = DockStyle.Fill;
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(256, 94);
            btn6.Margin = new Padding(20);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 34);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.Dock = DockStyle.Fill;
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(138, 94);
            btn5.Margin = new Padding(20);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 34);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.Dock = DockStyle.Fill;
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(20, 94);
            btn4.Margin = new Padding(20);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 34);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonHighlight;
            btn3.Dock = DockStyle.Fill;
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(256, 20);
            btn3.Margin = new Padding(20);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 34);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.Dock = DockStyle.Fill;
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(138, 20);
            btn2.Margin = new Padding(20);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 34);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.Dock = DockStyle.Fill;
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(20, 20);
            btn1.Margin = new Padding(20);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 34);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // lblTheDominator
            // 
            lblTheDominator.AutoSize = true;
            lblTheDominator.Dock = DockStyle.Fill;
            lblTheDominator.Font = new Font("Segoe UI", 120F);
            lblTheDominator.Location = new Point(50, 230);
            lblTheDominator.Margin = new Padding(50, 0, 50, 0);
            lblTheDominator.Name = "lblTheDominator";
            lblTheDominator.Size = new Size(434, 230);
            lblTheDominator.TabIndex = 1;
            lblTheDominator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(brownBtn, 2, 2);
            tableLayoutPanel3.Controls.Add(goldBtn, 1, 2);
            tableLayoutPanel3.Controls.Add(greenBtn, 0, 2);
            tableLayoutPanel3.Controls.Add(pinkBtn, 2, 1);
            tableLayoutPanel3.Controls.Add(violetBtn, 1, 1);
            tableLayoutPanel3.Controls.Add(indigoBtn, 0, 1);
            tableLayoutPanel3.Controls.Add(blueBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(orangeBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(redBtn, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(90, 3);
            tableLayoutPanel3.Margin = new Padding(90, 3, 90, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(354, 224);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // brownBtn 
            // 
            brownBtn.BackColor = Color.SaddleBrown;
            brownBtn.Dock = DockStyle.Fill;
            brownBtn.ForeColor = SystemColors.ActiveCaptionText;
            brownBtn.Location = new Point(256, 168);
            brownBtn.Margin = new Padding(20);
            brownBtn.Name = "brownBtn";
            brownBtn.Size = new Size(78, 36);
            brownBtn.TabIndex = 16;
            brownBtn.UseVisualStyleBackColor = false;
            brownBtn.Click += brownBtn_Click;
            // 
            // goldBtn
            // 
            goldBtn.BackColor = Color.Gold;
            goldBtn.Dock = DockStyle.Fill;
            goldBtn.ForeColor = SystemColors.ActiveCaptionText;
            goldBtn.Location = new Point(138, 168);
            goldBtn.Margin = new Padding(20);
            goldBtn.Name = "goldBtn";
            goldBtn.Size = new Size(78, 36);
            goldBtn.TabIndex = 15;
            goldBtn.UseVisualStyleBackColor = false;
            goldBtn.Click += goldBtn_Click;
            // 
            // greenBtn
            // 
            greenBtn.BackColor = Color.Green;
            greenBtn.Dock = DockStyle.Fill;
            greenBtn.ForeColor = SystemColors.ActiveCaptionText;
            greenBtn.Location = new Point(20, 168);
            greenBtn.Margin = new Padding(20);
            greenBtn.Name = "greenBtn";
            greenBtn.Size = new Size(78, 36);
            greenBtn.TabIndex = 14;
            greenBtn.UseVisualStyleBackColor = false;
            greenBtn.Click += greenBtn_Click;
            // 
            // pinkBtn
            // 
            pinkBtn.BackColor = Color.Pink;
            pinkBtn.Dock = DockStyle.Fill;
            pinkBtn.ForeColor = SystemColors.ActiveCaptionText;
            pinkBtn.Location = new Point(256, 94);
            pinkBtn.Margin = new Padding(20);
            pinkBtn.Name = "pinkBtn";
            pinkBtn.Size = new Size(78, 34);
            pinkBtn.TabIndex = 13;
            pinkBtn.UseVisualStyleBackColor = false;
            pinkBtn.Click += pinkBtn_Click;
            // 
            // violetBtn
            // 
            violetBtn.BackColor = Color.Violet;
            violetBtn.Dock = DockStyle.Fill;
            violetBtn.ForeColor = SystemColors.ActiveCaptionText;
            violetBtn.Location = new Point(138, 94);
            violetBtn.Margin = new Padding(20);
            violetBtn.Name = "violetBtn";
            violetBtn.Size = new Size(78, 34);
            violetBtn.TabIndex = 12;
            violetBtn.UseVisualStyleBackColor = false;
            violetBtn.Click += violetBtn_Click;
            // 
            // indigoBtn
            // 
            indigoBtn.BackColor = Color.Indigo;
            indigoBtn.Dock = DockStyle.Fill;
            indigoBtn.ForeColor = SystemColors.ActiveCaptionText;
            indigoBtn.Location = new Point(20, 94);
            indigoBtn.Margin = new Padding(20);
            indigoBtn.Name = "indigoBtn";
            indigoBtn.Size = new Size(78, 34);
            indigoBtn.TabIndex = 11;
            indigoBtn.UseVisualStyleBackColor = false;
            indigoBtn.Click += indigoBtn_Click;
            // 
            // blueBtn
            // 
            blueBtn.BackColor = Color.DeepSkyBlue;
            blueBtn.Dock = DockStyle.Fill;
            blueBtn.ForeColor = SystemColors.ActiveCaptionText;
            blueBtn.Location = new Point(256, 20);
            blueBtn.Margin = new Padding(20);
            blueBtn.Name = "blueBtn";
            blueBtn.Size = new Size(78, 34);
            blueBtn.TabIndex = 10;
            blueBtn.UseVisualStyleBackColor = false;
            blueBtn.Click += blueBtn_Click;
            // 
            // orangeBtn
            // 
            orangeBtn.BackColor = Color.OrangeRed;
            orangeBtn.Dock = DockStyle.Fill;
            orangeBtn.ForeColor = SystemColors.ActiveCaptionText;
            orangeBtn.Location = new Point(138, 20);
            orangeBtn.Margin = new Padding(20);
            orangeBtn.Name = "orangeBtn";
            orangeBtn.Size = new Size(78, 34);
            orangeBtn.TabIndex = 9;
            orangeBtn.UseVisualStyleBackColor = false;
            orangeBtn.Click += orangeBtn_Click;
            // 
            // redBtn
            // 
            redBtn.BackColor = Color.Maroon;
            redBtn.Dock = DockStyle.Fill;
            redBtn.ForeColor = SystemColors.ActiveCaptionText;
            redBtn.Location = new Point(20, 20);
            redBtn.Margin = new Padding(20);
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(78, 34);
            redBtn.TabIndex = 0;
            redBtn.UseVisualStyleBackColor = false;
            redBtn.Click += redBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Location = new Point(20, 20);
            exitBtn.Margin = new Padding(20);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(224, 25);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Location = new Point(284, 20);
            clearBtn.Margin = new Padding(20);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(224, 25);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(clearBtn, 1, 0);
            tableLayoutPanel4.Controls.Add(exitBtn, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 693);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(528, 65);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // Form1
            // 
            ClientSize = new Size(534, 761);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);

        }

        private void redBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Maroon;
        private void orangeBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.OrangeRed;
        private void blueBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.DeepSkyBlue;
        private void indigoBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Indigo;
        private void violetBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Violet;
        private void pinkBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Pink;
        private void greenBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Green;
        //This button is setting the label background color to gold
        private void goldBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.Gold;
        //This button is setting the label background color to brown
        private void brownBtn_Click(object sender, EventArgs e) => lblTheDominator.BackColor = Color.SaddleBrown;

        private void btn1_Click(object sender, EventArgs e) => lblTheDominator.Text = "1";
        private void btn2_Click(object sender, EventArgs e) => lblTheDominator.Text = "2";
        private void btn3_Click(object sender, EventArgs e) => lblTheDominator.Text = "3";
        private void btn4_Click(object sender, EventArgs e) => lblTheDominator.Text = "4";
        private void btn5_Click(object sender, EventArgs e) => lblTheDominator.Text = "5";
        private void btn6_Click(object sender, EventArgs e) => lblTheDominator.Text = "6";
        private void btn7_Click(object sender, EventArgs e) => lblTheDominator.Text = "7";
        //This button is setting the label text to 8
        private void btn8_Click(object sender, EventArgs e) => lblTheDominator.Text = "8";
        //This button is setting the label text to 9
        private void btn9_Click(object sender, EventArgs e) => lblTheDominator.Text = "9";

        private void clearBtn_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;
        }

        private void exitBtn_Click(object sender, EventArgs e) => this.Close();
    }
}
