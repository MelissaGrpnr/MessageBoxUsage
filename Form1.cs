using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = addCustomer(new Customer()
            {
                id = Guid.NewGuid(),
                name = txtName.Text,
                surname = txtSurname.Text,
                emailAddress =txtMail.Text,
                phoneNumber = txtPhone.Text
            });

            if (result > 0)
            {
                MessageBox.Show("Customer adding operation is succesful");

                DialogResult res=  MessageBox.Show("Would you add new customer registeration",
                    "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    infoBar = new NotifyIcon();
                    infoBar.BalloonTipText = "Total registeration number: " + VirtualDatabase.customers.Count();
                    infoBar.BalloonTipTitle = "Number of customer";
                    infoBar.Visible = true;
                    infoBar.Icon = SystemIcons.Information;
                    infoBar.ShowBalloonTip(2000);
                }

                else if (res == DialogResult.No)
                {

                }

                clearScreen();
                listScreen();

            }
            else {
                MessageBox.Show("Adding operation is not successful.");
            }
        }

        private void listScreen()
        {
            lstCustomers.DataSource = VirtualDatabase.customers;
        }

        private void clearScreen() {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private int addCustomer(Customer info) {
            VirtualDatabase.customers.Add(info);
            return 1;
        }
    }
}
