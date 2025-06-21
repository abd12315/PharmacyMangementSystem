namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Declare new controls for the header
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();

            // Existing controls from your provided code, now styled
            this.labelUsername = new System.Windows.Forms.Label(); // Renamed from label1
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label(); // Renamed from label2
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label(); // Renamed from label3
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.linkSwitchToRegister = new System.Windows.Forms.LinkLabel();
            this.linkSwitchToLogin = new System.Windows.Forms.LinkLabel();

            // Suspend layout for efficient updates
            this.panelHeader.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelConfirmPassword.SuspendLayout();
            this.SuspendLayout();

            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Standard font scale for consistency
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black; // Dark background to highlight the form panel
            this.ClientSize = new System.Drawing.Size(450, 500); // Adjusted size to fit the new design including header
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // No default title bar
            this.MaximizeBox = false; // Still no maximize box
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Login & Register"; // Keep original text

            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136))))); // Teal/turquoise color
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top; // Docks to the top of the form
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(450, 50); // Height of the header
            this.panelHeader.TabIndex = 0; // Set appropriate tab index

            //
            // buttonClose
            //
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(410, 0); // Position in top-right of panelHeader (450 - 40 = 410)
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 0; // Tab index for the close button
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // The event handler for this button will be in Form1.cs

            //
            // labelUsername
            //
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font
            this.labelUsername.ForeColor = System.Drawing.Color.White; // Set text color to white
            this.labelUsername.Location = new System.Drawing.Point(45, 80); // Adjusted Y for header
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 19); // Adjusted size due to font change
            this.labelUsername.Text = "Username:";

            //
            // panelUsername
            //
            this.panelUsername.Location = new System.Drawing.Point(145, 75); // Adjusted Y for header
            this.panelUsername.Size = new System.Drawing.Size(250, 35); // Slightly larger for better visual
            this.panelUsername.BackColor = System.Drawing.Color.White; // Panel background white
            this.panelUsername.BorderStyle = System.Windows.Forms.BorderStyle.None; // No border for the panel
            this.panelUsername.Padding = new System.Windows.Forms.Padding(5);
            this.panelUsername.Controls.Add(this.txtUsername);

            //
            // txtUsername
            //
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None; // Keep borderless
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill; // Fill parent panel
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font

            //
            // labelPassword
            //
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font
            this.labelPassword.ForeColor = System.Drawing.Color.White; // Set text color to white
            this.labelPassword.Location = new System.Drawing.Point(45, 150); // Adjusted Y
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 19); // Adjusted size
            this.labelPassword.Text = "Password:";

            //
            // panelPassword
            //
            this.panelPassword.Location = new System.Drawing.Point(145, 145); // Adjusted Y
            this.panelPassword.Size = new System.Drawing.Size(250, 35); // Slightly larger
            this.panelPassword.BackColor = System.Drawing.Color.White; // Panel background white
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.None; // No border for the panel
            this.panelPassword.Padding = new System.Windows.Forms.Padding(5);
            this.panelPassword.Controls.Add(this.txtPassword);

            //
            // txtPassword
            //
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None; // Keep borderless
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill; // Fill parent panel
            this.txtPassword.UseSystemPasswordChar = true; // Keep password char
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font

            //
            // labelConfirmPassword
            //
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White; // Set text color to white
            this.labelConfirmPassword.Location = new System.Drawing.Point(15, 220); // Adjusted Y
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(130, 19); // Adjusted size
            this.labelConfirmPassword.Text = "Confirm Password:";
            this.labelConfirmPassword.Visible = false; // Keep visibility as per original

            //
            // panelConfirmPassword
            //
            this.panelConfirmPassword.Location = new System.Drawing.Point(145, 215); // Adjusted Y
            this.panelConfirmPassword.Size = new System.Drawing.Size(250, 35); // Slightly larger
            this.panelConfirmPassword.BackColor = System.Drawing.Color.White; // Panel background white
            this.panelConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None; // No border for the panel
            this.panelConfirmPassword.Padding = new System.Windows.Forms.Padding(5);
            this.panelConfirmPassword.Visible = false; // Keep visibility as per original
            this.panelConfirmPassword.Controls.Add(this.txtConfirmPassword);

            //
            // txtConfirmPassword
            //
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None; // Keep borderless
            this.txtConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill; // Fill parent panel
            this.txtConfirmPassword.UseSystemPasswordChar = true; // Keep password char
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Consistent font

            //
            // btnLogin
            //
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(70))))); // Apply orange-red color
            this.btnLogin.FlatAppearance.BorderSize = 0; // Remove border
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Bold font
            this.btnLogin.ForeColor = System.Drawing.Color.White; // White text
            this.btnLogin.Location = new System.Drawing.Point(95, 275); // Adjusted position for new layout
            this.btnLogin.Size = new System.Drawing.Size(260, 45); // Larger button size
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false; // Important for custom backcolor to show
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click); // Keep event handler

            //
            // btnRegister
            //
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(70))))); // Apply orange-red color
            this.btnRegister.FlatAppearance.BorderSize = 0; // Remove border
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Bold font
            this.btnRegister.ForeColor = System.Drawing.Color.White; // White text
            this.btnRegister.Location = new System.Drawing.Point(95, 345); // Adjusted position for new layout
            this.btnRegister.Size = new System.Drawing.Size(260, 45); // Larger button size
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false; // Important for custom backcolor to show
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click); // Keep event handler
            this.btnRegister.Visible = false; // Keep visibility as per original

            //
            // linkSwitchToRegister
            //
            this.linkSwitchToRegister.AutoSize = true;
            this.linkSwitchToRegister.LinkColor = System.Drawing.Color.LightBlue; // Link color
            this.linkSwitchToRegister.Location = new System.Drawing.Point(95, 410); // Adjusted position
            this.linkSwitchToRegister.Text = "Don't have an account? Register";
            this.linkSwitchToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSwitchToRegister_LinkClicked);

            //
            // linkSwitchToLogin
            //
            this.linkSwitchToLogin.AutoSize = true;
            this.linkSwitchToLogin.LinkColor = System.Drawing.Color.LightBlue; // Link color
            this.linkSwitchToLogin.Location = new System.Drawing.Point(95, 440); // Adjusted position for clarity, moved it below register link
            this.linkSwitchToLogin.Text = "Already have an account? Login";
            this.linkSwitchToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSwitchToLogin_LinkClicked);
            this.linkSwitchToLogin.Visible = false; // Keep visibility as per original

            //
            // Controls (order matters for z-index, but with panels, it's less critical)
            // Ensure the panelHeader is added first so it's at the top
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.panelConfirmPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.linkSwitchToRegister);
            this.Controls.Add(this.linkSwitchToLogin);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Existing private members, updated to use more descriptive names
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkSwitchToRegister;
        private System.Windows.Forms.LinkLabel linkSwitchToLogin;

        // New private members for the header and close button
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonClose;
    }
}