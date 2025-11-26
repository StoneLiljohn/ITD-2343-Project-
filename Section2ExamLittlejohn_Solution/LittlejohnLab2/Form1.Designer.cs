namespace LittlejohnLab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            modLbl = new Label();
            factLbl = new Label();
            fibLbl = new Label();
            modShwBtn = new Button();
            factShwBtn = new Button();
            fibShwBtn = new Button();
            modDoBtn = new Button();
            factDoBtn = new Button();
            fibDoBtn = new Button();
            firstOp = new TextBox();
            secondOp = new TextBox();
            opsPanel = new TableLayoutPanel();
            messageLbl = new Label();
            clearBtn = new Button();
            exitBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            opsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            tableLayoutPanel1.Controls.Add(modLbl, 0, 0);
            tableLayoutPanel1.Controls.Add(factLbl, 1, 0);
            tableLayoutPanel1.Controls.Add(fibLbl, 2, 0);
            tableLayoutPanel1.Controls.Add(modShwBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(factShwBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(fibShwBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(modDoBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(factDoBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(fibDoBtn, 2, 2);
            tableLayoutPanel1.Location = new Point(210, 140);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(400, 120);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // modLbl
            // 
            modLbl.Font = new Font("Courier New", 14F);
            modLbl.Location = new Point(3, 0);
            modLbl.Name = "modLbl";
            modLbl.Size = new Size(100, 22);
            modLbl.TabIndex = 0;
            modLbl.Text = "Modulus";
            modLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // factLbl
            // 
            factLbl.Font = new Font("Courier New", 14F);
            factLbl.Location = new Point(136, 0);
            factLbl.Name = "factLbl";
            factLbl.Size = new Size(100, 22);
            factLbl.TabIndex = 1;
            factLbl.Text = "Factorial";
            factLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fibLbl
            // 
            fibLbl.Font = new Font("Courier New", 14F);
            fibLbl.Location = new Point(269, 0);
            fibLbl.Name = "fibLbl";
            fibLbl.Size = new Size(100, 22);
            fibLbl.TabIndex = 2;
            fibLbl.Text = "Fibonacci";
            fibLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modShwBtn
            // 
            modShwBtn.BackColor = Color.FromArgb(192, 255, 192);
            modShwBtn.Dock = DockStyle.Fill;
            modShwBtn.Font = new Font("Courier New", 14F);
            modShwBtn.Location = new Point(3, 25);
            modShwBtn.Name = "modShwBtn";
            modShwBtn.Size = new Size(127, 43);
            modShwBtn.TabIndex = 0;
            modShwBtn.Text = "Show";
            modShwBtn.UseVisualStyleBackColor = false;
            // 
            // factShwBtn
            // 
            factShwBtn.BackColor = Color.FromArgb(192, 255, 192);
            factShwBtn.Dock = DockStyle.Fill;
            factShwBtn.Font = new Font("Courier New", 14F);
            factShwBtn.Location = new Point(136, 25);
            factShwBtn.Name = "factShwBtn";
            factShwBtn.Size = new Size(127, 43);
            factShwBtn.TabIndex = 2;
            factShwBtn.Text = "Show";
            factShwBtn.UseVisualStyleBackColor = false;
            // 
            // fibShwBtn
            // 
            fibShwBtn.BackColor = Color.FromArgb(192, 255, 192);
            fibShwBtn.Dock = DockStyle.Fill;
            fibShwBtn.Font = new Font("Courier New", 14F);
            fibShwBtn.Location = new Point(269, 25);
            fibShwBtn.Name = "fibShwBtn";
            fibShwBtn.Size = new Size(128, 43);
            fibShwBtn.TabIndex = 4;
            fibShwBtn.Text = "Show";
            fibShwBtn.UseVisualStyleBackColor = false;
            // 
            // modDoBtn
            // 
            modDoBtn.BackColor = Color.FromArgb(192, 255, 192);
            modDoBtn.Dock = DockStyle.Fill;
            modDoBtn.Enabled = false;
            modDoBtn.Font = new Font("Courier New", 14F);
            modDoBtn.Location = new Point(3, 74);
            modDoBtn.Name = "modDoBtn";
            modDoBtn.Size = new Size(127, 43);
            modDoBtn.TabIndex = 1;
            modDoBtn.Text = "Do (&M)";
            modDoBtn.UseVisualStyleBackColor = false;
            // 
            // factDoBtn
            // 
            factDoBtn.BackColor = Color.FromArgb(192, 255, 192);
            factDoBtn.Dock = DockStyle.Fill;
            factDoBtn.Enabled = false;
            factDoBtn.Font = new Font("Courier New", 14F);
            factDoBtn.Location = new Point(136, 74);
            factDoBtn.Name = "factDoBtn";
            factDoBtn.Size = new Size(127, 43);
            factDoBtn.TabIndex = 3;
            factDoBtn.Text = "Do (&F)";
            factDoBtn.UseVisualStyleBackColor = false;
            // 
            // fibDoBtn
            // 
            fibDoBtn.BackColor = Color.FromArgb(192, 255, 192);
            fibDoBtn.Dock = DockStyle.Fill;
            fibDoBtn.Enabled = false;
            fibDoBtn.Font = new Font("Courier New", 14F);
            fibDoBtn.Location = new Point(269, 74);
            fibDoBtn.Name = "fibDoBtn";
            fibDoBtn.Size = new Size(128, 43);
            fibDoBtn.TabIndex = 5;
            fibDoBtn.Text = "Do (&B)";
            fibDoBtn.UseVisualStyleBackColor = false;
            // 
            // firstOp
            // 
            firstOp.BackColor = Color.Gainsboro;
            firstOp.Font = new Font("Courier New", 14.25F);
            firstOp.Location = new Point(3, 3);
            firstOp.Name = "firstOp";
            firstOp.Size = new Size(269, 29);
            firstOp.TabIndex = 0;
            firstOp.TabStop = false;
            firstOp.Visible = false;
            // 
            // secondOp
            // 
            secondOp.BackColor = Color.Gainsboro;
            secondOp.Font = new Font("Courier New", 14.25F);
            secondOp.Location = new Point(278, 3);
            secondOp.Name = "secondOp";
            secondOp.Size = new Size(269, 29);
            secondOp.TabIndex = 1;
            secondOp.TabStop = false;
            secondOp.Visible = false;
            // 
            // opsPanel
            // 
            opsPanel.ColumnCount = 2;
            opsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            opsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            opsPanel.Controls.Add(firstOp, 0, 0);
            opsPanel.Controls.Add(secondOp, 1, 0);
            opsPanel.Location = new Point(134, 65);
            opsPanel.Name = "opsPanel";
            opsPanel.RowCount = 1;
            opsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            opsPanel.Size = new Size(550, 40);
            opsPanel.TabIndex = 0;
            // 
            // messageLbl
            // 
            messageLbl.BackColor = Color.LightSteelBlue;
            messageLbl.BorderStyle = BorderStyle.FixedSingle;
            messageLbl.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            messageLbl.ForeColor = Color.Black;
            messageLbl.Location = new Point(110, 307);
            messageLbl.Name = "messageLbl";
            messageLbl.Size = new Size(600, 64);
            messageLbl.TabIndex = 2;
            messageLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(255, 255, 192);
            clearBtn.Font = new Font("Courier New", 14F);
            clearBtn.Location = new Point(110, 435);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(110, 36);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "&Clear";
            clearBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 128);
            exitBtn.Font = new Font("Courier New", 14F);
            exitBtn.Location = new Point(230, 435);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(110, 36);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(820, 520);
            Controls.Add(opsPanel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(messageLbl);
            Controls.Add(clearBtn);
            Controls.Add(exitBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operations Stone Littlejohn";
            tableLayoutPanel1.ResumeLayout(false);
            opsPanel.ResumeLayout(false);
            opsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label modLbl;
        private Label factLbl;
        private Label fibLbl;
        private Button modShwBtn;
        private Button factShwBtn;
        private Button fibShwBtn;
        private Button modDoBtn;
        private Button factDoBtn;
        private Button fibDoBtn;
        private TextBox firstOp;
        private TextBox secondOp;
        private TableLayoutPanel opsPanel;
        private Label messageLbl;
        private Button clearBtn;
        private Button exitBtn;
    }
}