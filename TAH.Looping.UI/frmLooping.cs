namespace TAH.Looping.UI
{
    public partial class frmLooping : Form
    {
        public frmLooping()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears the text boxes and list box
            txtPhrase.Text = "";
            txtNumOfReps.Text = "";
            lstOutput.Items.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Creates a variable to count the number of repetitions
            int intCountReps = 1;
            
            // checks if a prhase was inputted
            if (string.IsNullOrWhiteSpace(txtPhrase.Text))
            {
                MessageBox.Show("Please enter a phrase.");
                return;
            }

            // retrieves the phrase from the text box
            string strPhrase = txtPhrase.Text;

            // checks if the number of repetitions is a valid positive integer
            if (!int.TryParse(txtNumOfReps.Text, out int intNumOfReps) || intNumOfReps <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for repetitions.");
                return;
            }

            // Clear previous output
            lstOutput.Items.Clear();

            // Loops adding the phrase to the list box for the number of repetitions given by the user
            while (intCountReps <= intNumOfReps)
            {
                // Adds the phrase to the list box and adds 1 to the counter variable
                lstOutput.Items.Add($"{intCountReps}. {strPhrase}");
                intCountReps++;
            }
        }

        private void txtPhrase_TextChanged(object sender, EventArgs e)
        {
            // Clears the list box when the phrase text box is changed
            lstOutput.Items.Clear();
        }

        private void txtNumOfReps_TextChanged(object sender, EventArgs e)
        {
            // Clears the list box when the number of repetitions text box is changed
            lstOutput.Items.Clear();
        }
    }
}
