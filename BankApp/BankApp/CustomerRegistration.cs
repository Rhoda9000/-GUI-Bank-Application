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
    public partial class CustomerRegistration : Form
    {
        private DBconnect dbConnect;
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {

            RegisterCustomer();

        }

        public void RegisterCustomer()
        {
            dbConnect = new DBconnect();

            string GenerateAccountNumber = String.Format("{0:d16}", (DateTime.Now.Ticks) % 7000000000000);
            
            string query = "INSERT INTO userinfo (Name, Surname, DOB, IDNumber, Address, Town, City, CellNumber, AccountNumber , Pin) VALUES (@Name, @Surname, @DOB, @IDNumber, @Address, @Town, @City, @CellNumber, @AccountNumber , @Pin)";

            //open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtDOB.Text) || string.IsNullOrWhiteSpace(txtIDNum.Text) || string.IsNullOrWhiteSpace(txtTown.Text) || string.IsNullOrWhiteSpace(txtCity.Text) || string.IsNullOrWhiteSpace(txtCellNum.Text) || string.IsNullOrWhiteSpace(txtPin.Text) || string.IsNullOrWhiteSpace(txtReTypePin.Text))
                {
                    MessageBox.Show("Fill in all fields");
                }
                else
                {

                    if (txtPin.Text == txtReTypePin.Text)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);

                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                        cmd.Parameters.AddWithValue("@IDNumber", txtIDNum.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Town", txtTown.Text);
                        cmd.Parameters.AddWithValue("@City", txtCity.Text);
                        cmd.Parameters.AddWithValue("@CellNumber", txtCellNum.Text);
                        cmd.Parameters.AddWithValue("@AccountNumber", GenerateAccountNumber);
                        cmd.Parameters.AddWithValue("@Pin", txtPin.Text);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer Created!!");

                        //close connection
                        this.dbConnect.CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Pins do not match");
                    }
                }
             }
          }
      }
   }
