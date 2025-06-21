// ProfileViewUserControl.Designer.cs
namespace WindowsFormsApp1
{
    partial class ProfileViewUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserNameLabel = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbProfilePhoto = new System.Windows.Forms.PictureBox();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhoneNumberLabel = new System.Windows.Forms.Label();
            this.lblPhoneNumberValue = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(700, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Profile"; // This will be updated dynamically
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblUserNameLabel
            //
            this.lblUserNameLabel.AutoSize = true;
            this.lblUserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.lblUserNameLabel.Location = new System.Drawing.Point(50, 90);
            this.lblUserNameLabel.Name = "lblUserNameLabel";
            this.lblUserNameLabel.Size = new System.Drawing.Size(107, 28);
            this.lblUserNameLabel.TabIndex = 1;
            this.lblUserNameLabel.Text = "Username:";
            //
            // lblUserName
            //
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(180, 90);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 28);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "[User Name]"; // Will be updated dynamically
            //
            // pbProfilePhoto
            //
            this.pbProfilePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pbProfilePhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfilePhoto.Location = new System.Drawing.Point(480, 90);
            this.pbProfilePhoto.Name = "pbProfilePhoto";
            this.pbProfilePhoto.Size = new System.Drawing.Size(150, 150);
            this.pbProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePhoto.TabIndex = 3;
            this.pbProfilePhoto.TabStop = false;
            //
            // lblEmailLabel
            //
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.ForeColor = System.Drawing.Color.White;
            this.lblEmailLabel.Location = new System.Drawing.Point(50, 150);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(68, 28);
            this.lblEmailLabel.TabIndex = 4;
            this.lblEmailLabel.Text = "Email:";
            //
            // lblEmailValue
            //
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.White;
            this.lblEmailValue.Location = new System.Drawing.Point(180, 150);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(109, 28);
            this.lblEmailValue.TabIndex = 5;
            this.lblEmailValue.Text = "[Email Value]";
            //
            // lblPhoneNumberLabel
            //
            this.lblPhoneNumberLabel.AutoSize = true;
            this.lblPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberLabel.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberLabel.Location = new System.Drawing.Point(50, 210);
            this.lblPhoneNumberLabel.Name = "lblPhoneNumberLabel";
            this.lblPhoneNumberLabel.Size = new System.Drawing.Size(155, 28);
            this.lblPhoneNumberLabel.TabIndex = 6;
            this.lblPhoneNumberLabel.Text = "Phone Number:";
            //
            // lblPhoneNumberValue
            //
            this.lblPhoneNumberValue.AutoSize = true;
            this.lblPhoneNumberValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberValue.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberValue.Location = new System.Drawing.Point(180, 210);
            this.lblPhoneNumberValue.Name = "lblPhoneNumberValue";
            this.lblPhoneNumberValue.Size = new System.Drawing.Size(161, 28);
            this.lblPhoneNumberValue.TabIndex = 7;
            this.lblPhoneNumberValue.Text = "[Phone Number]";
            //
            // btnGoBack
            //
            this.btnGoBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(200, 455);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(180, 45);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            //
            // ProfileViewUserControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblPhoneNumberValue);
            this.Controls.Add(this.lblPhoneNumberLabel);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblEmailLabel);
            this.Controls.Add(this.pbProfilePhoto);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserNameLabel);
            this.Controls.Add(this.lblTitle);
            this.Name = "ProfileViewUserControl";
            this.Size = new System.Drawing.Size(700, 550); // Increased width
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // IMPORTANT: Changed lblTitle to public
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserNameLabel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbProfilePhoto;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPhoneNumberLabel;
        private System.Windows.Forms.Label lblPhoneNumberValue;
        private System.Windows.Forms.Button btnGoBack;
    }
}