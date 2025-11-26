namespace Week9Littlejohn
{
    /*
         * Stone Littlejohn 
         * ITD-2343
         * Nov 9, 2025
     */
    partial class frmCheckDigit
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
            processBtn = new Button();
            acctTxtbox = new TextBox();
            confirmTxtbox = new TextBox();
            payTxtbox = new TextBox();
            msgTxtbox = new TextBox();
            acctLbl = new Label();
            confirmLbl = new Label();
            payLbl = new Label();
            SuspendLayout();
            // 
            // resBtn
            // 
            resBtn.BackColor = Color.FromArgb(255, 255, 128);
            resBtn.Font = new Font("Segoe UI", 12F);
            resBtn.ForeColor = SystemColors.WindowText;
            resBtn.Location = new Point(563, 24);
            resBtn.Name = "resBtn";
            resBtn.Size = new Size(85, 37);
            resBtn.TabIndex = 0;
            resBtn.Text = "&Reset";
            resBtn.UseVisualStyleBackColor = false;
            this.CancelButton = exitBtn;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(255, 128, 128);
            exitBtn.Font = new Font("Segoe UI", 12F);
            exitBtn.ForeColor = SystemColors.WindowText;
            exitBtn.Location = new Point(666, 24);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(85, 37);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = false;
            // 
            // processBtn
            // 
            processBtn.BackColor = Color.FromArgb(128, 255, 128);
            processBtn.Font = new Font("Segoe UI", 12F);
            processBtn.ForeColor = SystemColors.WindowText;
            processBtn.Location = new Point(450, 24);
            processBtn.Name = "processBtn";
            processBtn.Size = new Size(95, 37);
            processBtn.TabIndex = 2;
            processBtn.Text = "&Process";
            processBtn.UseVisualStyleBackColor = false;
            this.AcceptButton = processBtn;
            // 
            // acctTxtbox
            // 
            acctTxtbox.Font = new Font("Segoe UI", 14F);
            acctTxtbox.Location = new Point(43, 86);
            acctTxtbox.Name = "acctTxtbox";
            acctTxtbox.Size = new Size(708, 32);
            acctTxtbox.TabIndex = 3;
            // 
            // confirmTxtbox
            // 
            confirmTxtbox.Font = new Font("Segoe UI", 14F);
            confirmTxtbox.Location = new Point(43, 154);
            confirmTxtbox.Name = "confirmTxtbox";
            confirmTxtbox.Size = new Size(708, 32);
            confirmTxtbox.TabIndex = 4;
            // 
            // payTxtbox
            // 
            payTxtbox.Font = new Font("Segoe UI", 14F);
            payTxtbox.Location = new Point(43, 222);
            payTxtbox.Name = "payTxtbox";
            payTxtbox.Size = new Size(708, 32);
            payTxtbox.TabIndex = 5;
            // 
            // msgTxtbox
            // 
            msgTxtbox.BackColor = Color.WhiteSmoke;
            msgTxtbox.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            msgTxtbox.Location = new Point(20, 290);
            msgTxtbox.Multiline = true;
            msgTxtbox.Name = "msgTxtbox";
            msgTxtbox.ReadOnly = true;
            msgTxtbox.Size = new Size(744, 120);
            msgTxtbox.TabIndex = 6;
            // 
            // acctLbl
            // 
            acctLbl.AutoSize = true;
            acctLbl.Font = new Font("Segoe UI", 12F);
            acctLbl.Location = new Point(43, 62);
            acctLbl.Name = "acctLbl";
            acctLbl.Size = new Size(228, 21);
            acctLbl.TabIndex = 7;
            acctLbl.Text = "Account Number (8 digits only)";
            // 
            // confirmLbl
            // 
            confirmLbl.AutoSize = true;
            confirmLbl.Font = new Font("Segoe UI", 12F);
            confirmLbl.Location = new Point(43, 130);
            confirmLbl.Name = "confirmLbl";
            confirmLbl.Size = new Size(200, 21);
            confirmLbl.TabIndex = 8;
            confirmLbl.Text = "Confirm Account Number";
            // 
            // payLbl
            // 
            payLbl.AutoSize = true;
            payLbl.Font = new Font("Segoe UI", 12F);
            payLbl.Location = new Point(43, 198);
            payLbl.Name = "payLbl";
            payLbl.Size = new Size(119, 21);
            payLbl.TabIndex = 9;
            payLbl.Text = "Payment Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 431);
            Controls.Add(payLbl);
            Controls.Add(confirmLbl);
            Controls.Add(acctLbl);
            Controls.Add(msgTxtbox);
            Controls.Add(payTxtbox);
            Controls.Add(confirmTxtbox);
            Controls.Add(acctTxtbox);
            Controls.Add(processBtn);
            Controls.Add(exitBtn);
            Controls.Add(resBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Digit Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resBtn;
        private Button exitBtn;
        private Button processBtn;
        private TextBox acctTxtbox;
        private TextBox confirmTxtbox;
        private TextBox payTxtbox;
        private TextBox msgTxtbox;
        private Label acctLbl;
        private Label confirmLbl;
        private Label payLbl;
    }
}
