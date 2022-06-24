using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newHotelManagement.All_User_Control
{
    public partial class tabEmployee : UserControl
    {
        function fn = new function();
        String query;
        public tabEmployee()
        {
            InitializeComponent();
        }

        private void uc_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtname.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtname.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;
                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('"+name+"', '"+mobile+"', '"+gender+"', '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData(query, "EmployeeRegistered.");
                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("fill all Fields .", "Warning..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtname.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabemp_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(tabemp.SelectedIndex==2)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView4.DataSource = ds.Tables[0];
            }
             else if(tabemp.SelectedIndex==1)
            {
                query = "select * from employee";
                DataSet ds = fn.getData(query);
                guna2DataGridView5.DataSource = ds.Tables[0];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                if(MessageBox.Show("Are You Sure?","Confirmation....!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    query = "delete from employee where eid =" + txtID.Text + "";
                    fn.setData(query,"Record Deleted.");
                    tabemp_SelectedIndexChanged(this,null);
                }
            }
        }

        private void tabEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
