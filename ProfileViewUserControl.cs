// ProfileViewUserControl.cs
using System;
using System.Windows.Forms;
using System.IO;       // For file operations
using Newtonsoft.Json; // Make sure you have the Newtonsoft.Json NuGet package installed
using System.Drawing;  // For Image

namespace WindowsFormsApp1
{
    // Ensure UserProfile.cs exists and is in the same namespace or accessible
    // public class UserProfile { /* ... properties ... */ }

    public partial class ProfileViewUserControl : UserControl
    {
        public event EventHandler GoBackRequested; // Event to signal when the user wants to go back

        public ProfileViewUserControl()
        {
            InitializeComponent(); // This loads the controls defined in the Designer.cs file
            this.btnGoBack.Click += BtnGoBack_Click; // Wire up the Go Back button
        }

        /// <summary>
        /// Loads and displays the provided user profile data onto the control.
        /// This method is for displaying an already loaded UserProfile object.
        /// </summary>
        /// <param name="profile">The UserProfile object containing data to display.</param>
        public void LoadProfileData(UserProfile profile)
        {
            lblUserName.Text = profile.Username;
            lblEmailValue.Text = profile.Email;
            lblPhoneNumberValue.Text = profile.PhoneNumber;

            // Load profile photo if path exists and the file is accessible
            if (!string.IsNullOrEmpty(profile.ProfilePhotoPath) && File.Exists(profile.ProfilePhotoPath))
            {
                try
                {
                    using (Image img = Image.FromFile(profile.ProfilePhotoPath))
                    {
                        pbProfilePhoto.Image = new Bitmap(img);
                    }
                    pbProfilePhoto.SizeMode = PictureBoxSizeMode.Zoom;
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

        /// <summary>
        /// Attempts to load user profile data directly from a saved JSON file.
        /// This is useful for loading the *persisted* profile for the "Profile" view.
        /// </summary>
        /// <param name="username">The username associated with the profile JSON file.</param>
        public void LoadProfileFromSavedJson(string username)
        {
            try
            {
                // Define the directory path where JSON profiles are saved (same as ViewUserUserControl)
                string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsFormsApp1", "UserProfiles");
                string jsonFileName = $"{username}_profile.json"; // Filename based on username
                string jsonFilePath = Path.Combine(appDataPath, jsonFileName);

                if (File.Exists(jsonFilePath)) // Check if the JSON file exists
                {
                    string json = File.ReadAllText(jsonFilePath); // Read JSON content
                    UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(json); // Deserialize to UserProfile object
                    LoadProfileData(profile); // Populate the control with the loaded profile data
                }
                else
                {
                    MessageBox.Show("No saved profile found for this user. Please use 'View User' to set up a profile first.", "Profile Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear labels if no profile found
                    lblUserName.Text = "N/A";
                    lblEmailValue.Text = "N/A";
                    lblPhoneNumberValue.Text = "N/A";
                    pbProfilePhoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading saved profile: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the "Go Back" button
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            GoBackRequested?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}