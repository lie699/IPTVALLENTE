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
    public partial class Result : Form

    {
        Connectionclass con = new Connectionclass();
        public Result()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.connectdb.Open();
                label1.Text = "You are now Connected to the Student DataBase!";
                label1.ForeColor = Color.Green;
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "Failed to Connect to the Student DataBase!";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
