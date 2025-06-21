using System;
using System.Windows.Forms;
using System.Data; // For DataRow
using System.IO; // For file operations
using System.Diagnostics; // For Process.Start (to open/print file)
using System.Runtime.InteropServices; // For checking OS

namespace WindowsFormsApp1
{
    public partial class SellMedicineUserControl : UserControl
    {
        private DatabaseManager dbManager;
        private string currentMedicineName = string.Empty; // Store name for consistent selling
        private double currentMedicinePricePerUnit = 0.0;
        private int currentMedicineTotalStock = 0; // Aggregated stock

        public event EventHandler GoBackRequested;

        public SellMedicineUserControl()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            SetMedicineDetailsReadOnly(true); // Initially make medicine details read-only
            txtTotalAmount.ReadOnly = true; // Ensure total amount is always read-only
        }

        // Method to set the read-only state of medicine detail fields
        private void SetMedicineDetailsReadOnly(bool readOnly)
        {
            txtNameOfMedicine.ReadOnly = readOnly;
            dtpIssueDate.Enabled = !readOnly;
            dtpExpiryDate.Enabled = !readOnly;
            txtPrice.ReadOnly = readOnly;
            // txtQuantityToSell is for user input, so it's not read-only
        }

        private void ClearFormFields()
        {
            txtSearchMedicine.Clear();
            txtNameOfMedicine.Clear();
            dtpIssueDate.Value = DateTime.Today;
            dtpExpiryDate.Value = DateTime.Today;
            txtPrice.Clear();
            txtQuantityToSell.Clear();
            txtTotalAmount.Clear();
            txtCustomerName.Clear();
            currentMedicineName = string.Empty;
            currentMedicinePricePerUnit = 0.0;
            currentMedicineTotalStock = 0;
            SetMedicineDetailsReadOnly(true);
        }

        private void btnSearchMedicine_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchMedicine.Text.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a medicine name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get all instances of the medicine by name
            DataTable medicines = dbManager.GetMedicinesByName(searchName);

            if (medicines != null && medicines.Rows.Count > 0)
            {
                // Aggregate total quantity and pick details from the first instance for display
                currentMedicineTotalStock = 0;
                foreach (DataRow row in medicines.Rows)
                {
                    currentMedicineTotalStock += Convert.ToInt32(row["Quantity"]);
                }

                // Use details from the first found row for display (assuming consistent data for type)
                DataRow firstFoundMedicine = medicines.Rows[0];
                currentMedicineName = firstFoundMedicine["NameOfMedicine"].ToString();
                txtNameOfMedicine.Text = currentMedicineName;
                dtpIssueDate.Value = DateTime.Parse(firstFoundMedicine["DateOfIssue"].ToString());
                dtpExpiryDate.Value = DateTime.Parse(firstFoundMedicine["DateOfExpiry"].ToString());
                currentMedicinePricePerUnit = Convert.ToDouble(firstFoundMedicine["Price"]);
                txtPrice.Text = currentMedicinePricePerUnit.ToString("F2");

                MessageBox.Show($"Medicine '{currentMedicineName}' found! Total available stock: {currentMedicineTotalStock}", "Medicine Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantityToSell.Focus();
            }
            else
            {
                MessageBox.Show($"Medicine '{searchName}' not found in stock.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
            }
        }


        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMedicineName))
            {
                MessageBox.Show("Please search for and select a medicine first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantityToSell.Text, out int quantityToSell) || quantityToSell <= 0)
            {
                MessageBox.Show("Please enter a valid quantity to sell (a positive integer).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantityToSell > currentMedicineTotalStock)
            {
                MessageBox.Show($"Insufficient stock. Only {currentMedicineTotalStock} available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = currentMedicinePricePerUnit * quantityToSell;
            txtTotalAmount.Text = total.ToString("F2");
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMedicineName))
            {
                MessageBox.Show("Please search for and select a medicine first.", "Sell Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantityToSell.Text, out int quantityToSell) || quantityToSell <= 0)
            {
                MessageBox.Show("Please enter a valid quantity to sell (a positive integer).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantityToSell > currentMedicineTotalStock)
            {
                MessageBox.Show($"Cannot sell. Only {currentMedicineTotalStock} of {currentMedicineName} are available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform the sale by decrementing stock across instances
            bool success = dbManager.DecrementMedicineStock(currentMedicineName, quantityToSell);

            if (success)
            {
                string customerName = txtCustomerName.Text;
                double totalAmount = currentMedicinePricePerUnit * quantityToSell;

                // Removed the MessageBox.Show here to prevent showing it twice if printing
                // MessageBox.Show($"Sale successful!\nMedicine: {currentMedicineName}\nQuantity: {quantityToSell}\nTotal: {totalAmount:F2}\nCustomer: {customerName}", "Sale Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Sale recorded successfully! You can now click Print to generate receipt.", "Sale Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // We will NOT clear the form fields immediately after sale,
                // so the user can click the Print button with the current data.
                // ClearFormFields(); // Commented out this line
            }
            // else, DatabaseManager.DecrementMedicineStock would have shown its own error message
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Ensure all required fields are populated before attempting to print
            if (string.IsNullOrEmpty(currentMedicineName) || string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtQuantityToSell.Text) || string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Please ensure a medicine is selected, quantity is entered, total is calculated, and customer name is provided before printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gather all necessary details for printing the receipt
                string medicineName = currentMedicineName;
                string issueDate = dtpIssueDate.Value.ToShortDateString();
                string expiryDate = dtpExpiryDate.Value.ToShortDateString();
                string pricePerUnit = txtPrice.Text;
                string quantitySold = txtQuantityToSell.Text;
                string totalAmount = txtTotalAmount.Text;
                string customerName = txtCustomerName.Text;
                string saleDate = DateTime.Now.ToShortDateString();
                string saleTime = DateTime.Now.ToShortTimeString();

                string receiptContent = $"--- PHARMACY RECEIPT ---\n\n" +
                                      $"Sale Date: {saleDate} {saleTime}\n" +
                                      $"--------------------------\n" +
                                      $"Medicine: {medicineName}\n" +
                                      $"Issue Date: {issueDate}\n" + // This might be from the first found instance
                                      $"Expiry Date: {expiryDate}\n" + // This might be from the first found instance
                                      $"Price/Unit: {pricePerUnit}\n" +
                                      $"Quantity Sold: {quantitySold}\n" +
                                      $"--------------------------\n" +
                                      $"TOTAL AMOUNT: {totalAmount}\n" +
                                      $"Customer: {customerName}\n\n" +
                                      $"--- THANK YOU! ---\n";

                // Define a path for the receipt file in the temporary directory
                string filePath = Path.Combine(Path.GetTempPath(), $"Receipt_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt");

                // Write the receipt content to the file
                File.WriteAllText(filePath, receiptContent);

                // Trigger print based on OS
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    // For Windows, use Process.Start with "print" verb
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true, // Must be true for 'Verb' to work
                        Verb = "print"
                    };
                    Process.Start(psi);
                    MessageBox.Show("Receipt sent to default printer.", "Print Initiated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    // For macOS, use 'open -t' command to open with default text editor, then user can print
                    // Make sure to quote the path for spaces
                    Process.Start("open", $"-t \"{filePath}\"");
                    MessageBox.Show("Receipt opened in text editor. Please print from there.", "Print Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    // For Linux, use 'xdg-open' or 'lpr'
                    // 'xdg-open' tries to open with default application (might show print dialog)
                    // 'lpr' is a direct print command (requires printer setup)
                    try
                    {
                        Process.Start("xdg-open", $"\"{filePath}\"");
                        MessageBox.Show("Receipt opened. Please print from the default application.", "Print Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Fallback to lpr if xdg-open fails or is not preferred
                        // This might not work on all Linux distros or without lpr installed/configured
                        MessageBox.Show($"Could not open with xdg-open: {ex.Message}. Attempting to print via lpr. Ensure your printer is configured.", "Print Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start("lpr", $"\"{filePath}\"");
                    }
                }
                else
                {
                    MessageBox.Show("Printing is not directly supported on this operating system. Receipt saved to: " + filePath, "Unsupported OS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ClearFormFields(); // Clear the form fields after successful print operation
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during print operation: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}