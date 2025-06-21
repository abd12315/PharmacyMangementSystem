using System;
using System.Windows.Forms; // This is necessary for MessageBox and other WinForms controls
using System.Drawing; // Required for Font and Color
using WindowsFormsApp1; // Assuming your new UserControls and UserProfile are in this namespace

namespace WindowsFormsApp1
{
    public partial class DashboardForm : Form
    {
        private bool isHamburgerVertical = false; // Reintroduced to control button text state
        private bool isDashboardSubMenuOpen = false;

        private string loggedInUsername; // Private field to store the logged-in username

        // Public property to allow setting the username from the login form (Form1)
        public string LoggedInUsername
        {
            get { return loggedInUsername; }
            set
            {
                loggedInUsername = value;
                // Update the welcome label text immediately when the username is set
                // This is important because the DashboardForm might be initialized
                // before the username is fully set from the login form.
                UpdateWelcomeLabelText();
            }
        }

        public DashboardForm()
        {
            InitializeComponent(); // This method from Designer.cs creates all your controls, including labelWelcome

            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonHamburger.Click += new System.EventHandler(this.buttonHamburger_Click);
            this.panelSideMenu.Visible = false; // Ensure it's hidden on load
            this.panelMedicineSubMenu.Visible = false; // Ensure sub-menu is hidden on load

            // Set initial hamburger button text
            this.buttonHamburger.Text = "☰"; // Horizontal lines for closed menu

            // Wire up click events for all main menu buttons
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Wire up click events for new sub-menu buttons
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            this.btnRemoveMedicine.Click += new System.EventHandler(this.btnRemoveMedicine_Click);
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);

            // Call ShowWelcomeLabel initially, but also call UpdateWelcomeLabelText
            // in the LoggedInUsername setter to ensure it updates when the username is passed.
            ShowWelcomeLabel();
        }

        // New method to specifically update the welcome label's text
        private void UpdateWelcomeLabelText()
        {
            if (this.labelWelcome != null)
            {
                this.labelWelcome.Text = $"Welcome, {this.loggedInUsername}!"; // Use string interpolation
            }
        }

        public void ShowWelcomeLabel()
        {
            panelContent.Controls.Clear();
            // labelWelcome is available because InitializeComponent() creates it.
            if (!panelContent.Controls.Contains(this.labelWelcome))
            {
                panelContent.Controls.Add(this.labelWelcome);
                this.labelWelcome.Dock = DockStyle.Fill;
                this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.labelWelcome.BringToFront();
            }
            // Ensure the text is set correctly when the label is shown/re-shown
            UpdateWelcomeLabelText();
        }

        // Event Handlers for main menu buttons
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHamburger_Click(object sender, EventArgs e)
        {
            panelSideMenu.Visible = !panelSideMenu.Visible;

            // Toggle the boolean state
            isHamburgerVertical = !isHamburgerVertical;

            // Change the hamburger button text based on the state
            if (isHamburgerVertical)
            {
                this.buttonHamburger.Text = "||"; // Vertical lines for open menu (or an 'X')
                // Optionally adjust panelContent size/location if side menu appears on top
                panelContent.Location = new System.Drawing.Point(panelSideMenu.Width, panelContent.Location.Y);
                panelContent.Size = new System.Drawing.Size(this.ClientSize.Width - panelSideMenu.Width, panelContent.Height);
            }
            else
            {
                this.buttonHamburger.Text = "☰"; // Horizontal lines for closed menu
                // Reset panelContent when side menu is hidden
                panelContent.Location = new System.Drawing.Point(0, panelContent.Location.Y);
                panelContent.Size = new System.Drawing.Size(this.ClientSize.Width, panelContent.Height);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Toggle visibility of the medicine sub-menu
            isDashboardSubMenuOpen = !isDashboardSubMenuOpen;
            panelMedicineSubMenu.Visible = isDashboardSubMenuOpen;

            // If the sub-menu is now open, adjust the location of subsequent buttons
            // Otherwise, they will revert to their original positions (defined in Designer.cs)
            if (isDashboardSubMenuOpen)
            {
                // Shift subsequent buttons down by the height of panelMedicineSubMenu (180px)
                btnAddUser.Location = new System.Drawing.Point(0, 45 + panelMedicineSubMenu.Height); // 45 (Dashboard height) + 180 (SubMenu height)
                btnViewUser.Location = new System.Drawing.Point(0, btnAddUser.Location.Y + btnAddUser.Height);
                btnProfile.Location = new System.Drawing.Point(0, btnViewUser.Location.Y + btnViewUser.Height);
                btnLogout.Location = new System.Drawing.Point(0, btnProfile.Location.Y + btnProfile.Height);
            }
            else
            {
                // Revert to original positions when sub-menu is closed
                btnAddUser.Location = new System.Drawing.Point(0, 225); // Original Y (45 Dashboard + 180 phantom sub-menu space)
                btnViewUser.Location = new System.Drawing.Point(0, 270); // Original Y
                btnProfile.Location = new System.Drawing.Point(0, 315); // Original Y
                btnLogout.Location = new System.Drawing.Point(0, 360); // Original Y
            }

            // Display welcome label or specific dashboard content
            ShowWelcomeLabel();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Clear current content and display an "Under Development" message
            panelContent.Controls.Clear();

            Label underDevLabel = new Label();
            underDevLabel.Text = "Add User Feature:\nUnder Development"; // Added newline for better display
            underDevLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            underDevLabel.ForeColor = Color.LightCoral;
            underDevLabel.AutoSize = false; // Set to false to allow docking to fill
            underDevLabel.Dock = DockStyle.Fill;
            underDevLabel.TextAlign = ContentAlignment.MiddleCenter; // Center the text within the label

            panelContent.Controls.Add(underDevLabel);
            underDevLabel.BringToFront(); // Ensure it's on top
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            // Clear current content and add the ViewUserUserControl
            panelContent.Controls.Clear();
            ViewUserUserControl viewUserControl = new ViewUserUserControl();
            viewUserControl.Dock = DockStyle.Fill;

            // Pass the logged-in username to the ViewUserUserControl.
            // ViewUserUserControl.LoadUserProfileData will use this username to load the profile.
            // For now, it initializes with default data, but the username is passed for file loading.
            viewUserControl.LoadUserProfileData(new UserProfile
            {
                Username = this.loggedInUsername, // Pass the logged-in username here
                Email = "email@example.com",     // Default, will be overwritten by JSON load
                PhoneNumber = "123-456-7890",    // Default, will be overwritten by JSON load
                ProfilePhotoPath = ""            // Default, will be overwritten by JSON load
            });

            // Subscribe to the GoBackRequested event to return to the welcome label
            viewUserControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();

            panelContent.Controls.Add(viewUserControl);
            viewUserControl.BringToFront(); // Ensure it's on top
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Clear current content and add the ProfileViewUserControl
            panelContent.Controls.Clear();
            ProfileViewUserControl profileViewControl = new ProfileViewUserControl();
            profileViewControl.Dock = DockStyle.Fill;

            // Set the title dynamically to "View <Logged-in User Name> Profile"
            profileViewControl.lblTitle.Text = $"View {this.loggedInUsername}'s Profile";

            // Load data from the saved JSON file based on the logged-in username
            profileViewControl.LoadProfileFromSavedJson(this.loggedInUsername);

            // Subscribe to the GoBackRequested event to return to the welcome label
            profileViewControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();

            panelContent.Controls.Add(profileViewControl);
            profileViewControl.BringToFront(); // Ensure it's on top
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out...");
            this.Hide();
            Form1 loginForm = new Form1(); // Assuming Form1 is your login form
            loginForm.Show();
        }

        // Event Handlers for NEW Medicine Sub-Menu Buttons
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            AddMedicineUserControl addMedicineControl = new AddMedicineUserControl();
            addMedicineControl.Dock = DockStyle.Fill;
            // You might want to add a GoBackRequested event for other user controls as well
            // addMedicineControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();
            panelContent.Controls.Add(addMedicineControl);
            addMedicineControl.BringToFront();
        }

        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            RemoveMedicineUserControl removeMedicineControl = new RemoveMedicineUserControl(); // Assuming you have this UserControl
            removeMedicineControl.Dock = DockStyle.Fill;
            // You might want to add a GoBackRequested event for other user controls as well
            // removeMedicineControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();
            panelContent.Controls.Add(removeMedicineControl);
            removeMedicineControl.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            SellMedicineUserControl sellMedicineControl = new SellMedicineUserControl(); // Assuming you have this UserControl
            sellMedicineControl.Dock = DockStyle.Fill;
            // You might want to add a GoBackRequested event for other user controls as well
            // sellMedicineControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();
            panelContent.Controls.Add(sellMedicineControl);
            sellMedicineControl.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            // This is the line that will now load your ModifyMedicineUserControl
            ModifyMedicineUserControl modifyMedicineControl = new ModifyMedicineUserControl();
            modifyMedicineControl.Dock = DockStyle.Fill;
            // Subscribe to the GoBackRequested event of the UserControl
            modifyMedicineControl.GoBackRequested += (s, ev) => ShowWelcomeLabel();
            panelContent.Controls.Add(modifyMedicineControl);
            modifyMedicineControl.BringToFront();
        }
    }
}