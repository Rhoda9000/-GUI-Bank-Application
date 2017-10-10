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
    public partial class Deposit : Form
    {
        private DBconnect dbConnect;
        public Deposit()
        {
            InitializeComponent();
            txtAccountNumber.Visible = false;
        }

        private void MakeDeposit_Click(object sender, EventArgs e)
        {
            DepositMoney();
        }

        public void DepositMoney()
        {
            dbConnect = new DBconnect();

            string query = "INSERT INTO transactions (AccountNumber,Deposit , Withdraw, MoneySent, MoneyReceived) VALUES (@AccountNumber, @Deposit, 0, 0, 0)";           
            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                if (string.IsNullOrWhiteSpace(txtDeposit.Text))
                {
                    MessageBox.Show("Deposit feild empty");
                }
                else
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
                  

                    txtAccountNumber.Text = Class1.AccountNumber;
                    
                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                    cmd.Parameters.AddWithValue("@Deposit", txtDeposit.Text);

                  
                    //Execute command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deposit Made!!");

                    //close connection
                    this.dbConnect.CloseConnection();
                }
             }      
        }
    }
}
