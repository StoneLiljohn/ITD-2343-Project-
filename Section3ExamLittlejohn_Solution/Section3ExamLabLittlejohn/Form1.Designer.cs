namespace Section3ExamLabLittlejohn
{
    partial class Form1
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
        /// Method required for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            lblInput = new Label();
            lblOutput = new Label();
            txtOutput = new TextBox();
            rdoToPlain = new RadioButton();
            rdoToCipher = new RadioButton();
            grpConversion = new GroupBox();
            btnConvert = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpConversion.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(24, 52);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(330, 110);
            txtInput.TabIndex = 0;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(21, 26);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(134, 20);
            lblInput.TabIndex = 5;
            lblInput.Text = "Enter Original Text:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(21, 187);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(161, 20);
            lblOutput.TabIndex = 6;
            lblOutput.Text = "Converted Text Output:";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(24, 210);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(330, 110);
            txtOutput.TabIndex = 4;
            txtOutput.TabStop = false;
            // 
            // rdoToPlain
            // 
            rdoToPlain.AutoSize = true;
            rdoToPlain.Location = new Point(16, 66);
            rdoToPlain.Name = "rdoToPlain";
            rdoToPlain.Size = new Size(123, 24);
            rdoToPlain.TabIndex = 2;
            rdoToPlain.TabStop = true;
            rdoToPlain.Text = "Cipher → Plain";
            rdoToPlain.UseVisualStyleBackColor = true;
            // 
            // rdoToCipher
            // 
            rdoToCipher.AutoSize = true;
            rdoToCipher.Location = new Point(16, 30);
            rdoToCipher.Name = "rdoToCipher";
            rdoToCipher.Size = new Size(123, 24);
            rdoToCipher.TabIndex = 1;
            rdoToCipher.TabStop = true;
            rdoToCipher.Text = "Plain → Cipher";
            rdoToCipher.UseVisualStyleBackColor = true;
            // 
            // grpConversion
            // 
            grpConversion.Controls.Add(rdoToCipher);
            grpConversion.Controls.Add(rdoToPlain);
            grpConversion.Location = new Point(380, 52);
            grpConversion.Name = "grpConversion";
            grpConversion.Size = new Size(170, 110);
            grpConversion.TabIndex = 1;
            grpConversion.TabStop = false;
            grpConversion.Text = "Conversion Type";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(192, 255, 192);
            btnConvert.Location = new Point(380, 210);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(170, 40);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 255, 192);
            btnReset.Location = new Point(380, 256);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(170, 40);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Location = new Point(380, 302);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnConvert;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 368);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnConvert);
            Controls.Add(grpConversion);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Font = new Font("Segoe UI", 11F);
            KeyPreview = true;
            Name = "Form1";
            Text = "Cipher Converter";
            grpConversion.ResumeLayout(false);
            grpConversion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private Label lblOutput;
        private TextBox txtOutput;
        private RadioButton rdoToPlain;
        private RadioButton rdoToCipher;
        private GroupBox grpConversion;
        private Button btnConvert;
        private Button btnReset;
        private Button btnExit;
    }
}
