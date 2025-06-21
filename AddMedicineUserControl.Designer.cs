namespace WindowsFormsApp1
{
    partial class AddMedicineUserControl
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFormContainer = new System.Windows.Forms.Panel(); // To hold the form elements
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.labelReceiverName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfExpiry = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.txtNameOfMedicine = new System.Windows.Forms.TextBox();
            this.labelNameOfMedicine = new System.Windows.Forms.Label();
            this.panelFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(590, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add New Medicine";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormContainer.Controls.Add(this.btnGoBack);
            this.panelFormContainer.Controls.Add(this.btnSubmit);
            this.panelFormContainer.Controls.Add(this.txtSenderName);
            this.panelFormContainer.Controls.Add(this.labelSenderName);
            this.panelFormContainer.Controls.Add(this.txtReceiverName);
            this.panelFormContainer.Controls.Add(this.labelReceiverName);
            this.panelFormContainer.Controls.Add(this.txtPrice);
            this.panelFormContainer.Controls.Add(this.labelPrice);
            this.panelFormContainer.Controls.Add(this.dtpExpiryDate);
            this.panelFormContainer.Controls.Add(this.labelDateOfExpiry);
            this.panelFormContainer.Controls.Add(this.dtpIssueDate);
            this.panelFormContainer.Controls.Add(this.labelDateOfIssue);
            this.panelFormContainer.Controls.Add(this.txtNameOfMedicine);
            this.panelFormContainer.Controls.Add(this.labelNameOfMedicine);
            this.panelFormContainer.Location = new System.Drawing.Point(90, 70); // Adjusted to make space for the title
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(410, 400); // Adjust size as needed
            this.panelFormContainer.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.White; // White background
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black; // Black text
            this.btnGoBack.Location = new System.Drawing.Point(210, 340); // Adjusted position
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(150, 40);
            this.btnGoBack.TabIndex = 7;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click); // Assign click event
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136))))); // Greenish background
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(50, 340); // Adjusted position
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click); // Assign click event
            // 
            // txtSenderName
            // 
            this.txtSenderName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenderName.Location = new System.Drawing.Point(170, 290); // Adjusted position
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(190, 25);
            this.txtSenderName.TabIndex = 5;
            // 
            // labelSenderName
            // 
            this.labelSenderName.AutoSize = true;
            this.labelSenderName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenderName.ForeColor = System.Drawing.Color.White;
            this.labelSenderName.Location = new System.Drawing.Point(50, 290);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(91, 19);
            this.labelSenderName.TabIndex = 11;
            this.labelSenderName.Text = "Sender Name:";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverName.Location = new System.Drawing.Point(170, 240); // Adjusted position
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(190, 25);
            this.txtReceiverName.TabIndex = 4;
            // 
            // labelReceiverName
            // 
            this.labelReceiverName.AutoSize = true;
            this.labelReceiverName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiverName.ForeColor = System.Drawing.Color.White;
            this.labelReceiverName.Location = new System.Drawing.Point(50, 240);
            this.labelReceiverName.Name = "labelReceiverName";
            this.labelReceiverName.Size = new System.Drawing.Size(99, 19);
            this.labelReceiverName.TabIndex = 9;
            this.labelReceiverName.Text = "Receiver Name:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(170, 190); // Adjusted position
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 25);
            this.txtPrice.TabIndex = 3;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(50, 190);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 19);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(170, 140); // Adjusted position
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(190, 25);
            this.dtpExpiryDate.TabIndex = 2;
            // 
            // labelDateOfExpiry
            // 
            this.labelDateOfExpiry.AutoSize = true;
            this.labelDateOfExpiry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfExpiry.ForeColor = System.Drawing.Color.White;
            this.labelDateOfExpiry.Location = new System.Drawing.Point(50, 140);
            this.labelDateOfExpiry.Name = "labelDateOfExpiry";
            this.labelDateOfExpiry.Size = new System.Drawing.Size(95, 19);
            this.labelDateOfExpiry.TabIndex = 5;
            this.labelDateOfExpiry.Text = "Date of Expiry:";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.CustomFormat = "yyyy-MM-dd";
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(170, 90); // Adjusted position
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(190, 25);
            this.dtpIssueDate.TabIndex = 1;
            // 
            // labelDateOfIssue
            // 
            this.labelDateOfIssue.AutoSize = true;
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfIssue.ForeColor = System.Drawing.Color.White;
            this.labelDateOfIssue.Location = new System.Drawing.Point(50, 90);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(93, 19);
            this.labelDateOfIssue.TabIndex = 3;
            this.labelDateOfIssue.Text = "Date of Issue:";
            // 
            // txtNameOfMedicine
            // 
            this.txtNameOfMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfMedicine.Location = new System.Drawing.Point(170, 40); // Adjusted position
            this.txtNameOfMedicine.Name = "txtNameOfMedicine";
            this.txtNameOfMedicine.Size = new System.Drawing.Size(190, 25);
            this.txtNameOfMedicine.TabIndex = 0;
            // 
            // labelNameOfMedicine
            // 
            this.labelNameOfMedicine.AutoSize = true;
            this.labelNameOfMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfMedicine.ForeColor = System.Drawing.Color.White;
            this.labelNameOfMedicine.Location = new System.Drawing.Point(50, 40);
            this.labelNameOfMedicine.Name = "labelNameOfMedicine";
            this.labelNameOfMedicine.Size = new System.Drawing.Size(119, 19);
            this.labelNameOfMedicine.TabIndex = 1;
            this.labelNameOfMedicine.Text = "Name of Medicine:";
            // 
            // AddMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray; // Match panelContent background
            this.Controls.Add(this.panelFormContainer);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddMedicineUserControl";
            this.Size = new System.Drawing.Size(590, 490); // Adjusted size for better fit
            this.panelFormContainer.ResumeLayout(false);
            this.panelFormContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Label labelReceiverName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label labelDateOfExpiry;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.TextBox txtNameOfMedicine;
        private System.Windows.Forms.Label labelNameOfMedicine;
    }
}