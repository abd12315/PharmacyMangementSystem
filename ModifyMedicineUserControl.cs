using System;
using System.Windows.Forms;
using System.Data; // For DataTable, DataRow
using System.Linq; // For LINQ queries on DataRows (e.g., parsing dates)

namespace WindowsFormsApp1
{
    public partial class ModifyMedicineUserControl : UserControl
    {
        private DatabaseManager dbManager;
        private DataTable currentMedicinesDataTable; // Stores the data currently displayed in the DataGridView

        public event EventHandler GoBackRequested;

        public ModifyMedicineUserControl()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();

            // Wire up event handlers
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearchMedicine.KeyPress += new KeyPressEventHandler(this.txtSearchMedicine_KeyPress);
            this.btnApplyChanges.Click += new System.EventHandler(this.btnApplyChanges_Click);
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);

            // Configure DataGridView properties
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dataGridViewMedicines.AllowUserToAddRows = false;
            dataGridViewMedicines.AllowUserToDeleteRows = false;
            dataGridViewMedicines.MultiSelect = false; // Allow only single row selection if needed
            dataGridViewMedicines.ReadOnly = false; // Allow editing
            dataGridViewMedicines.EditMode = DataGridViewEditMode.EditOnEnter; // Enter edit mode on single click
            // Hide the ID column as it's for internal use
            // Using different parameter names (senderGrid, eGrid) to absolutely avoid any potential conflicts
            dataGridViewMedicines.DataBindingComplete += (senderGrid, eGrid) =>
            {
                if (dataGridViewMedicines.Columns.Contains("Id"))
                {
                    dataGridViewMedicines.Columns["Id"].Visible = false;
                }
                // Optional: Adjust column headers if they are not user-friendly database column names
                // Example: if your DB column is 'NameOfMedicine' but you want to display 'Medicine Name'
                if (dataGridViewMedicines.Columns.Contains("NameOfMedicine"))
                {
                    dataGridViewMedicines.Columns["NameOfMedicine"].HeaderText = "Medicine Name";
                }
                if (dataGridViewMedicines.Columns.Contains("DateOfIssue"))
                {
                    dataGridViewMedicines.Columns["DateOfIssue"].HeaderText = "Issue Date";
                }
                if (dataGridViewMedicines.Columns.Contains("DateOfExpiry"))
                {
                    dataGridViewMedicines.Columns["DateOfExpiry"].HeaderText = "Expiry Date";
                }
                if (dataGridViewMedicines.Columns.Contains("ReceiverName"))
                {
                    dataGridViewMedicines.Columns["ReceiverName"].HeaderText = "Receiver";
                }
                if (dataGridViewMedicines.Columns.Contains("SenderName"))
                {
                    dataGridViewMedicines.Columns["SenderName"].HeaderText = "Sender";
                }
            };
        }

        private void LoadMedicinesIntoDataGridView(string searchName = "")
        {
            DataTable medicines;
            if (string.IsNullOrWhiteSpace(searchName))
            {
                // For modify, it's generally better to show specific results after a search
                // So we start with an empty table if the search string is empty
                medicines = new DataTable();
            }
            else
            {
                // Use the DatabaseManager to get all matching medicines by name
                medicines = dbManager.GetMedicinesByName(searchName);
            }

            currentMedicinesDataTable = medicines; // Store the DataTable
            dataGridViewMedicines.DataSource = currentMedicinesDataTable; // Bind to DataGridView

            // Ensure ID column is hidden if it exists (redundant with DataBindingComplete, but good for immediate update if DataSource changes)
            if (dataGridViewMedicines.Columns.Contains("Id"))
            {
                dataGridViewMedicines.Columns["Id"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchMedicine.Text.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a medicine name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadMedicinesIntoDataGridView(searchName);

            if (currentMedicinesDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"No medicines found matching '{searchName}'.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e); // Trigger the search button click event
                e.Handled = true; // Consume the key press so it doesn't do anything else (like beep)
            }
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            // Ensure any pending edits in the DataGridView are committed before processing
            if (dataGridViewMedicines.IsCurrentCellInEditMode)
            {
                dataGridViewMedicines.EndEdit();
            }

            if (currentMedicinesDataTable == null || currentMedicinesDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No changes to apply. Search for medicines first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to apply all changes?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool allUpdatesSuccessful = true;
                foreach (DataRow row in currentMedicinesDataTable.Rows)
                {
                    // Check if the row has been modified
                    if (row.RowState == DataRowState.Modified)
                    {
                        try
                        {
                            // Validate data types before conversion and update
                            if (!int.TryParse(row["Id"].ToString(), out int id))
                            {
                                MessageBox.Show($"Invalid ID for a row. Skipping update for: {row["NameOfMedicine"]}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }

                            string name = row["NameOfMedicine"].ToString();
                            if (string.IsNullOrWhiteSpace(name))
                            {
                                MessageBox.Show($"Medicine name cannot be empty for ID: {id}. Skipping update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }

                            if (!DateTime.TryParse(row["DateOfIssue"].ToString(), out DateTime issueDate))
                            {
                                MessageBox.Show($"Invalid Issue Date format for medicine '{name}'. Skipping update for ID: {id}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }

                            if (!DateTime.TryParse(row["DateOfExpiry"].ToString(), out DateTime expiryDate))
                            {
                                MessageBox.Show($"Invalid Expiry Date format for medicine '{name}'. Skipping update for ID: {id}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }
                            // Basic validation for expiry date not in the past relative to today
                            if (expiryDate < DateTime.Today)
                            {
                                MessageBox.Show($"Expiry Date for medicine '{name}' (ID: {id}) cannot be in the past. Skipping update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }


                            if (!double.TryParse(row["Price"].ToString(), out double price) || price <= 0)
                            {
                                MessageBox.Show($"Invalid Price for medicine '{name}'. Must be a positive number. Skipping update for ID: {id}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }

                            if (!int.TryParse(row["Quantity"].ToString(), out int quantity) || quantity < 0) // Allow 0 quantity for out of stock
                            {
                                MessageBox.Show($"Invalid Quantity for medicine '{name}'. Must be a non-negative integer. Skipping update for ID: {id}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                allUpdatesSuccessful = false;
                                continue;
                            }

                            string receiver = row["ReceiverName"].ToString();
                            string senderName = row["SenderName"].ToString(); // RENAMED 'sender' to 'senderName' here!


                            bool updateSuccess = dbManager.UpdateMedicine(id, name, issueDate, expiryDate, price, quantity, receiver, senderName); // Use senderName here
                            if (!updateSuccess)
                            {
                                allUpdatesSuccessful = false;
                                // The dbManager.UpdateMedicine method should show its own error message,
                                // so no need for another here.
                            }
                        }
                        catch (Exception ex)
                        {
                            allUpdatesSuccessful = false;
                            // Attempt to get the name for better error reporting if possible
                            string medicineNameForError = "Unknown Medicine";
                            if (row.Table.Columns.Contains("NameOfMedicine") && row["NameOfMedicine"] != DBNull.Value)
                            {
                                medicineNameForError = row["NameOfMedicine"].ToString();
                            }
                            MessageBox.Show($"Error updating row for medicine '{medicineNameForError}': {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (allUpdatesSuccessful)
                {
                    MessageBox.Show("All applicable changes applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reload the data to reflect any changes committed to the DB and clear row states
                    LoadMedicinesIntoDataGridView(txtSearchMedicine.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Some changes could not be applied due to validation errors or database issues. Please check the error messages and correct the data.", "Partial Success/Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}