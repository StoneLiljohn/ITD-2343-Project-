namespace LittlejohnLab2
{
    public partial class Form1 : Form
    {
        private enum Operation { None, Modulus, Factorial, Fibonacci }
        private Operation currentOp = Operation.None;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            modShwBtn.Click += (s, e) => SetupOperation(Operation.Modulus);
            factShwBtn.Click += (s, e) => SetupOperation(Operation.Factorial);
            fibShwBtn.Click += (s, e) => SetupOperation(Operation.Fibonacci);

            modDoBtn.Click += (s, e) => DoModulus();
            factDoBtn.Click += (s, e) => DoFactorial();
            fibDoBtn.Click += (s, e) => DoFibonacci();

            clearBtn.Click += (s, e) => ClearMessageArea();
            exitBtn.Click += (s, e) => ExitApplication();

            CancelButton = exitBtn;
        }

        private void SetupOperation(Operation op)
        {
            currentOp = op;
            messageLbl.Text = "";
            firstOp.Visible = true;
            firstOp.Text = "";
            secondOp.Text = "";
            secondOp.Visible = false;
            modDoBtn.Enabled = factDoBtn.Enabled = fibDoBtn.Enabled = false;

            switch (op)
            {
                case Operation.Modulus:
                    secondOp.Visible = true;
                    modDoBtn.Enabled = true;
                    AppendMessage("Enter 2 integers for Modulus");
                    break;
                case Operation.Factorial:
                    factDoBtn.Enabled = true;
                    AppendMessage("Enter positive integer (max 15) for Factorial");
                    break;
                case Operation.Fibonacci:
                    fibDoBtn.Enabled = true;
                    AppendMessage("Enter 1 positive integer (max 45) for Fibonacci");
                    break;
            }
        }

        private void ClearMessageArea()
        {
            messageLbl.Text = "";
            MessageBox.Show("Message area cleared.",
                            "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitApplication()
        {
            MessageBox.Show("Hope this works, Thanks for coming!",
                            "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.M && modDoBtn.Enabled) modDoBtn.PerformClick();
            if (e.Alt && e.KeyCode == Keys.F && factDoBtn.Enabled) factDoBtn.PerformClick();
            if (e.Alt && e.KeyCode == Keys.B && fibDoBtn.Enabled) fibDoBtn.PerformClick();
        }

        private void DoModulus()
        {
            messageLbl.Text = "";
            if (currentOp != Operation.Modulus) return;

            if (!ValidateInteger(firstOp.Text, out int dividend, out string err1) |
                !ValidateInteger(secondOp.Text, out int divisor, out string err2))
            {
                AppendMessage(err1 + err2);
                return;
            }

            if (divisor == 0)
            {
                AppendMessage("Division by zero is not allowed");
                return;
            }

            int absDividend = Math.Abs(dividend);
            int absDivisor = Math.Abs(divisor);
            int quotient = 0;
            int remainder = absDividend;

            while (remainder >= absDivisor)
            {
                remainder -= absDivisor;
                quotient++;
            }

            if ((dividend < 0) ^ (divisor < 0)) quotient = -quotient;
            if (dividend < 0) remainder = -remainder;

            AppendMessage($"{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}");
        }

        private void DoFactorial()
        {
            messageLbl.Text = "";
            if (currentOp != Operation.Factorial) return;

            if (!ValidateInteger(firstOp.Text, out int n, out string err))
            {
                AppendMessage(err);
                return;
            }

            if (n < 0 || n > 15)
            {
                AppendMessage("Factorial must be between 0 and 15");
                return;
            }

            long f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;

            AppendMessage($"The answer to {n}! is {f}");
        }

        private void DoFibonacci()
        {
            messageLbl.Text = "";
            if (currentOp != Operation.Fibonacci) return;

            if (!ValidateInteger(firstOp.Text, out int n, out string err))
            {
                AppendMessage(err);
                return;
            }

            if (n < 0 || n > 45)
            {
                AppendMessage("Fibonacci integer must be between 0 and 45");
                return;
            }

            if (n == 0)
            {
                AppendMessage("Fibonacci(0) = 0");
                return;
            }
            if (n == 1)
            {
                AppendMessage("Fibonacci(1) = 1");
                return;
            }

            int prev2 = 0;
            int prev1 = 1;
            int current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }

            AppendMessage($"Fibonacci({n}) = Fibonacci({n - 1}) + Fibonacci({n - 2}) = {prev1 - prev2} + {prev2} = {current}");
        }

        private bool ValidateInteger(string text, out int value, out string error)
        {
            error = "";
            value = 0;

            if (string.IsNullOrWhiteSpace(text))
            {
                error = "Input is empty.\n";
                return false;
            }

            if (text.Contains(".") || text.Contains(","))
            {
                error = "Decimal values are not allowed.\n";
                return false;
            }

            if (!int.TryParse(text, out value))
            {
                error = "Invalid number entered.\n";
                return false;
            }

            return true;
        }

        private void AppendMessage(string msg)
        {
            if (string.IsNullOrEmpty(messageLbl.Text))
                messageLbl.Text = msg;
            else
                messageLbl.Text += Environment.NewLine + msg;
        }
    }
}
