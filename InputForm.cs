// InputForm.cs
using System.Windows.Forms; // Required for Form, Label, TextBox, Button, DialogResult

namespace WindowsFormsApp1
{
    public partial class InputForm : Form
    {
        // This property will hold the value entered by the user
        public string InputValue { get; private set; }

        /// <summary>
        /// Constructor for the InputForm.
        /// </summary>
        /// <param name="prompt">The text to display as a prompt to the user.</param>
        /// <param name="initialValue">An optional initial value to display in the text box.</param>
        public InputForm(string prompt, string initialValue = "")
        {
            InitializeComponent(); // This calls the code in InputForm.Designer.cs to set up controls

            // Set the prompt label's text
            lblPrompt.Text = prompt;
            // Set the initial value of the text box
            txtInput.Text = initialValue;

            // Make Enter key press 'OK' button and Esc key press 'Cancel' button
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;

            // Wire up the click event handlers for the buttons
            // These will be called when the user clicks OK or Cancel
            btnOk.Click += btnOk_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // Event handler for the OK button click
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            // Store the current text box value in the public property
            InputValue = txtInput.Text;
            // Set the DialogResult to OK, which will close the form
            this.DialogResult = DialogResult.OK;
            // Explicitly close the form
            this.Close();
        }

        // Event handler for the Cancel button click
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            // Set the DialogResult to Cancel, which will close the form
            this.DialogResult = DialogResult.Cancel;
            // Explicitly close the form
            this.Close();
        }
    }
}