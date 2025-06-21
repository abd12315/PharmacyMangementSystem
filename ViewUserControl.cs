// ViewUserUserControl.cs
using System;
using System.Windows.Forms;
using System.IO;       // For file operations
using Newtonsoft.Json; // Make sure you have the Newtonsoft.Json NuGet package installed
using System.Drawing;  // For Image

namespace WindowsFormsApp1
{
    // Ensure UserProfile.cs exists and is in the same namespace or accessible
    // public class UserProfile { /* ... properties ... */ }

    public partial class ViewUserUserControl : UserControl
    {
        private UserProfile currentUserProfile; // Holds the data for the currently displayed user

        public event EventHandler GoBackRequested; // Event to signal when the user wants to go back

        public ViewUserUserControl()
        {
            InitializeComponent(); // This loads the controls defined in the Designer.cs file

            // Wire up event handlers for buttons
            this.btnUploadPhoto.Click += BtnUploadPhoto_Click;
            this.btnEditEmail.Click += BtnEditEmail_Click;
            this.btnEditPhoneNumber.Click += BtnEditPhoneNumber_Click;
            this.btnApplyChanges.Click += BtnApplyChanges_Click;
            this.btnGoBack.Click += BtnGoBack_Click; // Wire up the Go Back button

            // Load a dummy profile for demonstration.
            // In a real application, you would load the actual logged-in user's profile here.
            LoadUserProfileData(new UserProfile
            {
                Username = "Placeholder User", // Replace with actual logic to get logged-in username
                Email = "placeholder@example.com",
                PhoneNumber = "000-000-0000",
                ProfilePhotoPath = "" // No photo initially
            });
        }

        /// <summary>
        /// Loads and displays the provided user profile data onto the control.
        /// </summary>
        /// <param name="profile">The UserProfile object containing data to display.</param>
        public void LoadUserProfileData(UserProfile profile)
        {
            currentUserProfile = profile; // Store the profile data
            lblUserName.Text = currentUserProfile.Username;
            lblEmailValue.Text = currentUserProfile.Email;
            lblPhoneNumberValue.Text = currentUserProfile.PhoneNumber;

            // Load profile photo if path exists and the file is accessible
            if (!string.IsNullOrEmpty(currentUserProfile.ProfilePhotoPath) && File.Exists(currentUserProfile.ProfilePhotoPath))
            {
                try
                {
                    // Use FromFile to load image from path. Important to dispose image to prevent locking file.
                    // Create a new Bitmap from the file to release the file handle immediately.
                    using (Image img = Image.FromFile(currentUserProfile.ProfilePhotoPath))
                    {
                        pbProfilePhoto.Image = new Bitmap(img);
                    }
                    pbProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom; // Ensure image fits
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile photo: {ex.Message}", "Photo Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbProfilePhoto.Image = null; // Clear if error
                }
            }
            else
            {
                pbProfilePhoto.Image = null; // Clear if no path or file
            }
        }

        // Event handler for the "Upload Photo" button
        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Filter to only show common image file types
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) // If user selected a file
            {
                string selectedFilePath = openFileDialog.FileName;

                // Define a directory to save user profile data, typically in Application Data
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsFormsApp1", "UserProfiles");
                Directory.CreateDirectory(appDataPath); // Create the directory if it doesn't exist

                string fileName = Path.GetFileName(selectedFilePath);
                // Create a unique destination path, using username to tie photo to profile
                string destinationPath = Path.Combine(appDataPath, $"{currentUserProfile.Username}_{fileName}");

                try
                {
                    File.Copy(selectedFilePath, destinationPath, true); // Copy file, overwrite if it exists

                    currentUserProfile.ProfilePhotoPath = destinationPath; // Update profile object

                    // Display the new image in the PictureBox
                    using (Image img = Image.FromFile(destinationPath))
                    {
                        pbProfilePhoto.Image = new Bitmap(img);
                    }
                    pbProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
                    MessageBox.Show("Profile photo uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading photo: {ex.Message}", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for the "Edit Email" button
        private void BtnEditEmail_Click(object sender, EventArgs e)
        {
            // Create an instance of the InputForm for email input
            using (InputForm inputForm = new InputForm("Enter New Email:", currentUserProfile.Email))
            {
                if (inputForm.ShowDialog() == DialogResult.OK) // If user clicked OK on InputForm
                {
                    currentUserProfile.Email = inputForm.InputValue; // Get the entered value
                    lblEmailValue.Text = currentUserProfile.Email; // Update the display label
                }
            }
        }

        // Event handler for the "Edit Phone Number" button
        private void BtnEditPhoneNumber_Click(object sender, EventArgs e)
        {
            // Create an instance of the InputForm for phone number input
            using (InputForm inputForm = new InputForm("Enter New Phone Number:", currentUserProfile.PhoneNumber))
            {
                if (inputForm.ShowDialog() == DialogResult.OK) // If user clicked OK on InputForm
                {
                    currentUserProfile.PhoneNumber = inputForm.InputValue; // Get the entered value
                    lblPhoneNumberValue.Text = currentUserProfile.PhoneNumber; // Update the display label
                }
            }
        }

        // Event handler for the "Apply Changes" button (saves to JSON)
        private void BtnApplyChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the directory path where JSON profiles will be saved
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsFormsApp1", "UserProfiles");
                Directory.CreateDirectory(appDataPath); // Ensure directory exists

                // Create a filename based on the username for unique profiles
                string jsonFileName = $"{currentUserProfile.Username}_profile.json";
                string jsonFilePath = Path.Combine(appDataPath, jsonFileName);

                // Serialize the currentUserProfile object to a JSON string with indentation for readability
                string json = JsonConvert.SerializeObject(currentUserProfile, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json); // Write the JSON string to the file

                MessageBox.Show($"Profile changes saved successfully to:\n{jsonFilePath}", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile changes: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Go Back" button
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            // Invoke the GoBackRequested event, signaling the parent form to switch content
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            this.Dispose(); // Dispose of the current UserControl
        }
    }
}