namespace BankApp
{
    partial class SendMoney
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
            this.txtSendMoney = new System.Windows.Forms.TextBox();
            this.Send_Money = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNumber1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(159, 145);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(110, 20);
            this.txtAccountNumber.TabIndex = 14;
            // 
            // txtSendMoney
            // 
            this.txtSendMoney.Location = new System.Drawing.Point(159, 87);
            this.txtSendMoney.Name = "txtSendMoney";
            this.txtSendMoney.Size = new System.Drawing.Size(110, 20);
            this.txtSendMoney.TabIndex = 13;
            // 
            // Send_Money
            // 
            this.Send_Money.Location = new System.Drawing.Point(176, 207);
            this.Send_Money.Name = "Send_Money";
            this.Send_Money.Size = new System.Drawing.Size(75, 23);
            this.Send_Money.TabIndex = 12;
            this.Send_Money.Text = "Send";
            this.Send_Money.UseVisualStyleBackColor = true;
            this.Send_Money.Click += new System.EventHandler(this.Send_Money_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Send Money";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter Account Number";
            // 
            // txtAccountNumber1
            // 
            this.txtAccountNumber1.Location = new System.Drawing.Point(159, 171);
            this.txtAccountNumber1.Name = "txtAccountNumber1";
            this.txtAccountNumber1.Size = new System.Drawing.Size(110, 20);
            this.txtAccountNumber1.TabIndex = 16;
            // 
            // SendMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.txtAccountNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtSendMoney);
            this.Controls.Add(this.Send_Money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMoney";
            this.Text = "SendMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAccountNumber;
        public System.Windows.Forms.TextBox txtSendMoney;
        private System.Windows.Forms.Button Send_Money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAccountNumber1;
    }
}