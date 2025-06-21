namespace WindowsFormsApp1
{
    partial class RemoveMedicineUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(700, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Remove Medicine";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // dataGridViewMedicines
            //
            this.dataGridViewMedicines.AllowUserToAddRows = false;
            this.dataGridViewMedicines.AllowUserToDeleteRows = false;
            this.dataGridViewMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMedicines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))); // Darker gray background
            this.dataGridViewMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136))))); // Teal header
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedicines.ColumnHeadersHeight = 30;
            this.dataGridViewMedicines.EnableHeadersVisualStyles = false;
            this.dataGridViewMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dataGridViewMedicines.Location = new System.Drawing.Point(20, 90);
            this.dataGridViewMedicines.MultiSelect = false;
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.ReadOnly = true;
            this.dataGridViewMedicines.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Row background
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMedicines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; // Select full row
            this.dataGridViewMedicines.Size = new System.Drawing.Size(660, 350);
            this.dataGridViewMedicines.TabIndex = 1;
            //
            // btnDeleteSelected
            //
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136))))); // Greenish background
            this.btnDeleteSelected.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Location = new System.Drawing.Point(530, 455);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click); // Assign click event
            //
            // btnGoBack
            //
            this.btnGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoBack.BackColor = System.Drawing.Color.White; // White background
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Black; // Black text
            this.btnGoBack.Location = new System.Drawing.Point(20, 455);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(120, 40);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click); // Assign click event
            //
            // RemoveMedicineUserControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray; // Match panelContent background
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dataGridViewMedicines);
            this.Controls.Add(this.labelTitle);
            this.Name = "RemoveMedicineUserControl";
            this.Size = new System.Drawing.Size(700, 500); // Adjusted size for better fit
            this.Load += new System.EventHandler(this.RemoveMedicineUserControl_Load); // Load event to populate data
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnGoBack;
    }
}