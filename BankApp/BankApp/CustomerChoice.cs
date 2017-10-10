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
    public partial class CustomerChoice : Form
    {
        private DBconnect dbConnect;
        public CustomerChoice()
        {
            InitializeComponent();
            txtAccountNumber.Visible = false;
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            Deposit frm1 = new Deposit();
            frm1.Show();
        }

        private void Balance_Click(object sender, EventArgs e)
        {
            dbConnect = new DBconnect();
            MySqlDataReader myReader;

            string query = "SELECT * ,(SELECT SUM(Deposit)+SUM(Withdraw)+SUM(MoneySent)+SUM(MoneyReceived) FROM transactions Lin WHERE Lin.AccountNumber = @AccountNumber) as Balance FROM transactions Lout ORDER BY AccountNumber";
            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);

                    txtAccountNumber.Text = Class1.AccountNumber;

                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);

                //Execute command
                cmd.ExecuteNonQuery();

                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    String x = myReader[7].ToString();
   
                    MessageBox.Show("Your Balance is R"+x);

                //close connection
                this.dbConnect.CloseConnection();
            }
         }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw frm1 = new Withdraw();
            frm1.Show();
        }

        private void SendMoney_Click(object sender, EventArgs e)
        {
            SendMoney frm1 = new SendMoney();
            frm1.Show();
        }

        private void DisplayStatement_Click(object sender, EventArgs e)
        {
            Statement frm1 = new Statement();
            frm1.Show();
        }

    }
}
