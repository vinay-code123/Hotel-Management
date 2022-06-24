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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            uc_Employee1.Visible = false;
            uc_addroom1.Visible = false;
            uc_CustomerRegistration1.Visible = false;
            btnaddroom.PerformClick();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btn(object sender, EventArgs e)
        {

        }

        
        private void btncustomerregis_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btncustomerregis.Left+25;
            uc_CustomerRegistration1.Visible = true;
            uc_CustomerRegistration1.BringToFront();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btnaddroom.Left + 18;
            uc_addroom1.Visible = true;
            uc_addroom1.BringToFront();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            movingpanel.Left = btncheckout.Left + 18;
            uc_CustomerCheckOut1.Visible = true;
            uc_CustomerCheckOut1.BringToFront();
        }

        private void btncustomerdetails_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            movingpanel.Left = btncustomerdetails.Left + 18;
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            uc_Employee1.Visible = true;
            uc_Employee1.BringToFront();
            movingpanel.Left = btnemployee.Left + 18;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uc_addroom1_Load(object sender, EventArgs e)
        {

        }

        private void uc_addroom1_Load_1(object sender, EventArgs e)
        {

        }

        private void uc_addroom1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_addroom1_Load_3(object sender, EventArgs e)
        {

        }

        private void uc_CustomerRegistration1_Load(object sender, EventArgs e)
        {

        }

        private void uc_CustomerRegistration1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
