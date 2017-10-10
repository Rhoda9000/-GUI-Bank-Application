namespace BankApp
{
    partial class Deposit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MakeDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount";
            // 
            // MakeDeposit
            // 
            this.MakeDeposit.Location = new System.Drawing.Point(130, 161);
            this.MakeDeposit.Name = "MakeDeposit";
            this.MakeDeposit.Size = new System.Drawing.Size(75, 23);
            this.MakeDeposit.TabIndex = 2;
            this.MakeDeposit.Text = "Deposit";
            this.MakeDeposit.UseVisualStyleBackColor = true;
            this.MakeDeposit.Click += new System.EventHandler(this.MakeDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(105, 75);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(110, 20);
            this.txtDeposit.TabIndex = 3;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(105, 117);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(110, 20);
            this.txtAccountNumber.TabIndex = 4;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 196);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.MakeDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MakeDeposit;
        public System.Windows.Forms.TextBox txtDeposit;
        public System.Windows.Forms.TextBox txtAccountNumber;
    }
}