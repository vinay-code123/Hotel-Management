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
    public partial class uc_addroom : UserControl
    {
        function fn = new function();
        String query;
        public uc_addroom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uc_addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds= fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtType.Text!= "" && txtRoomNo.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo,roomType,bed,price) values ('"+roomno+"','"+type+"', '"+bed+"','"+price+"')";
                fn.setData(query, "Room Added.");

                uc_addroom_Load(this, null);
                clearAll(); 
            }
            else
            {
                MessageBox.Show("fill all fields.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void uc_addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void uc_addroom_Enter(object sender, EventArgs e)
        {
            uc_addroom_Load(this, null);
        }
    }
}
