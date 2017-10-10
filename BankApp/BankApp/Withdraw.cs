using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankApp
{
    public partial class Withdraw : Form
    {
        private DBconnect dbConnect;
        public Withdraw()
        {
            InitializeComponent();
            txtAccountNumber.Visible = false;
        }

        private void MakeWithdrawl_Click(object sender, EventArgs e)
        {
            WithdrawMoney();
        }

        public void WithdrawMoney()
        {
            dbConnect = new DBconnect();

            string query = "INSERT INTO transactions (AccountNumber,Deposit , Withdraw, MoneySent, MoneyReceived) VALUES (@AccountNumber, 0, @Withdraw, 0, 0)";
            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                if (string.IsNullOrWhiteSpace(txtWithdraw.Text))
                {
                    MessageBox.Show("Withdrawl feild empty");
                }
                else
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);


                    txtAccountNumber.Text = Class1.AccountNumber;

                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                    cmd.Parameters.AddWithValue("@Withdraw", "-"+txtWithdraw.Text);


                    //Execute command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Withdrawl Made!!");

                    //close connection
                    this.dbConnect.CloseConnection();
                }
            }
        }
    }
}
