using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newHotelManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username= '" + txtUserName.Text + "' and pass = '" + txtpassword.Text + "'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count!=0)
            {
                labelerror.Visible = false;
                DashBoard dash = new DashBoard();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelerror.Visible = true;
                txtpassword.Clear();
            }
        }
    }
}
