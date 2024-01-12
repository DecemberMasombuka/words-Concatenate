using System.Collections;

namespace words_Concatenate
{
    public partial class Form1 : Form
    {

        private ArrayList words = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord = txtNewWord.Text.Trim();

            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a word to add.", "Empty Word", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (words.Contains(newWord))
            {
                MessageBox.Show("The word has already been added.", "Duplicate Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            words.Add(newWord);
            cboWord1.Items.Add(newWord);
            cboWord2.Items.Add(newWord);
            MessageBox.Show("The word has been added successfully.", "Word Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNewWord.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbRemove1.Checked)
            {
                RemoveItem();
            }
            else
            {
                ConcatenateWords();
            }
        }

        private void ConcatenateWords()
        {
            if (cboWord1.SelectedIndex == -1 || cboWord2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select words from both combo boxes.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboWord1.SelectedItem.Equals(cboWord2.SelectedItem))
            {
                MessageBox.Show("Please select different words from the combo boxes.", "Same Words Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string concatenatedWord = cboWord1.SelectedItem.ToString() + cboWord2.SelectedItem.ToString();
            concatenatedWords.Add(concatenatedWord);
            lblConcatenatedWord.Text = concatenatedWord;
            lblConcatenatedWord.BackColor = Color.White;
            lblConcatenatedWord.Font = new Font(lblConcatenatedWord.Font.FontFamily, 10);
            lblConcatenatedWord.Dock = DockStyle.Bottom;
        }
        private void RemoveItem()
        {
            if (cboWord1.SelectedIndex == -1 && cboWord2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a word to remove.", "No Word Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboBox selectedComboBox = rbRemove2.Checked ? cboWord1 : cboWord2;
            string removedWord = selectedComboBox.SelectedItem.ToString();
            selectedComboBox.Items.Remove(removedWord);
            words.Remove(removedWord);
            MessageBox.Show("The word has been removed successfully.", "Word Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbRemove1_CheckedChanged(object sender, EventArgs e)
        {
            
                btnConcatenate.Text = rbRemove1.Checked ? "Remove Item" : "Concatenate";
            
        }
    }
}