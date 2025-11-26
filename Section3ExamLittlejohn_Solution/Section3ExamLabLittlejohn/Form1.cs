using System.Text;

namespace Section3ExamLabLittlejohn
{
    public partial class Form1 : Form
    {
        //counters to track how many messages were converted on exit
        private int plainToCipherCount = 0;
        private int cipherToPlainCount = 0;

        private Dictionary<char, char> toCipher = new Dictionary<char, char>()
        {
            { 'A','R' }, { 'B','S' }, { 'C','N' }, { 'D','E' }, { 'E','P' },
            { 'F','H' }, { 'G','C' }, { 'H','A' }, { 'I','T' }, { 'J','I' },
            { 'K','M' }, { 'L','G' }, { 'M','L' }, { 'N','X' }, { 'O','W' },
            { 'P','V' }, { 'Q','F' }, { 'R','U' }, { 'S','J' }, { 'T','Z' },
            { 'U','K' }, { 'V','O' }, { 'W','B' }, { 'X','Y' }, { 'Y','D' },
            { 'Z','Q' }
        };

        private Dictionary<char, char> toPlain = new Dictionary<char, char>();


        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;

            foreach (var pair in toCipher)
                toPlain[pair.Value] = pair.Key;

            rdoToCipher.Checked = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnExit.PerformClick();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string errorMsg = ValidateInput();
            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string input = txtInput.Text.ToUpper();
            string result = "";

            if (rdoToCipher.Checked)
            {
                result = ConvertToCipher(input);
                plainToCipherCount++;
            }
            else
            {
                result = ConvertToPlain(input);
                cipherToPlainCount++;
            }

            txtOutput.Text = result;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            rdoToCipher.Checked = true;
            txtInput.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            string summary =
                "Conversion Summary:\n\n" +
                $"Plain → Cipher: {plainToCipherCount}\n" +
                $"Cipher → Plain: {cipherToPlainCount}";

            MessageBox.Show(summary, "Session Summary",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private string ValidateInput()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtInput.Text))
                errors.AppendLine("- Input text cannot be empty.");

            return errors.ToString();
        }
        private string ConvertToCipher(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (toCipher.ContainsKey(c))
                    sb.Append(toCipher[c]);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }
        private string ConvertToPlain(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (toPlain.ContainsKey(c))
                    sb.Append(toPlain[c]);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
