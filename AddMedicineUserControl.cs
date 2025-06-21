using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddMedicineUserControl : UserControl
    {
        private DatabaseManager dbManager;

        // Define an event to notify the parent form to go back
        public event EventHandler GoBackRequested;

        public AddMedicineUserControl()
        {
            InitializeComponent();
            dbManager = new DatabaseManager(); // Initialize the database manager
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Gather data from the form fields
            string medicineName = txtNameOfMedicine.Text;
            DateTime issueDate = dtpIssueDate.Value;
            DateTime expiryDate = dtpExpiryDate.Value;
            string priceText = txtPrice.Text; // Get price as string
            string receiverName = txtReceiverName.Text;
            string senderName = txtSenderName.Text;

            // Basic validation
            if (string.IsNullOrWhiteSpace(medicineName) || string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(receiverName) || string.IsNullOrWhiteSpace(senderName))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (expiryDate <= issueDate)
            {
                MessageBox.Show("Expiry Date must be after Issue Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(priceText, out double price))
            {
                MessageBox.Show("Please enter a valid number for Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the database
            dbManager.InsertMedicine(medicineName, issueDate, expiryDate, price, receiverName, senderName);

            MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the form fields after submission
            ClearFormFields();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // Trigger the GoBackRequested event
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            // Dispose of this user control
            this.Dispose();
        }

        private void ClearFormFields()
        {
            txtNameOfMedicine.Clear();
            dtpIssueDate.Value = DateTime.Today; // Reset to current date
            dtpExpiryDate.Value = DateTime.Today; // Reset to current date
            txtPrice.Clear();
            txtReceiverName.Clear();
            txtSenderName.Clear();
        }
    }
}