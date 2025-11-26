namespace Week10Littlejohn
{
    partial class frmRadioStar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLeftOperand = new TextBox();
            txtRightOperand = new TextBox();
            lblLeft = new Label();
            lblRight = new Label();
            grpOperations = new GroupBox();
            rdoModulus = new RadioButton();
            rdoDivide = new RadioButton();
            rdoMultiply = new RadioButton();
            rdoSubtract = new RadioButton();
            rdoAdd = new RadioButton();
            chkVerbose = new CheckBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblAnswer = new Label();
            grpOperations.SuspendLayout();
            SuspendLayout();
            // 
            // txtLeftOperand
            // 
            txtLeftOperand.BackColor = Color.LightYellow;
            txtLeftOperand.Font = new Font("Times New Roman", 16F);
            txtLeftOperand.Location = new Point(440, 34);
            txtLeftOperand.Margin = new Padding(5, 6, 5, 6);
            txtLeftOperand.Name = "txtLeftOperand";
            txtLeftOperand.Size = new Size(344, 63);
            txtLeftOperand.TabIndex = 0;
            // 
            // txtRightOperand
            // 
            txtRightOperand.BackColor = Color.LightYellow;
            txtRightOperand.Font = new Font("Times New Roman", 16F);
            txtRightOperand.Location = new Point(440, 142);
            txtRightOperand.Margin = new Padding(5, 6, 5, 6);
            txtRightOperand.Name = "txtRightOperand";
            txtRightOperand.Size = new Size(344, 63);
            txtRightOperand.TabIndex = 1;
            // 
            // lblLeft
            // 
            lblLeft.AutoSize = true;
            lblLeft.Font = new Font("Times New Roman", 16F);
            lblLeft.Location = new Point(40, 43);
            lblLeft.Margin = new Padding(5, 0, 5, 0);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new Size(278, 55);
            lblLeft.TabIndex = 2;
            lblLeft.Text = "Left Operand";
            // 
            // lblRight
            // 
            lblRight.AutoSize = true;
            lblRight.Font = new Font("Times New Roman", 16F);
            lblRight.Location = new Point(40, 151);
            lblRight.Margin = new Padding(5, 0, 5, 0);
            lblRight.Name = "lblRight";
            lblRight.Size = new Size(304, 55);
            lblRight.TabIndex = 3;
            lblRight.Text = "Right Operand";
            // 
            // grpOperations
            // 
            grpOperations.Controls.Add(rdoModulus);
            grpOperations.Controls.Add(rdoDivide);
            grpOperations.Controls.Add(rdoMultiply);
            grpOperations.Controls.Add(rdoSubtract);
            grpOperations.Controls.Add(rdoAdd);
            grpOperations.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            grpOperations.Location = new Point(52, 268);
            grpOperations.Margin = new Padding(8, 9, 8, 9);
            grpOperations.Name = "grpOperations";
            grpOperations.Padding = new Padding(8, 9, 8, 9);
            grpOperations.Size = new Size(738, 347);
            grpOperations.TabIndex = 4;
            grpOperations.TabStop = false;
            grpOperations.Text = "Math Operations Available";
            // 
            // rdoModulus
            // 
            rdoModulus.AutoSize = true;
            rdoModulus.Font = new Font("Times New Roman", 12F);
            rdoModulus.Location = new Point(405, 242);
            rdoModulus.Margin = new Padding(8, 9, 8, 9);
            rdoModulus.Name = "rdoModulus";
            rdoModulus.Size = new Size(237, 45);
            rdoModulus.TabIndex = 9;
            rdoModulus.Text = "Modulus (%)";
            rdoModulus.UseVisualStyleBackColor = true;
            // 
            // rdoDivide
            // 
            rdoDivide.AutoSize = true;
            rdoDivide.Font = new Font("Times New Roman", 12F);
            rdoDivide.Location = new Point(52, 242);
            rdoDivide.Margin = new Padding(8, 9, 8, 9);
            rdoDivide.Name = "rdoDivide";
            rdoDivide.Size = new Size(187, 45);
            rdoDivide.TabIndex = 8;
            rdoDivide.Text = "Divide (/)";
            rdoDivide.UseVisualStyleBackColor = true;
            // 
            // rdoMultiply
            // 
            rdoMultiply.AutoSize = true;
            rdoMultiply.Font = new Font("Times New Roman", 12F);
            rdoMultiply.Location = new Point(405, 159);
            rdoMultiply.Margin = new Padding(8, 9, 8, 9);
            rdoMultiply.Name = "rdoMultiply";
            rdoMultiply.Size = new Size(221, 45);
            rdoMultiply.TabIndex = 7;
            rdoMultiply.Text = "Multiply (*)";
            rdoMultiply.UseVisualStyleBackColor = true;
            // 
            // rdoSubtract
            // 
            rdoSubtract.AutoSize = true;
            rdoSubtract.Font = new Font("Times New Roman", 12F);
            rdoSubtract.Location = new Point(52, 159);
            rdoSubtract.Margin = new Padding(8, 9, 8, 9);
            rdoSubtract.Name = "rdoSubtract";
            rdoSubtract.Size = new Size(211, 45);
            rdoSubtract.TabIndex = 6;
            rdoSubtract.Text = "Subtract (-)";
            rdoSubtract.UseVisualStyleBackColor = true;
            // 
            // rdoAdd
            // 
            rdoAdd.AutoSize = true;
            rdoAdd.Checked = true;
            rdoAdd.Font = new Font("Times New Roman", 12F);
            rdoAdd.Location = new Point(52, 77);
            rdoAdd.Margin = new Padding(8, 9, 8, 9);
            rdoAdd.Name = "rdoAdd";
            rdoAdd.Size = new Size(163, 45);
            rdoAdd.TabIndex = 5;
            rdoAdd.TabStop = true;
            rdoAdd.Text = "Add (+)";
            rdoAdd.UseVisualStyleBackColor = true;
            // 
            // chkVerbose
            // 
            chkVerbose.AutoSize = true;
            chkVerbose.Checked = true;
            chkVerbose.CheckState = CheckState.Checked;
            chkVerbose.Font = new Font("Times New Roman", 12F);
            chkVerbose.Location = new Point(52, 638);
            chkVerbose.Margin = new Padding(8, 9, 8, 9);
            chkVerbose.Name = "chkVerbose";
            chkVerbose.Size = new Size(496, 45);
            chkVerbose.TabIndex = 10;
            chkVerbose.Text = "Verbose Mode (show equation)";
            chkVerbose.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnCalculate.Location = new Point(52, 720);
            btnCalculate.Margin = new Padding(5, 6, 5, 6);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(240, 85);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnClear.Location = new Point(320, 720);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 85);
            btnClear.TabIndex = 12;
            btnClear.Text = "&Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnExit.Location = new Point(560, 720);
            btnExit.Margin = new Padding(5, 6, 5, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(230, 85);
            btnExit.TabIndex = 13;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAnswer.BackColor = Color.FromArgb(255, 255, 192);
            lblAnswer.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblAnswer.Location = new Point(30, 834);
            lblAnswer.Margin = new Padding(5, 0, 5, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(790, 176);
            lblAnswer.TabIndex = 14;
            lblAnswer.Text = "Answer Shows Here";
            lblAnswer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRadioStar
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            CancelButton = btnExit;
            ClientSize = new Size(850, 1042);
            Controls.Add(lblAnswer);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(chkVerbose);
            Controls.Add(grpOperations);
            Controls.Add(lblRight);
            Controls.Add(lblLeft);
            Controls.Add(txtRightOperand);
            Controls.Add(txtLeftOperand);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmRadioStar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radio Buttons in Action";
            grpOperations.ResumeLayout(false);
            grpOperations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoMultiply;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.CheckBox chkVerbose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAnswer;
    }
}