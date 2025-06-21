using System;
using System.Windows.Forms;
using System.Data; // Required for DataTable

namespace WindowsFormsApp1
{
    public partial class RemoveMedicineUserControl : UserControl
    {
        private DatabaseManager dbManager;

        // Define an event to notify the parent form to go back
        public event EventHandler GoBackRequested;

        public RemoveMedicineUserControl()
        {
            InitializeComponent();
            dbManager = new DatabaseManager(); // Initialize the database manager
        }

        private void RemoveMedicineUserControl_Load(object sender, EventArgs e)
        {
            LoadMedicinesIntoDataGridView(); // Load data when the control loads
        }

        private void LoadMedicinesIntoDataGridView()
        {
            DataTable medicines = dbManager.GetAllMedicines();
            dataGridViewMedicines.DataSource = medicines;
            // Optionally, hide the 'Id' column if you don't want it visible to the user
            if (dataGridViewMedicines.Columns.Contains("Id"))
            {
                dataGridViewMedicines.Columns["Id"].Visible = false;
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicines.SelectedRows.Count > 0)
            {
                // Get the ID of the selected medicine
                int selectedId = Convert.ToInt32(dataGridViewMedicines.SelectedRows[0].Cells["Id"].Value);

                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to delete the selected medicine?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    dbManager.DeleteMedicine(selectedId);
                    LoadMedicinesIntoDataGridView(); // Refresh the DataGridView
                    MessageBox.Show("Medicine deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // Trigger the GoBackRequested event
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            // Dispose of this user control
            this.Dispose();
        }
    }
}