using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankApp
{
    class DBconnect
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public DBconnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "bank";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {              
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;

                    case 2:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Create()
        {
            string query = ("CREATE TABLE IF NOT EXISTS userinfo(id int NOT NULL AUTO_INCREMENT, Name varchar(255), Surname varchar(255), DOB varchar(255), IDNumber double, Address varchar(255), Town varchar(255), City varchar(255), CellNumber varchar(255), AccountNumber bigint, Pin int, PRIMARY KEY(id))");
            string query1 = ("CREATE TABLE IF NOT EXISTS transactions(id int NOT NULL AUTO_INCREMENT, AccountNumber double,  Deposit double, Withdraw double, MoneySent double, MoneyReceived double, DateOfTransaction timestamp,PRIMARY KEY(id))");
            string query2 = ("CREATE TABLE IF NOT EXISTS employee(id int NOT NULL AUTO_INCREMENT, Name varchar(255), Surname varchar(255), Username varchar(255), Password varchar(255), PRIMARY KEY(id))");

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }
  
    }
}
