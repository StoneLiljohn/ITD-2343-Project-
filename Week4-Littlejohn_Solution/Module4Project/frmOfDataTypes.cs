namespace Module4Project
{
    /*
         * Stone Littlejohn 
         * ITD-2343
         * Oct 4, 2025
     */
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clears only the label text
            label1.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closes the application
            this.Close();
        }

        private void byteBtn_Click(object sender, EventArgs e)
        {
            // Perform addition with byte variables
            byte leftOperand = 2;
            byte rightOperand = 3;
            byte result = (byte)(leftOperand + rightOperand);

            // Display formatted string in the label
            label1.Text = string.Format("{0} + {1} = {2}", leftOperand, rightOperand, result);
        }

        private void shortBtn_Click(object sender, EventArgs e)
        {
            // Perform subtraction with short variables 
            short leftOperand = 25;
            short rightOperand = 9;
            short result = (short)(leftOperand - rightOperand);

            label1.Text = string.Format("{0} - {1} = {2}", leftOperand, rightOperand, result);
        }

        private void intBtn_Click(object sender, EventArgs e)
        {
            // Perform integer division with int variables
            int leftOperand = 7;
            int rightOperand = 2;
            int result = leftOperand / rightOperand;

            label1.Text = string.Format("{0} / {1} = {2}", leftOperand, rightOperand, result);
        }

        private void longBtn_Click(object sender, EventArgs e)
        {
            // Perform modulus operation with long variables
            long leftOperand = 1000;
            long rightOperand = 300;
            long result = leftOperand % rightOperand;

            label1.Text = string.Format("{0} % {1} = {2}", leftOperand, rightOperand, result);
        }

        private void floatBtn_Click(object sender, EventArgs e)
        {
            // Perform modulus operation with float variables
            float leftOperand = 9.8765432f;
            float rightOperand = 4.3210987f;
            float result = leftOperand % rightOperand;

            // Display with 7 digits of precision
            label1.Text = string.Format("{0:F7} % {1:F7} = {2:F7}", leftOperand, rightOperand, result);
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            // Perform division with double variables
            double leftOperand = 7.0;
            double rightOperand = 2.0;
            double result = leftOperand / rightOperand;

            // Display with 15 digits of precision
            label1.Text = string.Format("{0:F15} / {1:F15} = {2:F15}", leftOperand, rightOperand, result);
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            // Perform multiplication with decimal variables
            decimal leftOperand = 1.234567890123456789m;
            decimal rightOperand = 9.876543210987654321m;
            decimal result = leftOperand * rightOperand;

            // Display with 28 digits of precision
            label1.Text = string.Format("{0:F28} * {1:F28} = {2:F28}", leftOperand, rightOperand, result);
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            // Use Math.Pow(double, double)
            double baseNum = 3;
            double exponent = 4;
            double result = Math.Pow(baseNum, exponent);

            label1.Text = string.Format("{0} raised to the power of {1} is {2}", baseNum, exponent, result);
        }

        private void roundBtn_Click(object sender, EventArgs e)
        {
            // Use Math.Round(double, int)
            double value = 3.14159265358979;
            int decimals = 3;
            double result = Math.Round(value, decimals);

            label1.Text = string.Format("Rounding {0} to {1} decimals gives {2}", value, decimals, result);
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            // Use Math.Sqrt(double)
            double value = 49;
            double result = Math.Sqrt(value);

            label1.Text = string.Format("The square root of {0} is {1}", value, result);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
