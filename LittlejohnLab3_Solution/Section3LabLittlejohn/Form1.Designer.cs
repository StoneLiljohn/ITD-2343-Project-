namespace Section3LabLittlejohn
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
            txtInput = new TextBox();
            lstWords = new ListBox();
            rdoAllWords = new RadioButton();
            rdoUnique = new RadioButton();
            rdoTwoWord = new RadioButton();
            chkFrequency = new CheckBox();
            grpOptions = new GroupBox();
            lblSentences = new Label();
            lblWords = new Label();
            lblUniqueWords = new Label();
            lblCharacters = new Label();
            lblAvgWordLen = new Label();
            lblAvgUniqueLen = new Label();
            txtSentences = new TextBox();
            txtWords = new TextBox();
            txtUnique = new TextBox();
            txtCharacters = new TextBox();
            txtAvgWord = new TextBox();
            txtAvgUnique = new TextBox();
            grpStats = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnProcess = new Button();
            tableButtons = new TableLayoutPanel();
            grpOptions.SuspendLayout();
            grpStats.SuspendLayout();
            tableButtons.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 10F);
            txtInput.Location = new Point(12, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(430, 450);
            txtInput.TabIndex = 0;
            // 
            // lstWords
            // 
            lstWords.Font = new Font("Segoe UI", 10F);
            lstWords.FormattingEnabled = true;
            lstWords.ItemHeight = 17;
            lstWords.Location = new Point(455, 155);
            lstWords.Name = "lstWords";
            lstWords.Size = new Size(240, 310);
            lstWords.TabIndex = 1;
            // 
            // rdoAllWords
            // 
            rdoAllWords.AutoSize = true;
            rdoAllWords.Checked = true;
            rdoAllWords.Location = new Point(20, 22);
            rdoAllWords.Name = "rdoAllWords";
            rdoAllWords.Size = new Size(85, 23);
            rdoAllWords.TabIndex = 0;
            rdoAllWords.TabStop = true;
            rdoAllWords.Text = "All Words";
            rdoAllWords.UseVisualStyleBackColor = true;
            // 
            // rdoUnique
            // 
            rdoUnique.AutoSize = true;
            rdoUnique.Location = new Point(20, 48);
            rdoUnique.Name = "rdoUnique";
            rdoUnique.Size = new Size(96, 23);
            rdoUnique.TabIndex = 1;
            rdoUnique.TabStop = true;
            rdoUnique.Text = "Unique List";
            rdoUnique.UseVisualStyleBackColor = true;
            // 
            // rdoTwoWord
            // 
            rdoTwoWord.AutoSize = true;
            rdoTwoWord.Location = new Point(20, 74);
            rdoTwoWord.Name = "rdoTwoWord";
            rdoTwoWord.Size = new Size(123, 23);
            rdoTwoWord.TabIndex = 2;
            rdoTwoWord.TabStop = true;
            rdoTwoWord.Text = "Two-Word Pairs";
            rdoTwoWord.UseVisualStyleBackColor = true;
            // 
            // chkFrequency
            // 
            chkFrequency.AutoSize = true;
            chkFrequency.Location = new Point(20, 100);
            chkFrequency.Name = "chkFrequency";
            chkFrequency.Size = new Size(128, 23);
            chkFrequency.TabIndex = 3;
            chkFrequency.Text = "Show Frequency";
            chkFrequency.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(chkFrequency);
            grpOptions.Controls.Add(rdoTwoWord);
            grpOptions.Controls.Add(rdoUnique);
            grpOptions.Controls.Add(rdoAllWords);
            grpOptions.Font = new Font("Segoe UI", 10F);
            grpOptions.Location = new Point(455, 12);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(240, 130);
            grpOptions.TabIndex = 2;
            grpOptions.TabStop = false;
            grpOptions.Text = "Display Options";
            // 
            // lblSentences
            // 
            lblSentences.AutoSize = true;
            lblSentences.Location = new Point(20, 30);
            lblSentences.Name = "lblSentences";
            lblSentences.Size = new Size(109, 19);
            lblSentences.TabIndex = 11;
            lblSentences.Text = "Sentence Count:";
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Location = new Point(260, 30);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(87, 19);
            lblWords.TabIndex = 10;
            lblWords.Text = "Word Count:";
            // 
            // lblUniqueWords
            // 
            lblUniqueWords.AutoSize = true;
            lblUniqueWords.Location = new Point(460, 30);
            lblUniqueWords.Name = "lblUniqueWords";
            lblUniqueWords.Size = new Size(99, 19);
            lblUniqueWords.TabIndex = 9;
            lblUniqueWords.Text = "Unique Words:";
            // 
            // lblCharacters
            // 
            lblCharacters.AutoSize = true;
            lblCharacters.Location = new Point(20, 70);
            lblCharacters.Name = "lblCharacters";
            lblCharacters.Size = new Size(113, 19);
            lblCharacters.TabIndex = 8;
            lblCharacters.Text = "Character Count:";
            // 
            // lblAvgWordLen
            // 
            lblAvgWordLen.AutoSize = true;
            lblAvgWordLen.Location = new Point(260, 70);
            lblAvgWordLen.Name = "lblAvgWordLen";
            lblAvgWordLen.Size = new Size(120, 19);
            lblAvgWordLen.TabIndex = 7;
            lblAvgWordLen.Text = "Avg Word Length:";
            // 
            // lblAvgUniqueLen
            // 
            lblAvgUniqueLen.AutoSize = true;
            lblAvgUniqueLen.Location = new Point(460, 70);
            lblAvgUniqueLen.Name = "lblAvgUniqueLen";
            lblAvgUniqueLen.Size = new Size(131, 19);
            lblAvgUniqueLen.TabIndex = 6;
            lblAvgUniqueLen.Text = "Avg Unique Length:";
            // 
            // txtSentences
            // 
            txtSentences.Location = new Point(150, 27);
            txtSentences.Name = "txtSentences";
            txtSentences.ReadOnly = true;
            txtSentences.Size = new Size(90, 25);
            txtSentences.TabIndex = 5;
            // 
            // txtWords
            // 
            txtWords.Location = new Point(350, 27);
            txtWords.Name = "txtWords";
            txtWords.ReadOnly = true;
            txtWords.Size = new Size(90, 25);
            txtWords.TabIndex = 4;
            // 
            // txtUnique
            // 
            txtUnique.Location = new Point(570, 27);
            txtUnique.Name = "txtUnique";
            txtUnique.ReadOnly = true;
            txtUnique.Size = new Size(90, 25);
            txtUnique.TabIndex = 3;
            // 
            // txtCharacters
            // 
            txtCharacters.Location = new Point(150, 67);
            txtCharacters.Name = "txtCharacters";
            txtCharacters.ReadOnly = true;
            txtCharacters.Size = new Size(90, 25);
            txtCharacters.TabIndex = 2;
            // 
            // txtAvgWord
            // 
            txtAvgWord.Location = new Point(380, 67);
            txtAvgWord.Name = "txtAvgWord";
            txtAvgWord.ReadOnly = true;
            txtAvgWord.Size = new Size(60, 25);
            txtAvgWord.TabIndex = 1;
            // 
            // txtAvgUnique
            // 
            txtAvgUnique.Location = new Point(610, 67);
            txtAvgUnique.Name = "txtAvgUnique";
            txtAvgUnique.ReadOnly = true;
            txtAvgUnique.Size = new Size(60, 25);
            txtAvgUnique.TabIndex = 0;
            // 
            // grpStats
            // 
            grpStats.Controls.Add(txtAvgUnique);
            grpStats.Controls.Add(txtAvgWord);
            grpStats.Controls.Add(txtCharacters);
            grpStats.Controls.Add(txtUnique);
            grpStats.Controls.Add(txtWords);
            grpStats.Controls.Add(txtSentences);
            grpStats.Controls.Add(lblAvgUniqueLen);
            grpStats.Controls.Add(lblAvgWordLen);
            grpStats.Controls.Add(lblCharacters);
            grpStats.Controls.Add(lblUniqueWords);
            grpStats.Controls.Add(lblWords);
            grpStats.Controls.Add(lblSentences);
            grpStats.Font = new Font("Segoe UI", 10F);
            grpStats.Location = new Point(12, 470);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(683, 130);
            grpStats.TabIndex = 8;
            grpStats.TabStop = false;
            grpStats.Text = "Statistics";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.Location = new Point(163, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(73, 69);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 192);
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(82, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 69);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.FromArgb(192, 255, 192);
            btnProcess.Font = new Font("Segoe UI", 10F);
            btnProcess.Location = new Point(3, 3);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(73, 69);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // tableButtons
            // 
            tableButtons.ColumnCount = 3;
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableButtons.Controls.Add(btnProcess, 0, 0);
            tableButtons.Controls.Add(btnClear, 1, 0);
            tableButtons.Controls.Add(btnExit, 2, 0);
            tableButtons.Location = new Point(720, 20);
            tableButtons.Name = "tableButtons";
            tableButtons.RowCount = 1;
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableButtons.Size = new Size(240, 75);
            tableButtons.TabIndex = 7;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(972, 610);
            Controls.Add(grpStats);
            Controls.Add(tableButtons);
            Controls.Add(grpOptions);
            Controls.Add(lstWords);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Text Analyzer";
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            grpStats.ResumeLayout(false);
            grpStats.PerformLayout();
            tableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstWords;
        private RadioButton rdoAllWords;
        private RadioButton rdoUnique;
        private RadioButton rdoTwoWord;
        private CheckBox chkFrequency;
        private GroupBox grpOptions;
        private Label lblSentences;
        private Label lblWords;
        private Label lblUniqueWords;
        private Label lblCharacters;
        private Label lblAvgWordLen;
        private Label lblAvgUniqueLen;
        private TextBox txtSentences;
        private TextBox txtWords;
        private TextBox txtUnique;
        private TextBox txtCharacters;
        private TextBox txtAvgWord;
        private TextBox txtAvgUnique;
        private GroupBox grpStats;
        private Button btnExit;
        private Button btnClear;
        private Button btnProcess;
        private TableLayoutPanel tableButtons;
    }
}
