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
using VallenteStudent.myclass;

namespace VallenteStudent
{
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Front_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="Albert" && textpassword.Text=="Pogi123")
            {
                new Result().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or Password you entered is incorrect. Please try again!");
                txtUserName.Clear();
                textpassword.Clear();
                txtUserName.Focus();
            }
        }
    }
}
