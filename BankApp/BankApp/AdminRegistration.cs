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
    public partial class AdminRegistration : Form
    {
        private DBconnect dbConnect;

        public AdminRegistration()
        {
            InitializeComponent();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            
            InsertEmployee();
        }

        public void InsertEmployee()
        {
            dbConnect = new DBconnect();

            string query = "INSERT INTO employee (Name, Surname, Username, Password) VALUES (@Name, @Surname, @Username, @Password)";

            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtReTypePass.Text))
                {
                    MessageBox.Show("Fill in all fields");
                }
                else
                {

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    if (txtPassword.Text == txtReTypePass.Text)
                    {
                        //Execute command
                        cmd.ExecuteNonQuery();
                     
                        MessageBox.Show("User Added!!");

                        //close connection
                        this.dbConnect.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
            }
        }

    }
}
