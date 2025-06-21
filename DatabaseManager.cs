using System;
using System.Collections.Generic; // Needed for List
using System.Data; // Needed for DataTable, DataRow
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DatabaseManager
    {
        private const string DATABASE_NAME = "pharmacyManagement.db";
        private string connectionString;

        public DatabaseManager()
        {
            connectionString = $"Data Source={DATABASE_NAME};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(DATABASE_NAME))
            {
                SQLiteConnection.CreateFile(DATABASE_NAME);
                CreateTables();
            }
            else
            {
                AddQuantityColumnIfMissing();
            }
        }

        private void CreateTables()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string createTableSql = @"
                        CREATE TABLE IF NOT EXISTS Medicines (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            NameOfMedicine TEXT NOT NULL,
                            DateOfIssue TEXT NOT NULL,
                            DateOfExpiry TEXT NOT NULL,
                            Price REAL NOT NULL,
                            ReceiverName TEXT,
                            SenderName TEXT,
                            Quantity INTEGER NOT NULL DEFAULT 1 -- Quantity column, defaults to 1
                        );";
                    using (SQLiteCommand cmd = new SQLiteCommand(createTableSql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating database tables: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddQuantityColumnIfMissing()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("PRAGMA table_info(Medicines);", conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            bool quantityColumnExists = false;
                            while (reader.Read())
                            {
                                if (reader["name"].ToString().Equals("Quantity", StringComparison.OrdinalIgnoreCase))
                                {
                                    quantityColumnExists = true;
                                    break;
                                }
                            }

                            if (!quantityColumnExists)
                            {
                                using (SQLiteCommand alterCmd = new SQLiteCommand("ALTER TABLE Medicines ADD COLUMN Quantity INTEGER NOT NULL DEFAULT 1;", conn))
                                {
                                    alterCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking/adding Quantity column: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ORIGINAL InsertMedicine method - adds a new record, Quantity defaults to 1.
        public void InsertMedicine(string name, DateTime issueDate, DateTime expiryDate, double price, string receiver, string sender)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertSql = @"
                        INSERT INTO Medicines (NameOfMedicine, DateOfIssue, DateOfExpiry, Price, ReceiverName, SenderName)
                        VALUES (@NameOfMedicine, @DateOfIssue, @DateOfExpiry, @Price, @ReceiverName, @SenderName);";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NameOfMedicine", name);
                        cmd.Parameters.AddWithValue("@DateOfIssue", issueDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@DateOfExpiry", expiryDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@ReceiverName", receiver);
                        cmd.Parameters.AddWithValue("@SenderName", sender);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to get all medicine records (now includes Quantity)
        public System.Data.DataTable GetAllMedicines()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string selectSql = "SELECT Id, NameOfMedicine, DateOfIssue, DateOfExpiry, Price, Quantity, ReceiverName, SenderName FROM Medicines";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectSql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving medicines: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        // Method to delete a medicine record by ID (No change needed)
        public void DeleteMedicine(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string deleteSql = "DELETE FROM Medicines WHERE Id = @Id;";
                    using (SQLiteCommand cmd = new SQLiteCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // NEW: Method to get *all* records for a given medicine name (for aggregation)
        public DataTable GetMedicinesByName(string name)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Select all columns including Quantity for all matching names
                    string selectSql = "SELECT Id, NameOfMedicine, DateOfIssue, DateOfExpiry, Price, Quantity, ReceiverName, SenderName FROM Medicines WHERE NameOfMedicine LIKE @Name ORDER BY DateOfExpiry ASC;"; // Order by expiry for selling logic
                    using (SQLiteCommand cmd = new SQLiteCommand(selectSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving medicines by name: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        // NEW: Method to decrement stock across multiple "instances"
        public bool DecrementMedicineStock(string medicineName, int quantitySold)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Get all instances of the medicine, ordered by expiry date (sell oldest first)
                        DataTable medicinesToUpdate = GetMedicinesByName(medicineName);

                        if (medicinesToUpdate == null || medicinesToUpdate.Rows.Count == 0)
                        {
                            MessageBox.Show($"Medicine '{medicineName}' not found in stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return false;
                        }

                        int totalAvailable = 0;
                        foreach (DataRow row in medicinesToUpdate.Rows)
                        {
                            totalAvailable += Convert.ToInt32(row["Quantity"]);
                        }

                        if (totalAvailable < quantitySold)
                        {
                            MessageBox.Show($"Not enough stock to sell {quantitySold} units of '{medicineName}'. Only {totalAvailable} available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return false;
                        }

                        int remainingToSell = quantitySold;

                        foreach (DataRow row in medicinesToUpdate.Rows)
                        {
                            if (remainingToSell <= 0) break; // All sold

                            int currentId = Convert.ToInt32(row["Id"]);
                            int currentQty = Convert.ToInt32(row["Quantity"]);

                            if (currentQty >= remainingToSell)
                            {
                                // This instance can cover the remaining sale
                                int newQty = currentQty - remainingToSell;
                                string updateSql = "UPDATE Medicines SET Quantity = @NewQuantity WHERE Id = @Id;";
                                using (SQLiteCommand updateCmd = new SQLiteCommand(updateSql, conn, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@NewQuantity", newQty);
                                    updateCmd.Parameters.AddWithValue("@Id", currentId);
                                    updateCmd.ExecuteNonQuery();
                                }
                                remainingToSell = 0; // All sold
                            }
                            else
                            {
                                // This instance is fully depleted, move to next
                                remainingToSell -= currentQty;
                                string updateSql = "UPDATE Medicines SET Quantity = 0 WHERE Id = @Id;"; // Set to 0, could delete
                                using (SQLiteCommand updateCmd = new SQLiteCommand(updateSql, conn, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("@Id", currentId);
                                    updateCmd.ExecuteNonQuery();
                                }
                                // Optionally, delete the row if quantity becomes 0:
                                // string deleteSql = "DELETE FROM Medicines WHERE Id = @Id;";
                                // using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteSql, conn, transaction))
                                // {
                                //     deleteCmd.Parameters.AddWithValue("@Id", currentId);
                                //     deleteCmd.ExecuteNonQuery();
                                // }
                            }
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback on error
                        MessageBox.Show($"Error selling medicine: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        // NEW: Method to update an existing medicine record
        public bool UpdateMedicine(int id, string name, DateTime issueDate, DateTime expiryDate, double price, int quantity, string receiver, string sender)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateSql = @"
                        UPDATE Medicines SET
                            NameOfMedicine = @NameOfMedicine,
                            DateOfIssue = @DateOfIssue,
                            DateOfExpiry = @DateOfExpiry,
                            Price = @Price,
                            Quantity = @Quantity,
                            ReceiverName = @ReceiverName,
                            SenderName = @SenderName
                        WHERE Id = @Id;";
                    using (SQLiteCommand cmd = new SQLiteCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NameOfMedicine", name);
                        cmd.Parameters.AddWithValue("@DateOfIssue", issueDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@DateOfExpiry", expiryDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@ReceiverName", receiver);
                        cmd.Parameters.AddWithValue("@SenderName", sender);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating medicine (ID: {id}): {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}