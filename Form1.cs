using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string USERS_FILE_PATH = "users.json";
        private static Dictionary<string, string> users = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);

            LoadUsersFromFile();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void LoadUsersFromFile()
        {
            if (File.Exists(USERS_FILE_PATH))
            {
                try
                {
                    string jsonString = File.ReadAllText(USERS_FILE_PATH);
                    var loadedUsers = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
                    if (loadedUsers != null)
                    {
                        users = loadedUsers;
                    }
                }
                catch (JsonSerializationException ex)
                {
                    MessageBox.Show($"Error reading user data: {ex.Message}\nStarting with an empty user list.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    users = new Dictionary<string, string>();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"File access error: {ex.Message}\nStarting with an empty user list.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    users = new Dictionary<string, string>();
                }
            }
        }

        private void SaveUsersToFile()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(USERS_FILE_PATH, jsonString);
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show($"Error saving user data: {ex.Message}", "Data Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"File access error: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUsersToFile();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (users.ContainsKey(username) && users[username] == password)
            {
                MessageBox.Show("Login successful!");
                txtUsername.Clear();
                txtPassword.Clear();

                this.Hide(); // Hide the current login form
                DashboardForm dashboard = new DashboardForm(); // Create an instance of the new form
                dashboard.LoggedInUsername = username; // Set the username here!
                dashboard.Show(); // Show the new form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (users.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            users.Add(username, password);
            SaveUsersToFile();
            MessageBox.Show("Registration successful! You can now log in.");
            SwitchToLogin();
        }

        private void LinkSwitchToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelConfirmPassword.Visible = true;
            labelConfirmPassword.Visible = true;
            btnRegister.Visible = true;
            btnLogin.Visible = false;
            linkSwitchToLogin.Visible = true;
            linkSwitchToRegister.Visible = false;
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void LinkSwitchToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchToLogin();
        }

        private void SwitchToLogin()
        {
            panelConfirmPassword.Visible = false;
            labelConfirmPassword.Visible = false;
            btnRegister.Visible = false;
            btnLogin.Visible = true;
            linkSwitchToLogin.Visible = false;
            linkSwitchToRegister.Visible = true;
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}