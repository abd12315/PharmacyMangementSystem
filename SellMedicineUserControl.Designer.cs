namespace WindowsFormsApp1
{
    partial class SellMedicineUserControl
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
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.txtQuantityToSell = new System.Windows.Forms.TextBox();
            this.labelQuantityToSell = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelDateOfExpiry = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfIssue = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.labelNameOfMedicine = new System.Windows.Forms.Label();
            this.txtNameOfMedicine = new System.Windows.Forms.TextBox();

            this.btnSearchMedicine = new System.Windows.Forms.Button();
            this.txtSearchMedicine = new System.Windows.Forms.TextBox();
            this.labelSearchMedicine = new System.Windows.Forms.Label();

            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();

            this.btnPrint = new System.Windows.Forms.Button();

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
            this.labelTitle.Text = "Sell Medicine";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // panelFormContainer
            //
            this.panelFormContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormContainer.Controls.Add(this.btnCalculateTotal);
            this.panelFormContainer.Controls.Add(this.labelTotalAmount);
            this.panelFormContainer.Controls.Add(this.txtTotalAmount);
            this.panelFormContainer.Controls.Add(this.btnSearchMedicine);
            this.panelFormContainer.Controls.Add(this.txtSearchMedicine);
            this.panelFormContainer.Controls.Add(this.labelSearchMedicine);
            this.panelFormContainer.Controls.Add(this.btnGoBack);
            this.panelFormContainer.Controls.Add(this.btnPrint);
            this.panelFormContainer.Controls.Add(this.btnSell);
            this.panelFormContainer.Controls.Add(this.txtCustomerName);
            this.panelFormContainer.Controls.Add(this.labelCustomerName);
            this.panelFormContainer.Controls.Add(this.txtQuantityToSell);
            this.panelFormContainer.Controls.Add(this.labelQuantityToSell);
            this.panelFormContainer.Controls.Add(this.txtPrice);
            this.panelFormContainer.Controls.Add(this.labelPrice);
            this.panelFormContainer.Controls.Add(this.dtpExpiryDate);
            this.panelFormContainer.Controls.Add(this.labelDateOfExpiry);
            this.panelFormContainer.Controls.Add(this.dtpIssueDate);
            this.panelFormContainer.Controls.Add(this.labelDateOfIssue);
            this.panelFormContainer.Controls.Add(this.txtNameOfMedicine);
            this.panelFormContainer.Controls.Add(this.labelNameOfMedicine);
            this.panelFormContainer.Location = new System.Drawing.Point(90, 70);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(410, 500); // Increased size
            this.panelFormContainer.TabIndex = 1;
            //
            // labelSearchMedicine
            //
            this.labelSearchMedicine.AutoSize = true;
            this.labelSearchMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchMedicine.ForeColor = System.Drawing.Color.White;
            this.labelSearchMedicine.Location = new System.Drawing.Point(50, 40);
            this.labelSearchMedicine.Name = "labelSearchMedicine";
            this.labelSearchMedicine.Size = new System.Drawing.Size(107, 19);
            this.labelSearchMedicine.TabIndex = 1;
            this.labelSearchMedicine.Text = "Search Medicine:";
            //
            // txtSearchMedicine
            //
            this.txtSearchMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMedicine.Location = new System.Drawing.Point(170, 40);
            this.txtSearchMedicine.Name = "txtSearchMedicine";
            this.txtSearchMedicine.Size = new System.Drawing.Size(130, 25);
            this.txtSearchMedicine.TabIndex = 0;
            //
            // btnSearchMedicine
            //
            this.btnSearchMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSearchMedicine.FlatAppearance.BorderSize = 0;
            this.btnSearchMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMedicine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSearchMedicine.Location = new System.Drawing.Point(305, 38);
            this.btnSearchMedicine.Name = "btnSearchMedicine";
            this.btnSearchMedicine.Size = new System.Drawing.Size(70, 28);
            this.btnSearchMedicine.TabIndex = 1;
            this.btnSearchMedicine.Text = "Search";
            this.btnSearchMedicine.UseVisualStyleBackColor = false;
            this.btnSearchMedicine.Click += new System.EventHandler(this.btnSearchMedicine_Click);
            //
            // labelNameOfMedicine
            //
            this.labelNameOfMedicine.AutoSize = true;
            this.labelNameOfMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameOfMedicine.ForeColor = System.Drawing.Color.White;
            this.labelNameOfMedicine.Location = new System.Drawing.Point(50, 90);
            this.labelNameOfMedicine.Name = "labelNameOfMedicine";
            this.labelNameOfMedicine.Size = new System.Drawing.Size(119, 19);
            this.labelNameOfMedicine.TabIndex = 1;
            this.labelNameOfMedicine.Text = "Name of Medicine:";
            //
            // txtNameOfMedicine
            //
            this.txtNameOfMedicine.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOfMedicine.Location = new System.Drawing.Point(170, 90);
            this.txtNameOfMedicine.Name = "txtNameOfMedicine";
            this.txtNameOfMedicine.ReadOnly = true;
            this.txtNameOfMedicine.Size = new System.Drawing.Size(200, 25);
            this.txtNameOfMedicine.TabIndex = 2;
            //
            // labelDateOfIssue
            //
            this.labelDateOfIssue.AutoSize = true;
            this.labelDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfIssue.ForeColor = System.Drawing.Color.White;
            this.labelDateOfIssue.Location = new System.Drawing.Point(50, 140);
            this.labelDateOfIssue.Name = "labelDateOfIssue";
            this.labelDateOfIssue.Size = new System.Drawing.Size(93, 19);
            this.labelDateOfIssue.TabIndex = 3;
            this.labelDateOfIssue.Text = "Date of Issue:";
            //
            // dtpIssueDate
            //
            this.dtpIssueDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.CustomFormat = "yyyy-MM-dd";
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(170, 140);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 25);
            this.dtpIssueDate.TabIndex = 3;
            //
            // labelDateOfExpiry
            //
            this.labelDateOfExpiry.AutoSize = true;
            this.labelDateOfExpiry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfExpiry.ForeColor = System.Drawing.Color.White;
            this.labelDateOfExpiry.Location = new System.Drawing.Point(50, 190);
            this.labelDateOfExpiry.Name = "labelDateOfExpiry";
            this.labelDateOfExpiry.Size = new System.Drawing.Size(95, 19);
            this.labelDateOfExpiry.TabIndex = 5;
            this.labelDateOfExpiry.Text = "Date of Expiry:";
            //
            // dtpExpiryDate
            //
            this.dtpExpiryDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpExpiryDate.Enabled = false;
            this.dtpExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(170, 190);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(200, 25);
            this.dtpExpiryDate.TabIndex = 4;
            //
            // labelPrice
            //
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(50, 240);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 19);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            //
            // txtPrice
            //
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(170, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 25);
            this.txtPrice.TabIndex = 5;
            //
            // labelQuantityToSell
            //
            this.labelQuantityToSell.AutoSize = true;
            this.labelQuantityToSell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityToSell.ForeColor = System.Drawing.Color.White;
            this.labelQuantityToSell.Location = new System.Drawing.Point(50, 290);
            this.labelQuantityToSell.Name = "labelQuantityToSell";
            this.labelQuantityToSell.Size = new System.Drawing.Size(103, 19);
            this.labelQuantityToSell.TabIndex = 9;
            this.labelQuantityToSell.Text = "Quantity to Sell:";
            //
            // txtQuantityToSell
            //
            this.txtQuantityToSell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityToSell.Location = new System.Drawing.Point(170, 290);
            this.txtQuantityToSell.Name = "txtQuantityToSell";
            this.txtQuantityToSell.Size = new System.Drawing.Size(200, 25);
            this.txtQuantityToSell.TabIndex = 6;
            //
            // btnCalculateTotal
            //
            this.btnCalculateTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCalculateTotal.FlatAppearance.BorderSize = 0;
            this.btnCalculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalculateTotal.Location = new System.Drawing.Point(50, 330);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(110, 28);
            this.btnCalculateTotal.TabIndex = 7;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = false;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            //
            // labelTotalAmount
            //
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.White;
            this.labelTotalAmount.Location = new System.Drawing.Point(170, 335);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(92, 19);
            this.labelTotalAmount.TabIndex = 11;
            this.labelTotalAmount.Text = "Total Amount:";
            //
            // txtTotalAmount
            //
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(270, 332);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 25);
            this.txtTotalAmount.TabIndex = 8;
            //
            // labelCustomerName
            //
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.White;
            this.labelCustomerName.Location = new System.Drawing.Point(50, 380);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(107, 19);
            this.labelCustomerName.TabIndex = 11;
            this.labelCustomerName.Text = "Customer Name:";
            //
            // txtCustomerName
            //
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(170, 380);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 25);
            this.txtCustomerName.TabIndex = 9;
            //
            // btnGoBack
            //
            this.btnGoBack.BackColor = System.Drawing.Color.White;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black;
            this.btnGoBack.Location = new System.Drawing.Point(150, 430);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(110, 40);
            this.btnGoBack.TabIndex = 11;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            //
            // btnSell
            //
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(20, 430);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(110, 40);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            //
            // btnPrint
            //
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(280, 430);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 40);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            //
            // SellMedicineUserControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panelFormContainer);
            this.Controls.Add(this.labelTitle);
            this.Name = "SellMedicineUserControl";
            this.Size = new System.Drawing.Size(590, 580);
            this.panelFormContainer.ResumeLayout(false);
            this.panelFormContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox txtQuantityToSell;
        private System.Windows.Forms.Label labelQuantityToSell;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label labelDateOfExpiry;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label labelDateOfIssue;
        private System.Windows.Forms.TextBox txtNameOfMedicine;
        private System.Windows.Forms.Label labelNameOfMedicine;
        private System.Windows.Forms.Button btnSearchMedicine;
        private System.Windows.Forms.TextBox txtSearchMedicine;
        private System.Windows.Forms.Label labelSearchMedicine;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnPrint;
    }
}