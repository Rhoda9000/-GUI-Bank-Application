namespace BankApp
{
    partial class CustomerChoice
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
            this.Balance = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.SendMoney = new System.Windows.Forms.Button();
            this.DisplayStatement = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(79, 65);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(144, 62);
            this.Balance.TabIndex = 1;
            this.Balance.Text = "Check Balance";
            this.Balance.UseVisualStyleBackColor = true;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(79, 150);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(144, 62);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Location = new System.Drawing.Point(79, 231);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(144, 62);
            this.Withdraw.TabIndex = 3;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // SendMoney
            // 
            this.SendMoney.Location = new System.Drawing.Point(79, 316);
            this.SendMoney.Name = "SendMoney";
            this.SendMoney.Size = new System.Drawing.Size(144, 62);
            this.SendMoney.TabIndex = 4;
            this.SendMoney.Text = "Send Money";
            this.SendMoney.UseVisualStyleBackColor = true;
            this.SendMoney.Click += new System.EventHandler(this.SendMoney_Click);
            // 
            // DisplayStatement
            // 
            this.DisplayStatement.Location = new System.Drawing.Point(79, 405);
            this.DisplayStatement.Name = "DisplayStatement";
            this.DisplayStatement.Size = new System.Drawing.Size(144, 62);
            this.DisplayStatement.TabIndex = 5;
            this.DisplayStatement.Text = "Display Statement";
            this.DisplayStatement.UseVisualStyleBackColor = true;
            this.DisplayStatement.Click += new System.EventHandler(this.DisplayStatement_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(209, 39);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // CustomerChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 495);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.DisplayStatement);
            this.Controls.Add(this.SendMoney);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.label1);
            this.Name = "CustomerChoice";
            this.Text = "CustomerChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Balance;
        public System.Windows.Forms.Button Deposit;
        public System.Windows.Forms.Button Withdraw;
        public System.Windows.Forms.Button SendMoney;
        public System.Windows.Forms.Button DisplayStatement;
        public System.Windows.Forms.TextBox txtAccountNumber;
    }
}