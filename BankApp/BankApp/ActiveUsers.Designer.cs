namespace BankApp
{
    partial class ActiveUsers
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
            this.DisplayActiveCustomers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayActiveCustomers
            // 
            this.DisplayActiveCustomers.Location = new System.Drawing.Point(432, 359);
            this.DisplayActiveCustomers.Name = "DisplayActiveCustomers";
            this.DisplayActiveCustomers.Size = new System.Drawing.Size(75, 23);
            this.DisplayActiveCustomers.TabIndex = 6;
            this.DisplayActiveCustomers.Text = "Display";
            this.DisplayActiveCustomers.UseVisualStyleBackColor = true;
            this.DisplayActiveCustomers.Click += new System.EventHandler(this.DisplayActiveCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active Customers";
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Surname,
            this.DOB,
            this.IDNumber,
            this.Address,
            this.Town,
            this.City,
            this.CellNumber,
            this.AccountNumber});
            this.dgDisplay.Location = new System.Drawing.Point(29, 84);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(946, 239);
            this.dgDisplay.TabIndex = 7;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            // 
            // IDNumber
            // 
            this.IDNumber.HeaderText = "IDNumber";
            this.IDNumber.Name = "IDNumber";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Town
            // 
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // CellNumber
            // 
            this.CellNumber.HeaderText = "CellNumber";
            this.CellNumber.Name = "CellNumber";
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            // 
            // ActiveUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 413);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.DisplayActiveCustomers);
            this.Controls.Add(this.label1);
            this.Name = "ActiveUsers";
            this.Text = "ActiveUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button DisplayActiveCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
    }
}