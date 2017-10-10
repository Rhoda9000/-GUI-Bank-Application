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
    public partial class AdminLogin : Form
    {
        private DBconnect dbConnect;

        public AdminLogin()
        {
            InitializeComponent();
            dbConnect = new DBconnect();
            dbConnect.Create();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            AdminForm frm1 = new AdminForm();
            login();

            bool r = login();
            if (r)
                frm1.Show();
            else
                MessageBox.Show("Incorrect Login Credentials");

        }

        private bool login()
        {
            string query = "Select * from employee where Username=@Username and Password=@Password";

            if (this.dbConnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

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

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegistration frm = new AdminRegistration();
            frm.Show();
        }
    }
}
