using System.Linq;

namespace Section3LabLittlejohn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdoAllWords.Checked = true;
            chkFrequency.Enabled = false;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnExit.PerformClick();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lstWords.Items.Clear();

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text to analyze.");
                return;
            }

            List<string> cleanedWords = GetCleanWords(txtInput.Text);

            DisplayStats(cleanedWords);

            if (rdoAllWords.Checked)
                ShowAllWords(cleanedWords);
            else if (rdoUnique.Checked)
                ShowUniqueWords(cleanedWords);
            else if (rdoTwoWord.Checked)
                ShowTwoWordPairs(cleanedWords);
        }

        private List<string> GetCleanWords(string text)
        {
            char[] removePunc = { '.', ',', '?', '!', ':', ';', '"', '(', ')', '$' };
            string cleaned = text;

            foreach (char c in removePunc)
                cleaned = cleaned.Replace(c.ToString(), "");

            string[] split = cleaned.Split(new char[] { ' ', '\n', '\r', '\t' },
                                           StringSplitOptions.RemoveEmptyEntries);

            List<string> words = new List<string>();

            foreach (string w in split)
            {
                if (int.TryParse(w, out _))
                    continue;

                words.Add(w.ToLower());
            }

            return words;
        }

        private void DisplayStats(List<string> words)
        {
            int sentences = txtInput.Text.Count(c => c == '.' || c == '?' || c == '!');
            txtSentences.Text = sentences.ToString();

            txtWords.Text = words.Count.ToString();
            txtUnique.Text = words.Distinct().Count().ToString();
            txtCharacters.Text = txtInput.Text.Length.ToString();

            if (words.Count > 0)
                txtAvgWord.Text = words.Average(w => w.Length).ToString("0.0");
            else
                txtAvgWord.Text = "0";

            var unique = words.Distinct().ToList();
            if (unique.Count > 0)
                txtAvgUnique.Text = unique.Average(w => w.Length).ToString("0.0");
            else
                txtAvgUnique.Text = "0";
        }

        private void ShowAllWords(List<string> words)
        {
            chkFrequency.Enabled = false;

            lstWords.Items.Clear();
            foreach (var w in words.OrderBy(w => w))
                lstWords.Items.Add(w);
        }

        private void ShowUniqueWords(List<string> words)
        {
            chkFrequency.Enabled = true;

            lstWords.Items.Clear();

            var groups = words.GroupBy(x => x).OrderBy(g => g.Key);

            foreach (var g in groups)
            {
                if (chkFrequency.Checked)
                    lstWords.Items.Add($"{g.Key} ({g.Count()})");
                else
                    lstWords.Items.Add(g.Key);
            }
        }

        private void ShowTwoWordPairs(List<string> words)
        {
            chkFrequency.Enabled = false;

            lstWords.Items.Clear();

            List<string> pairs = new List<string>();

            for (int i = 0; i < words.Count - 1; i++)
            {
                string pair = words[i] + " " + words[i + 1];
                pairs.Add(pair);
            }

            var repeatedPairs = pairs.GroupBy(p => p)
                                     .Where(g => g.Count() > 1)
                                     .SelectMany(g => Enumerable.Repeat(g.Key, g.Count()))
                                     .OrderBy(x => x)
                                     .ToList();

            foreach (var p in repeatedPairs)
                lstWords.Items.Add(p);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            lstWords.Items.Clear();

            txtSentences.Clear();
            txtWords.Clear();
            txtUnique.Clear();
            txtCharacters.Clear();
            txtAvgWord.Clear();
            txtAvgUnique.Clear();

            rdoAllWords.Checked = true;
            chkFrequency.Checked = false;
            chkFrequency.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void rdoUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUnique.Checked)
                chkFrequency.Enabled = true;
        }

        private void rdoAllWords_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAllWords.Checked)
                chkFrequency.Enabled = false;
        }

        private void rdoTwoWord_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTwoWord.Checked)
                chkFrequency.Enabled = false;
        }
    }
}
