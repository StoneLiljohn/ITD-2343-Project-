namespace Week10Littlejohn
{
    /*
     * Stone Littlejohn
     * Nov 11 2025
     * ITD-2343
     */
    public partial class frmRadioStar : Form
    {
        private const byte ADD = 0;
        private const byte SUBTRACT = 1;
        private const byte MULTIPLY = 2;
        private const byte DIVIDE = 3;
        private const byte MODULUS = 4;

        public frmRadioStar()
        {
            InitializeComponent();
            this.CancelButton = btnExit;
            this.AcceptButton = btnCalculate;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            string errorMessage = "";

            bool leftValid = int.TryParse(txtLeftOperand.Text, out int left);
            bool rightValid = int.TryParse(txtRightOperand.Text, out int right);

            if (!leftValid) errorMessage += "Left operand must be an integer.\n";
            if (!rightValid) errorMessage += "Right operand must be an integer.\n";

            if (!leftValid || !rightValid)
            {
                lblAnswer.Text = errorMessage.TrimEnd();
                return;
            }

            byte operation = ADD;
            if (rdoAdd.Checked) operation = ADD;
            else if (rdoSubtract.Checked) operation = SUBTRACT;
            else if (rdoMultiply.Checked) operation = MULTIPLY;
            else if (rdoDivide.Checked) operation = DIVIDE;
            else if (rdoModulus.Checked) operation = MODULUS;

            if ((operation == DIVIDE || operation == MODULUS) && right == 0)
            {
                lblAnswer.Text = "Divide or Modulus by zero is not allowed.";
                return;
            }

            if (operation == MODULUS && (left < 0 || right < 0))
            {
                lblAnswer.Text = "Modulus cannot be used with negative numbers.";
                return;
            }

            int result = PerformOperation(left, right, operation);

            if (chkVerbose.Checked)
            {
                lblAnswer.Text = $"{left} {GetSymbol(operation)} {right} = {result}";
            }
            else
            {
                lblAnswer.Text = $"The Answer is: {result}";
            }
        }

        private int PerformOperation(int left, int right, byte operation)
        {
            switch (operation)
            {
                case ADD: return left + right;
                case SUBTRACT: return left - right;
                case MULTIPLY: return left * right;
                case DIVIDE: return left / right;
                case MODULUS: return left % right;
            }
            return 0;
        }

        private string GetSymbol(byte operation)
        {
            switch (operation)
            {
                case ADD: return "+";
                case SUBTRACT: return "-";
                case MULTIPLY: return "*";
                case DIVIDE: return "/";
                case MODULUS: return "%";
            }
            return "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblAnswer.Text = "";
            rdoAdd.Checked = true;
            chkVerbose.Checked = true;
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
