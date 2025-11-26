namespace Week2_Littlejohn_Project
{
    public partial class frmFall2025 : Form
    {
        public frmFall2025()
        {
            InitializeComponent();
            this.Text = "Fall 2025 – Stone Littlejohn";

            midLabel.BackColor = this.BackColor;
            midLabel.Text = string.Empty;

            this.StartPosition = FormStartPosition.CenterScreen;
            wipeBtn.Click += wipeBtn_Click;
            saveBtn.Click += saveBtn_Click;
            cancelBtn.Click += cancelBtn_Click;
            exitBtn.Click += exitBtn_Click;
        }

        private void wipeBtn_Click(object? sender, EventArgs e)
        {
            inputBox.Clear();
            midLabel.Text = string.Empty;
            inputBox.Focus();
        }

        private void saveBtn_Click(object? sender, EventArgs e)
        {
            midLabel.Text = inputBox.Text;
        }

        private void cancelBtn_Click(object? sender, EventArgs e)
        {
            inputBox.Text = string.Empty;
            midLabel.Text = string.Empty;
            inputBox.Focus();
        }

        private void exitBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
