namespace BankApp
{
    partial class Statement
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
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.GenerateStatement = new System.Windows.Forms.Button();
            this.dgDisplay = new System.Windows.Forms.DataGridView();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneySent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Statement";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(24, 302);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // GenerateStatement
            // 
            this.GenerateStatement.Location = new System.Drawing.Point(316, 299);
            this.GenerateStatement.Name = "GenerateStatement";
            this.GenerateStatement.Size = new System.Drawing.Size(75, 23);
            this.GenerateStatement.TabIndex = 2;
            this.GenerateStatement.Text = "Display";
            this.GenerateStatement.UseVisualStyleBackColor = true;
            this.GenerateStatement.Click += new System.EventHandler(this.GenerateStatement_Click);
            // 
            // dgDisplay
            // 
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deposit,
            this.Withdraw,
            this.MoneySent,
            this.MoneyReceived,
            this.DateOfTransaction});
            this.dgDisplay.Location = new System.Drawing.Point(62, 61);
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.Size = new System.Drawing.Size(598, 186);
            this.dgDisplay.TabIndex = 3;
            // 
            // Deposit
            // 
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.Name = "Deposit";
            // 
            // Withdraw
            // 
            this.Withdraw.HeaderText = "Withdraw";
            this.Withdraw.Name = "Withdraw";
            // 
            // MoneySent
            // 
            this.MoneySent.HeaderText = "MoneySent";
            this.MoneySent.Name = "MoneySent";
            // 
            // MoneyReceived
            // 
            this.MoneyReceived.HeaderText = "MoneyReceived";
            this.MoneyReceived.Name = "MoneyReceived";
            // 
            // DateOfTransaction
            // 
            this.DateOfTransaction.HeaderText = "DateOfTransaction";
            this.DateOfTransaction.Name = "DateOfTransaction";
            this.DateOfTransaction.Width = 150;
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 344);
            this.Controls.Add(this.dgDisplay);
            this.Controls.Add(this.GenerateStatement);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "Statement";
            this.Text = "Statement";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button GenerateStatement;
        public System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneySent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfTransaction;
        private System.Windows.Forms.DataGridView dgDisplay;
    }
}