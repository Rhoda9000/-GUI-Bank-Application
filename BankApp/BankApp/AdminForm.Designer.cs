namespace BankApp
{
    partial class AdminForm
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
            this.RegisterCustomer = new System.Windows.Forms.Button();
            this.ActiveCustomers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterCustomer
            // 
            this.RegisterCustomer.Location = new System.Drawing.Point(71, 74);
            this.RegisterCustomer.Name = "RegisterCustomer";
            this.RegisterCustomer.Size = new System.Drawing.Size(152, 53);
            this.RegisterCustomer.TabIndex = 0;
            this.RegisterCustomer.Text = "Register Customers";
            this.RegisterCustomer.UseVisualStyleBackColor = true;
            this.RegisterCustomer.Click += new System.EventHandler(this.RegisterCustomer_Click);
            // 
            // ActiveCustomers
            // 
            this.ActiveCustomers.Location = new System.Drawing.Point(71, 169);
            this.ActiveCustomers.Name = "ActiveCustomers";
            this.ActiveCustomers.Size = new System.Drawing.Size(152, 57);
            this.ActiveCustomers.TabIndex = 1;
            this.ActiveCustomers.Text = "Check Active Customers";
            this.ActiveCustomers.UseVisualStyleBackColor = true;
            this.ActiveCustomers.Click += new System.EventHandler(this.ActiveCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActiveCustomers);
            this.Controls.Add(this.RegisterCustomer);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterCustomer;
        private System.Windows.Forms.Button ActiveCustomers;
        private System.Windows.Forms.Label label1;
    }
}