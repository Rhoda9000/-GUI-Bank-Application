using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BankApp
{
    public partial class CustomerLogin : Form
    {       
        private DBconnect dbConnect;

        public CustomerLogin()
        {
            InitializeComponent();
            dbConnect = new DBconnect();
            dbConnect.Create();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            CustomerChoice frm1 = new CustomerChoice();
            login();

            bool r = login();
            if (r)
                frm1.Show();
            else
            {
                MessageBox.Show("Incorrect Login Credentials");              
            }
        }
       
        private bool login()
        {
            string query = "Select * from userinfo where AccountNumber=@AccountNumber and Pin=@Pin";

            if (this.dbConnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
    
                cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                Class1.AccountNumber = txtAccountNumber.Text;
                cmd.Parameters.AddWithValue("@Pin", txtPin.Text);

                cmd.ExecuteNonQuery();          

                MySqlDataReader login = cmd.ExecuteReader();

                if (login.Read())
                {
                    dbConnect.CloseConnection();
                    return true;
                }
                else
                {
                    dbConnect.CloseConnection();
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
    }
}
