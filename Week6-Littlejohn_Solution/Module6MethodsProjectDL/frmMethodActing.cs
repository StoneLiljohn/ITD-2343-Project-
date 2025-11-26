using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmMethodActing : Form
    {
        private const byte ADD = 0;
        private const byte SUBTRACT = 1;
        private const byte MULTIPLY = 2;
        private const byte DIVIDE = 3;
        private const byte MODULUS = 4;

        public frmMethodActing()
        {
            InitializeComponent();
            this.CancelButton = btnExit;
        }

        private decimal PerformOperation(decimal left, decimal right, byte operation)
        {
            decimal result = 0;

            switch (operation)
            {
                case ADD:
                    result = left + right;
                    break;
                case SUBTRACT:
                    result = left - right;
                    break;
                case MULTIPLY:
                    result = left * right;
                    break;
                case DIVIDE:
                    if (right != 0)
                        result = left / right;
                    else
                        MessageBox.Show("Cannot divide by zero.", "Error");
                    break;
                case MODULUS:
                    if (right != 0)
                        result = left % right;
                    else
                        MessageBox.Show("Cannot divide by zero.", "Error");
                    break;
            }

            return result; 
        }

        private void DisplayResult(decimal left, decimal right, byte operation)
        {
            string symbol = "";
            switch (operation)
            {
                case ADD: symbol = "+"; break;
                case SUBTRACT: symbol = "-"; break;
                case MULTIPLY: symbol = "*"; break;
                case DIVIDE: symbol = "/"; break;
                case MODULUS: symbol = "%"; break;
            }

            decimal answer = PerformOperation(left, right, operation);
            lblAnswer.Text = $"{left} {symbol} {right} = {answer}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetOperands(out decimal left, out decimal right);
            DisplayResult(left, right, ADD);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            GetOperands(out decimal left, out decimal right);
            DisplayResult(left, right, SUBTRACT);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetOperands(out decimal left, out decimal right);
            DisplayResult(left, right, MULTIPLY);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetOperands(out decimal left, out decimal right);
            DisplayResult(left, right, DIVIDE);
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            GetOperands(out decimal left, out decimal right);
            DisplayResult(left, right, MODULUS);
        }

        private void GetOperands(out decimal left, out decimal right)
        {
            if (!decimal.TryParse(txtLeftOperand.Text, out left))
                left = 0;
            if (!decimal.TryParse(txtRightOperand.Text, out right))
                right = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeftOperand.Text = "";
            txtRightOperand.Text = "";
            lblAnswer.Text = "";
            txtLeftOperand.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}