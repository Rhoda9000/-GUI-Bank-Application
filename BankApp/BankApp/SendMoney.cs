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
    public partial class SendMoney : Form
    {
        private DBconnect dbConnect;
        public SendMoney()
        {
            InitializeComponent();
            txtAccountNumber1.Visible = false;

        }

        private void Send_Money_Click(object sender, EventArgs e)
        {
            SendMoneyToAnotherAccount();
        }

        public void SendMoneyToAnotherAccount()
        {
            dbConnect = new DBconnect();

            string query = "INSERT INTO transactions (AccountNumber,Deposit , Withdraw, MoneySent, MoneyReceived) VALUES (@AccountNumber, 0, 0 , @SendMoney, 0)";
            string query1 = "INSERT INTO transactions (AccountNumber,Deposit , Withdraw, MoneySent, MoneyReceived) VALUES (@AccountNumber1, 0, 0 , 0, @ReceiveMoney)";
            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                if (string.IsNullOrWhiteSpace(txtSendMoney.Text) || string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("feilds empty");
                }
                else
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
                    MySqlCommand cmd1 = new MySqlCommand(query1, dbConnect.connection);

                    txtAccountNumber1.Text = Class1.AccountNumber;

                    cmd.Parameters.AddWithValue("@SendMoney", "-" + txtSendMoney.Text);
                    cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber1.Text);

                    
                    cmd1.Parameters.AddWithValue("@ReceiveMoney",   txtSendMoney.Text);
                    cmd1.Parameters.AddWithValue("@AccountNumber1", txtAccountNumber.Text);


                    //Execute command
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Money Sent!!");

                    //close connection
                    this.dbConnect.CloseConnection();
                }
            }
        }
    }
}
