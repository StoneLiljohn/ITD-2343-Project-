namespace Week8Littlejohn
{
    partial class frmCollections
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
            resBtn = new Button();
            exitBtn = new Button();
            inputTxtbox = new TextBox();
            addBtn = new Button();
            showBtn = new Button();
            numTxtbox = new TextBox();
            statsTxtbox = new TextBox();
            collectLbl = new Label();
            statsLbl = new Label();
            SuspendLayout();
            // 
            // resBtn
            // 
            resBtn.BackColor = Color.FromArgb(255, 255, 128);
            resBtn.Font = new Font("Segoe UI", 12F);
            resBtn.ForeColor = SystemColors.WindowText;
            resBtn.Location = new Point(541, 380);
            resBtn.Name = "resBtn";
            resBtn.Size = new Size(85, 37);
            resBtn.TabIndex = 0;
            resBtn.Text = "Reset";
            resBtn.UseVisualStyleBackColor = false;
            this.CancelButton = exitBtn;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 128);
            exitBtn.Font = new Font("Segoe UI", 12F);
            exitBtn.ForeColor = SystemColors.WindowText;
            exitBtn.Location = new Point(666, 380);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(85, 37);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // inputTxtbox
            // 
            inputTxtbox.Font = new Font("Segoe UI", 16F);
            inputTxtbox.Location = new Point(43, 52);
            inputTxtbox.Name = "inputTxtbox";
            inputTxtbox.Size = new Size(450, 36);
            inputTxtbox.TabIndex = 2;
            inputTxtbox.Text = "Enter a Number";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(128, 255, 128);
            addBtn.Font = new Font("Segoe UI", 12F);
            addBtn.ForeColor = SystemColors.WindowText;
            addBtn.Location = new Point(541, 51);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(85, 37);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            this.AcceptButton = addBtn; 
            // 
            // showBtn
            // 
            showBtn.BackColor = Color.FromArgb(128, 255, 128);
            showBtn.Font = new Font("Segoe UI", 12F);
            showBtn.ForeColor = SystemColors.WindowText;
            showBtn.Location = new Point(666, 51);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(85, 37);
            showBtn.TabIndex = 4;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = false;
            // 
            // numTxtbox
            // 
            numTxtbox.BackColor = Color.LightBlue;
            numTxtbox.Font = new Font("Segoe UI", 12F);
            numTxtbox.Location = new Point(43, 131);
            numTxtbox.Multiline = true;
            numTxtbox.Name = "numTxtbox";
            numTxtbox.ReadOnly = true;
            numTxtbox.ScrollBars = ScrollBars.Vertical;
            numTxtbox.Size = new Size(128, 286);
            numTxtbox.TabIndex = 5;
            // 
            // statsTxtbox
            // 
            statsTxtbox.BackColor = Color.FromArgb(255, 192, 192);
            statsTxtbox.Font = new Font("Segoe UI", 12F);
            statsTxtbox.Location = new Point(239, 131);
            statsTxtbox.Multiline = true;
            statsTxtbox.Name = "statsTxtbox";
            statsTxtbox.ReadOnly = true;
            statsTxtbox.Size = new Size(254, 286);
            statsTxtbox.TabIndex = 6;
            // 
            // collectLbl
            // 
            collectLbl.AutoSize = true;
            collectLbl.Font = new Font("Segoe UI", 14F);
            collectLbl.Location = new Point(58, 103);
            collectLbl.Name = "collectLbl";
            collectLbl.Size = new Size(97, 25);
            collectLbl.TabIndex = 7;
            collectLbl.Text = "Collection";
            // 
            // statsLbl
            // 
            statsLbl.AutoSize = true;
            statsLbl.Font = new Font("Segoe UI", 14F);
            statsLbl.Location = new Point(344, 103);
            statsLbl.Name = "statsLbl";
            statsLbl.Size = new Size(51, 25);
            statsLbl.TabIndex = 8;
            statsLbl.Text = "Stats";
            // 
            // frmCollections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(statsLbl);
            Controls.Add(collectLbl);
            Controls.Add(statsTxtbox);
            Controls.Add(numTxtbox);
            Controls.Add(showBtn);
            Controls.Add(addBtn);
            Controls.Add(inputTxtbox);
            Controls.Add(exitBtn);
            Controls.Add(resBtn);
            Name = "frmCollections";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Collection Lab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resBtn;
        private Button exitBtn;
        private TextBox inputTxtbox;
        private Button addBtn;
        private Button showBtn;
        private TextBox numTxtbox;
        private TextBox statsTxtbox;
        private Label collectLbl;
        private Label statsLbl;
    }
}
