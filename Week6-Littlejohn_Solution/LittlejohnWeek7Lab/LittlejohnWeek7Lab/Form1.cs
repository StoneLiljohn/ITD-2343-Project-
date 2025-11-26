using System;
using System.Drawing;
using System.Windows.Forms;

namespace LittlejohnWeek7Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            proBtn.Click += proBtn_Click;
            binBtn.Click += binBtn_Click;
            hexBtn.Click += hexBtn_Click;
            octBtn.Click += octBtn_Click;
            sixBtn.Click += sixBtn_Click;
            button4.Click += nineBtn_Click;
            clrBtn.Click += clrBtn_Click;
            exitBtn.Click += exitBtn_Click;

            enterTxtbox.Enter += RemoveText;
            enterTxtbox.Leave += AddText;
            baseTxtbox.Enter += RemoveText;
            baseTxtbox.Leave += AddText;
            enterTxtbox.Text = "Enter Base-10 Number";
            baseTxtbox.Text = "Enter Base (2–16)";
            enterTxtbox.ForeColor = Color.Gray;
            baseTxtbox.ForeColor = Color.Gray;
        }

        private string ConvertToBase(int number, int baseValue)
        {
            if (baseValue < 2 || baseValue > 16)
                return "Error: Base must be between 2 and 16.";
            if (number < 0)
                return "Error: Only positive integers";
            if (number == 0)
                return $"{baseValue}x0";
            string digits = "0123456789ABCDEF";
            string result = "";
            int working = number;
            while (working > 0)
            {
                int remainder = working % baseValue;
                working /= baseValue;
                result = digits[remainder] + result;
            }
            string prefix = (baseValue == 16) ? "0x" : $"{baseValue}x";
            return prefix + result;
        }

        private void proBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(enterTxtbox.Text, out int number))
            {
                resultLbl.Text = "Error: Please enter a valid whole number";
                resultLbl.ForeColor = Color.Red;
                return;
            }
            if (!int.TryParse(baseTxtbox.Text, out int baseValue))
            {
                resultLbl.Text = "Error: Please enter a valid base (2–16)";
                resultLbl.ForeColor = Color.Red;
                return;
            }
            resultLbl.Text = ConvertToBase(number, baseValue);
            resultLbl.ForeColor = Color.Black;
        }

        private void binBtn_Click(object sender, EventArgs e) => ConvertAndShow(2);
        private void octBtn_Click(object sender, EventArgs e) => ConvertAndShow(8);
        private void hexBtn_Click(object sender, EventArgs e) => ConvertAndShow(16);
        private void sixBtn_Click(object sender, EventArgs e) => ConvertAndShow(6);
        private void nineBtn_Click(object sender, EventArgs e) => ConvertAndShow(9);

        private void ConvertAndShow(int baseValue)
        {
            if (int.TryParse(enterTxtbox.Text, out int number))
            {
                resultLbl.Text = ConvertToBase(number, baseValue);
                resultLbl.ForeColor = Color.Black;
            }
            else
            {
                resultLbl.Text = "Error: Please enter a valid number";
                resultLbl.ForeColor = Color.Red;
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            enterTxtbox.Text = "Enter Base-10 Number";
            enterTxtbox.ForeColor = Color.Gray;

            baseTxtbox.Text = "Enter Base (2–16)";
            baseTxtbox.ForeColor = Color.Gray;

            resultLbl.Text = "";
            resultLbl.ForeColor = Color.Black;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void RemoveText(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == enterTxtbox && tb.Text == "Enter Base-10 Number")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
            if (tb == baseTxtbox && tb.Text == "Enter Base (2–16)")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == enterTxtbox && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Enter Base-10 Number";
                tb.ForeColor = Color.Gray;
            }
            if (tb == baseTxtbox && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Enter Base (2–16)";
                tb.ForeColor = Color.Gray;
            }
        }
    }
}