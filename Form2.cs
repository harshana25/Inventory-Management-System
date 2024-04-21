using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Order_Approve : Form
    {
        public Order_Approve()
        {
            InitializeComponent();
        }
       
       SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd3 = new SqlCommand();
        SqlDataAdapter da3 = new SqlDataAdapter();


        private void Order_Approve_Load(object sender, EventArgs e)

        {
            try
            {
                SqlCommand cmd3 = con3.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from Ordering_Inventory";
                con3.Open();
                cmd3.ExecuteNonQuery();

                DataTable dt3 = new DataTable();

                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                dgvdisplayorders.DataSource = dt3;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                con3.Close();
            }

        }

        private void dgvdisplayorders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtitemcode.Text = dgvdisplayorders.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtitemname.Text = dgvdisplayorders.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtlocation.Text= dgvdisplayorders.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtunitprice.Text= dgvdisplayorders.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtquantity.Text= dgvdisplayorders.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtdelimethod.Text= dgvdisplayorders.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtunitprice.Text = dgvdisplayorders.Rows[e.RowIndex].Cells[7].Value.ToString();
               txttotalprice.Text = dgvdisplayorders.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtdateoforder.Text= dgvdisplayorders.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void display_approved_details()
        {

            try
            {
                SqlCommand cmd3 = con3.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select * from Ordering_Inventory";
                con3.Open();
                cmd3.ExecuteNonQuery();

                DataTable dt3 = new DataTable();

                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);
                dgvdisplayorders.DataSource = dt3;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con3.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnnewtot_Click(object sender, EventArgs e)
        {
            int y= int.Parse(txtunitprice.Text) * int.Parse(txtquantity.Text);
           txttotalprice.Text = y.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "UPDATE Ordering_Inventory SET itemcode='" + txtitemcode.Text + "',itemname='" + txtitemname.Text + "',location='" + txtlocation.Text + "',quantity='" + txtquantity.Text + "'," +
                    "deliverymethod='" + txtdelimethod.Text + "',unitprice='" + txtunitprice.Text + "',totalprice='" + txttotalprice.Text + "' WHERE itemcode='" + txtitemcode.Text + "'";


                cmd3 = new SqlCommand(sql3, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();
                con3.Close();
                DialogResult result = MessageBox.Show(" Successfully Updated", "Detail Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_approved_details();
                clear_details();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Successfully Approved", "Approval",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_details();
            
      
         
        }
        public void clear_details()
        {

            
            txtitemcode.Clear();
            txtitemname.Clear();
            txtlocation.Clear();
            txtquantity.Clear();
            txtdateoforder.Clear();
            txtdelimethod.Clear();
            txtunitprice.Clear();
            txttotalprice.Clear();
        }
        private void btndisapprove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit", "Exit",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                this.Hide();
            }
        }
    }
}
