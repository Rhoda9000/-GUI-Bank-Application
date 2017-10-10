namespace BankApp
{
    partial class Withdraw
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
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.MakeWithdrawl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(151, 129);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(110, 20);
            this.txtAccountNumber.TabIndex = 9;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(151, 78);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(110, 20);
            this.txtWithdraw.TabIndex = 8;
            // 
            // MakeWithdrawl
            // 
            this.MakeWithdrawl.Location = new System.Drawing.Point(172, 179);
            this.MakeWithdrawl.Name = "MakeWithdrawl";
            this.MakeWithdrawl.Size = new System.Drawing.Size(75, 23);
            this.MakeWithdrawl.TabIndex = 7;
            this.MakeWithdrawl.Text = "Withdraw";
            this.MakeWithdrawl.UseVisualStyleBackColor = true;
            this.MakeWithdrawl.Click += new System.EventHandler(this.MakeWithdrawl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Withdraw";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 224);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.MakeWithdrawl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAccountNumber;
        public System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button MakeWithdrawl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}