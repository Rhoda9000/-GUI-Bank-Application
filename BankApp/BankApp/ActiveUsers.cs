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
    public partial class ActiveUsers : Form
    {
        private DBconnect dbConnect;
        public ActiveUsers()
        {
            InitializeComponent();
        }

        private void DisplayActiveCustomers_Click(object sender, EventArgs e)
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
                dgDisplay.Rows[number].Cells[5].Value = list[5][i];
                dgDisplay.Rows[number].Cells[6].Value = list[6][i];
                dgDisplay.Rows[number].Cells[7].Value = list[7][i];
                dgDisplay.Rows[number].Cells[8].Value = list[8][i];
            }
        }

        public List<string>[] select()
        {
            dbConnect = new DBconnect();

            string query = "SELECT *FROM userinfo WHERE EXISTS(SELECT * FROM transactions  WHERE  userinfo.AccountNumber = transactions.AccountNumber)";

            //Create a list to store the result in th columns
            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();


            //Open connection
            if (this.dbConnect.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, dbConnect.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Name"] + "");
                    list[1].Add(dataReader["Surname"] + "");
                    list[2].Add(dataReader["DOB"] + "");
                    list[3].Add(dataReader["IDNumber"] + "");
                    list[4].Add(dataReader["Address"] + "");
                    list[5].Add(dataReader["Town"] + "");
                    list[6].Add(dataReader["City"] + "");
                    list[7].Add(dataReader["CellNumber"] + "");
                    list[8].Add(dataReader["AccountNumber"] + "");
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
