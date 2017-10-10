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
    public partial class Statement : Form
    {
        private DBconnect dbConnect;
        public Statement()
        {
            InitializeComponent();
            txtAccountNumber.Visible = false;
        }

        private void GenerateStatement_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = select();

            dgDisplay.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                dgDisplay.Rows[number].Cells[2].Value = list[2][i];
                dgDisplay.Rows[number].Cells[3].Value = list[3][i];
                dgDisplay.Rows[number].Cells[4].Value = list[4][i];                
            }
        }

        public List<string>[] select()
        {
            dbConnect = new DBconnect();

            string query = "SELECT * FROM transactions WHERE AccountNumber = @AccountNumber";

            txtAccountNumber.Text = Class1.AccountNumber;

            //Create a list to store the result
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            

            //Open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
                cmd.Parameters.AddWithValue("@AccountNumber", txtAccountNumber.Text);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {                  
                    list[0].Add(dataReader["Deposit"] + "");
                    list[1].Add(dataReader["Withdraw"] + "");
                    list[2].Add(dataReader["MoneySent"] + "");
                    list[3].Add(dataReader["MoneyReceived"] + "");
                    list[4].Add(dataReader["DateOfTransaction"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.dbConnect.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

    }
}
