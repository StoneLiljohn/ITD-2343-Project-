namespace Project5Littlejohn
{
    /*
         * Stone Littlejohn 
         * ITD-2343
         * Fall 2025
     */
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkTextbox = new TextBox();
            numLabel = new Label();
            rightTextbox = new TextBox();
            rightLabel = new Label();
            leftLabel = new Label();
            leftTextbox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            exitBtn = new Button();
            checkBtn = new Button();
            clearBtn = new Button();
            msgLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 14F);
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(799, 46);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkTextbox, 0, 3);
            tableLayoutPanel1.Controls.Add(numLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(rightTextbox, 1, 1);
            tableLayoutPanel1.Controls.Add(rightLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(leftLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(leftTextbox, 0, 1);
            tableLayoutPanel1.Location = new Point(2, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(799, 205);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // checkTextbox
            // 
            tableLayoutPanel1.SetColumnSpan(checkTextbox, 2);
            checkTextbox.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            checkTextbox.Location = new Point(210, 163);
            checkTextbox.Margin = new Padding(210, 10, 210, 10);
            checkTextbox.Name = "checkTextbox";
            checkTextbox.Size = new Size(379, 29);
            checkTextbox.TabIndex = 5;
            checkTextbox.TextChanged += checkTextbox_TextChanged;
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(numLabel, 2);
            numLabel.Dock = DockStyle.Fill;
            numLabel.Font = new Font("Times New Roman", 14F);
            numLabel.Location = new Point(210, 112);
            numLabel.Margin = new Padding(210, 10, 210, 10);
            numLabel.Name = "numLabel";
            numLabel.Size = new Size(379, 31);
            numLabel.TabIndex = 4;
            numLabel.Text = "Number to be Checked";
            numLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rightTextbox
            // 
            rightTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rightTextbox.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            rightTextbox.Location = new Point(409, 61);
            rightTextbox.Margin = new Padding(10);
            rightTextbox.Name = "rightTextbox";
            rightTextbox.Size = new Size(380, 29);
            rightTextbox.TabIndex = 3;
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Dock = DockStyle.Fill;
            rightLabel.Font = new Font("Times New Roman", 14F);
            rightLabel.Location = new Point(409, 10);
            rightLabel.Margin = new Padding(10);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(380, 31);
            rightLabel.TabIndex = 1;
            rightLabel.Text = "Right Number";
            rightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Dock = DockStyle.Fill;
            leftLabel.Font = new Font("Times New Roman", 14F);
            leftLabel.Location = new Point(10, 10);
            leftLabel.Margin = new Padding(10);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(379, 31);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "Left Number";
            leftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leftTextbox
            // 
            leftTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            leftTextbox.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            leftTextbox.Location = new Point(10, 61);
            leftTextbox.Margin = new Padding(10);
            leftTextbox.Name = "leftTextbox";
            leftTextbox.Size = new Size(379, 29);
            leftTextbox.TabIndex = 2;
            leftTextbox.TextChanged += leftTextbox_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(exitBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(checkBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(clearBtn, 0, 0);
            tableLayoutPanel2.Location = new Point(2, 262);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(799, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // exitBtn
            // 
            exitBtn.Dock = DockStyle.Fill;
            exitBtn.Location = new Point(542, 10);
            exitBtn.Margin = new Padding(10);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(247, 37);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += ExitBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.Dock = DockStyle.Fill;
            checkBtn.Location = new Point(276, 10);
            checkBtn.Margin = new Padding(10);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(246, 37);
            checkBtn.TabIndex = 1;
            checkBtn.Text = "Che&ck";
            checkBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Location = new Point(10, 10);
            clearBtn.Margin = new Padding(10);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(246, 37);
            clearBtn.TabIndex = 0;
            clearBtn.Text = "Clea&r";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += ClearBtn_Click;
            // 
            // msgLabel
            // 
            msgLabel.BackColor = Color.LightBlue;
            msgLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgLabel.Location = new Point(12, 384);
            msgLabel.Margin = new Padding(3, 20, 3, 20);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(776, 27);
            msgLabel.TabIndex = 3;
            // 
            // frmChoices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(msgLabel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "frmChoices";
            Text = "Littlejohn Choices";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label rightLabel;
        private Label leftLabel;
        private TextBox leftTextbox;
        private Label numLabel;
        private TextBox rightTextbox;
        private TextBox checkTextbox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button clearBtn;
        private Button exitBtn;
        private Button checkBtn;
        private Label msgLabel;
    }
}
