using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void RegisterCustomer_Click(object sender, EventArgs e)
        {
            CustomerRegistration frm = new CustomerRegistration();
            frm.Show();
        }

        private void ActiveCustomers_Click(object sender, EventArgs e)
        {
            ActiveUsers frm = new ActiveUsers();
            frm.Show();
        }
    }
}
