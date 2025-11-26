namespace Project5Littlejohn
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
            clearBtn.Click += ClearBtn_Click;
            exitBtn.Click += ExitBtn_Click;
            checkBtn.Click += CheckBtn_Click;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear all user-entered text
            leftTextbox.Clear();
            rightTextbox.Clear();
            checkTextbox.Clear();

            // Clear the message label at the bottom
            msgLabel.Text = string.Empty;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Close the entire application
            Application.Exit();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            // Clear any previous message
            msgLabel.Text = string.Empty;

            // Convert textbox values directly to integers
            int low = Convert.ToInt32(leftTextbox.Text);
            int high = Convert.ToInt32(rightTextbox.Text);
            int check = Convert.ToInt32(checkTextbox.Text.Trim());

            // If the check number exactly equals the lower number
            if (check == low)
            {
                msgLabel.Text = $"The number {check} is equal to the lower end of the range.";
            }
            // If the check number exactly equals the higher number
            else if (check == high)
            {
                msgLabel.Text = $"The number {check} is equal to the upper end of the range.";
            }
            // If the check number is smaller than the low end
            else if (check < low)
            {
                msgLabel.Text = $"The number {check} is lower than the low end of the range ({low}).";
            }
            // If the check number is greater than the high end
            else if (check > high)
            {
                msgLabel.Text = $"The number {check} is higher than the high end of the range ({high}).";
            }
            // If none of the above are true
            else
            {
                msgLabel.Text = $"The number {check} is within the range of {low} and {high}.";
            }

            // Clear the check number textbox so the user can enter another number
            checkTextbox.Clear();
            checkTextbox.Focus();
        }

        private void checkTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void leftTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}