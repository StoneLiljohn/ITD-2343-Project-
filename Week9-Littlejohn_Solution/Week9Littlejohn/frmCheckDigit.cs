using System.Globalization;

namespace Week9Littlejohn
{
    public partial class frmCheckDigit : Form
    {
        private const int ACCOUNT_LEN = 8;

        public frmCheckDigit()
        {
            InitializeComponent();
            processBtn.Click += ProcessBtn_Click;
            resBtn.Click += ResBtn_Click;
            exitBtn.Click += ExitBtn_Click;
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            msgTxtbox.Text = "";

            string acct = acctTxtbox.Text.Trim();
            string confirm = confirmTxtbox.Text.Trim();
            string payRaw = payTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(acct) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(payRaw))
            {
                msgTxtbox.Text = "Error: All fields are required.";
                return;
            }

            if (!acct.All(char.IsDigit) || !confirm.All(char.IsDigit))
            {
                msgTxtbox.Text = "Error: Account and confirmation must be numeric.";
                return;
            }

            if (acct.Length != ACCOUNT_LEN || confirm.Length != ACCOUNT_LEN)
            {
                msgTxtbox.Text = $"Error: Account numbers must be {ACCOUNT_LEN} digits.";
                return;
            }

            if (acct != confirm)
            {
                msgTxtbox.Text = "Error: Account and confirmation do not match.";
                return;
            }

            if (!IsValidCheckDigit(acct))
            {
                msgTxtbox.Text = "Error: Invalid check digit in account number.";
                return;
            }

            if (!decimal.TryParse(payRaw, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
            {
                msgTxtbox.Text = "Error: Payment must be a valid amount.";
                return;
            }

            string formattedAmount = amount.ToString("C", CultureInfo.CurrentCulture);
            string date = DateTime.Today.ToString("MMMM d", CultureInfo.CurrentCulture);

            msgTxtbox.Text = $"A payment of {formattedAmount} was applied to account {acct} on {date}.";
        }

        private bool IsValidCheckDigit(string acct)
        {
            string body = acct.Substring(0, ACCOUNT_LEN - 1);
            int checkDigit = acct[ACCOUNT_LEN - 1] - '0';
            int sum = 0;
            foreach (char c in body) sum += c - '0';
            return sum % 10 == checkDigit;
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            acctTxtbox.Text = "";
            confirmTxtbox.Text = "";
            payTxtbox.Text = "";
            msgTxtbox.Text = "";
            acctTxtbox.Focus();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}