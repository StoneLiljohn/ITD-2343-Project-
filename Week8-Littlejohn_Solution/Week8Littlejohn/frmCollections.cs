namespace Week8Littlejohn
{
    public partial class frmCollections : Form
    {
        private const int MAX_COUNT = 17;
        private const int MIN_VALUE = -1217;
        private const int MAX_VALUE = 1217;
        private Queue<int> numbers = new Queue<int>();
        private const string PLACEHOLDER = "Enter a Number";

        public frmCollections()
        {
            InitializeComponent();
            inputTxtbox.ForeColor = Color.Gray;
            inputTxtbox.Text = PLACEHOLDER;
            inputTxtbox.GotFocus += InputTxtbox_GotFocus;
            inputTxtbox.LostFocus += InputTxtbox_LostFocus;

            addBtn.Click += AddBtn_Click;
            showBtn.Click += ShowBtn_Click;
            resBtn.Click += ResBtn_Click;
            exitBtn.Click += ExitBtn_Click;
        }

        private void InputTxtbox_GotFocus(object sender, EventArgs e)
        {
            if (inputTxtbox.Text == PLACEHOLDER)
            {
                inputTxtbox.Text = "";
                inputTxtbox.ForeColor = Color.Black;
            }
        }

        private void InputTxtbox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputTxtbox.Text))
            {
                inputTxtbox.Text = PLACEHOLDER;
                inputTxtbox.ForeColor = Color.Gray;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            statsTxtbox.Text = "";
            numTxtbox.Text = "";
            string input = inputTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(input) || input == PLACEHOLDER)
            {
                statsTxtbox.Text = "Error: Input cannot be empty.";
                return;
            }

            int value;
            if (!int.TryParse(input, out value))
            {
                statsTxtbox.Text = "Error: Only whole numbers are allowed.";
                inputTxtbox.Text = "";
                return;
            }

            if (value < MIN_VALUE)
            {
                statsTxtbox.Text = $"Error: Value {value} is too small.";
                inputTxtbox.Text = "";
                return;
            }

            if (value > MAX_VALUE)
            {
                statsTxtbox.Text = $"Error: Value {value} is too large.";
                inputTxtbox.Text = "";
                return;
            }

            if (numbers.Count >= MAX_COUNT)
            {
                statsTxtbox.Text = "Error: Collection is full.";
                inputTxtbox.Text = "";
                return;
            }

            numbers.Enqueue(value);
            statsTxtbox.Text = $"Added {value} to collection.";
            inputTxtbox.Text = "";
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                statsTxtbox.Text = "Error: No numbers in collection.";
                return;
            }

            numTxtbox.Text = "";
            double sum = 0;
            int high = int.MinValue;
            int low = int.MaxValue;

            foreach (int n in numbers)
            {
                numTxtbox.AppendText(n + Environment.NewLine);
                sum += n;
                if (n > high) high = n;
                if (n < low) low = n;
            }

            double avg = sum / numbers.Count;
            statsTxtbox.Text =
                $"High Number: {high}{Environment.NewLine}" +
                $"Low Number: {low}{Environment.NewLine}" +
                $"Average: {avg:F4}{Environment.NewLine}" +
                $"Count: {numbers.Count}";

            numbers.Clear();
            inputTxtbox.Text = PLACEHOLDER;
            inputTxtbox.ForeColor = Color.Gray;
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            numTxtbox.Text = "";
            statsTxtbox.Text = "Collection cleared.";
            inputTxtbox.Text = PLACEHOLDER;
            inputTxtbox.ForeColor = Color.Gray;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}