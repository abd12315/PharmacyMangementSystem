namespace WindowsFormsApp1
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonHamburger = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            // Existing Main Menu Buttons
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();

            // NEW: Sub-Menu Buttons for Medicine Management
            this.panelMedicineSubMenu = new System.Windows.Forms.Panel(); // A panel to hold sub-buttons
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnRemoveMedicine = new System.Windows.Forms.Button();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.btnModifyMedicine = new System.Windows.Forms.Button();


            this.panelContent = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelMedicineSubMenu.SuspendLayout(); // Add this line for the new sub-panel
            this.SuspendLayout();

            //
            // DashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";

            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelHeader.Controls.Add(this.buttonHamburger);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.panelHeader.TabIndex = 0;

            //
            // buttonClose
            //
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(760, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;

            //
            // buttonHamburger
            //
            this.buttonHamburger.BackColor = System.Drawing.Color.Transparent;
            this.buttonHamburger.FlatAppearance.BorderSize = 0;
            this.buttonHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHamburger.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHamburger.ForeColor = System.Drawing.Color.White;
            this.buttonHamburger.Location = new System.Drawing.Point(10, 5);
            this.buttonHamburger.Name = "buttonHamburger";
            this.buttonHamburger.Size = new System.Drawing.Size(40, 40);
            this.buttonHamburger.TabIndex = 1;
            this.buttonHamburger.Text = "☰";
            this.buttonHamburger.UseVisualStyleBackColor = false;

            //
            // panelSideMenu
            //
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            // Add the main menu buttons and the new sub-menu panel
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnProfile);
            this.panelSideMenu.Controls.Add(this.btnViewUser);
            this.panelSideMenu.Controls.Add(this.btnAddUser);
            this.panelSideMenu.Controls.Add(this.panelMedicineSubMenu); // Add the sub-menu panel here
            this.panelSideMenu.Controls.Add(this.btnDashboard); // Added last to appear at the top when docked Top
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 550);
            this.panelSideMenu.TabIndex = 2;
            this.panelSideMenu.Visible = false;

            //
            // btnDashboard
            //
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::WindowsFormsApp1.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;

            //
            // panelMedicineSubMenu (NEW SUB-MENU PANEL)
            //
            this.panelMedicineSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))); // Slightly different color for sub-menu
            this.panelMedicineSubMenu.Controls.Add(this.btnModifyMedicine);
            this.panelMedicineSubMenu.Controls.Add(this.btnSellMedicine);
            this.panelMedicineSubMenu.Controls.Add(this.btnRemoveMedicine);
            this.panelMedicineSubMenu.Controls.Add(this.btnAddMedicine);
            this.panelMedicineSubMenu.Dock = System.Windows.Forms.DockStyle.Top; // Docks below btnDashboard
            this.panelMedicineSubMenu.Location = new System.Drawing.Point(0, 45); // Adjust Y based on previous button's height
            this.panelMedicineSubMenu.Name = "panelMedicineSubMenu";
            this.panelMedicineSubMenu.Size = new System.Drawing.Size(200, 180); // Height for 4 buttons (4 * 45)
            this.panelMedicineSubMenu.TabIndex = 5; // Adjust tab index
            this.panelMedicineSubMenu.Visible = false; // Initially hidden!

            //
            // btnAddMedicine (NEW SUB-MENU BUTTON)
            //
            this.btnAddMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMedicine.FlatAppearance.BorderSize = 0;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = global::WindowsFormsApp1.Properties.Resources.add_medicine_icon; // Add this icon
            this.btnAddMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnAddMedicine.Location = new System.Drawing.Point(0, 0);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0); // Indent sub-menu items
            this.btnAddMedicine.Size = new System.Drawing.Size(200, 45);
            this.btnAddMedicine.TabIndex = 0;
            this.btnAddMedicine.Text = "  Add Medicine";
            this.btnAddMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMedicine.UseVisualStyleBackColor = true;

            //
            // btnRemoveMedicine (NEW SUB-MENU BUTTON)
            //
            this.btnRemoveMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveMedicine.FlatAppearance.BorderSize = 0;
            this.btnRemoveMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMedicine.Image = global::WindowsFormsApp1.Properties.Resources.remove_medicine_icon; // Add this icon
            this.btnRemoveMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnRemoveMedicine.Location = new System.Drawing.Point(0, 45);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRemoveMedicine.Size = new System.Drawing.Size(200, 45);
            this.btnRemoveMedicine.TabIndex = 1;
            this.btnRemoveMedicine.Text = "  Remove Medicine";
            this.btnRemoveMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnRemoveMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveMedicine.UseVisualStyleBackColor = true;

            //
            // btnSellMedicine (NEW SUB-MENU BUTTON)
            //
            this.btnSellMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellMedicine.FlatAppearance.BorderSize = 0;
            this.btnSellMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Image = global::WindowsFormsApp1.Properties.Resources.sell_medicine_icon; // Add this icon
            this.btnSellMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnSellMedicine.Location = new System.Drawing.Point(0, 90);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSellMedicine.Size = new System.Drawing.Size(200, 45);
            this.btnSellMedicine.TabIndex = 2;
            this.btnSellMedicine.Text = "  Sell Medicine";
            this.btnSellMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnSellMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellMedicine.UseVisualStyleBackColor = true;

            //
            // btnModifyMedicine (NEW SUB-MENU BUTTON)
            //
            this.btnModifyMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifyMedicine.FlatAppearance.BorderSize = 0;
            this.btnModifyMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = global::WindowsFormsApp1.Properties.Resources.modify_medicine_icon; // Add this icon
            this.btnModifyMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnModifyMedicine.Location = new System.Drawing.Point(0, 135);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModifyMedicine.Size = new System.Drawing.Size(200, 45);
            this.btnModifyMedicine.TabIndex = 3;
            this.btnModifyMedicine.Text = "  Modify Medicine";
            this.btnModifyMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnModifyMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyMedicine.UseVisualStyleBackColor = true;


            //
            // btnAddUser
            //
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::WindowsFormsApp1.Properties.Resources.add_user_icon;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnAddUser.Location = new System.Drawing.Point(0, 225); // Adjusted Y for Dashboard + SubMenu
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(200, 45);
            this.btnAddUser.TabIndex = 1; // TabIndex needs adjustment too
            this.btnAddUser.Text = "  Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;

            //
            // btnViewUser
            //
            this.btnViewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Image = global::WindowsFormsApp1.Properties.Resources.view_user_icon;
            this.btnViewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnViewUser.Location = new System.Drawing.Point(0, 270); // Adjusted Y
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnViewUser.Size = new System.Drawing.Size(200, 45);
            this.btnViewUser.TabIndex = 2; // TabIndex needs adjustment too
            this.btnViewUser.Text = "  View User";
            this.btnViewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnViewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewUser.UseVisualStyleBackColor = true;

            //
            // btnProfile
            //
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::WindowsFormsApp1.Properties.Resources.profile_icon;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnProfile.Location = new System.Drawing.Point(0, 315); // Adjusted Y
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(200, 45);
            this.btnProfile.TabIndex = 3; // TabIndex needs adjustment too
            this.btnProfile.Text = "  Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;

            //
            // btnLogout
            //
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.logout_icon;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnLogout.Location = new System.Drawing.Point(0, 360); // Adjusted Y
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 4; // TabIndex needs adjustment too
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // CORRECTED
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;


            //
            // panelContent
            //
            this.panelContent.BackColor = System.Drawing.Color.DimGray;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Controls.Add(this.labelWelcome);
            this.panelContent.Location = new System.Drawing.Point(0, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 550);
            this.panelContent.TabIndex = 1;

            //
            // labelWelcome (Example Content)
            //
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(200, 200);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(300, 45);
            this.labelWelcome.Text = "Welcome to Dashboard!";


            //
            // Controls
            //
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelHeader);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout(); // Ensure this is present
            this.panelMedicineSubMenu.ResumeLayout(false); // New sub-panel layout
            this.panelMedicineSubMenu.PerformLayout(); // New sub-panel layout
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHamburger;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelSideMenu;

        // Existing Main Menu Button declarations
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;

        // NEW: Sub-Menu Panel and Button declarations
        private System.Windows.Forms.Panel panelMedicineSubMenu;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnRemoveMedicine;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Button btnModifyMedicine;
    }
}