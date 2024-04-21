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
    public partial class Product_Management : Form
    {
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd2 = new SqlCommand();
        SqlDataAdapter da2 = new SqlDataAdapter();
        public Product_Management()
        {
            InitializeComponent();
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand cmd2 = con2.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from Ordering_Inventory";
                con2.Open();
                cmd2.ExecuteNonQuery();

                DataTable dt3 = new DataTable();

                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt3);
               dgvdisplaydetail.DataSource = dt3;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                con2.Close();
            }

           
        }
        public void displaydetail()
        {

            SqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from Ordering_Inventory";
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd2);
            da3.Fill(dt3);
            dgvdisplaydetail.DataSource = dt3;
            
        }
        public void cleardetails()
        {

            txtitemcode.Clear();
            txtitemname.Clear();
            txtlocation.Clear();
            txtquantity.Clear();
            cmbdelimethod.Text = "";
            cmbunitcategory.Text = "";
            
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd2 = con2.CreateCommand();
            //cmd2.CommandType = CommandType.Text;
            //cmd2.CommandText = "insert into Ordering_Inventory values('" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtlocation.Text + "'," +
            //    "'" + cmbunitcategory.Text + "','" + txtquantity.Text + "','" + cmbdelimethod.Text + "','"+txtunitprice.Text+"','"+txttotprice.Text+"','"+dtpdate.Text+"')";
            //con2.Open();
            //cmd2.ExecuteNonQuery();
            //con2.Close();
            //DialogResult result = MessageBox.Show("Your Order Submitted for Approval" , "Confrimation of Submission",
            //       MessageBoxButtons.OK, MessageBoxIcon.Information);
            //displaydetail();
            //cleardetails();
            //cmbsearch.Text = "";
            //txttotprice.Clear();
            //txtunitprice.Clear();
        }

        private void dgvdisplaydetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtitemcode.Text =dgvdisplaydetail.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtitemname.Text = dgvdisplaydetail.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtlocation.Text = dgvdisplaydetail.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbunitcategory.Text = dgvdisplaydetail.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtquantity.Text = dgvdisplaydetail.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbdelimethod.Text = dgvdisplaydetail.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtunitprice.Text= dgvdisplaydetail.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttotprice.Text= dgvdisplaydetail.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "UPDATE Ordering_Inventory SET itemcode='" + txtitemcode.Text + "',itemname='" + txtitemname.Text + "',location='" + txtlocation.Text + "',unitcategory=" +
                    "'" + cmbunitcategory.Text + "',quantity='" + txtquantity.Text + "',deliverymethod='" + cmbdelimethod.Text + "' WHERE itemcode='" + txtitemcode.Text + "'";
                cmd2 = new SqlCommand(sql2, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                DialogResult result = MessageBox.Show(" Successfully Updated", "Detail Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                displaydetail();
                cleardetails();
                cmbsearch.Text = "";
                txttotprice.Clear();
                txtunitprice.Clear();
            }
            catch (Exception ex3)
            {

                MessageBox.Show(ex3.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id1;
            id1 = Convert.ToInt32(dgvdisplaydetail.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Ordering_Inventory where id=" + id1 + "";
            con2.Open();
            cmd.ExecuteNonQuery();
            con2.Close();
            DialogResult result = MessageBox.Show("You have Successfully Deleted ", "User Deletion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            displaydetail();
            cleardetails();
            cmbsearch.Text = "";
            txttotprice.Clear();
            txtunitprice.Clear();
        }

        private void dgvdisplaydetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbsearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "select * from Inventory_List where itemdescription='" + cmbsearch.SelectedItem + "'";
                cmd2 = new SqlCommand(sql2, con2);
                con2.Open();
                SqlDataReader r = cmd2.ExecuteReader();
                if (r.Read())
                {

                    txtitemcode.Text = r["itemno"].ToString();
                    txtitemname.Text = r["itemdescription"].ToString();
                    txtunitprice.Text = r["unitprice"].ToString();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Please Select an Item ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex4)
            {

                MessageBox.Show(ex4.Message);
            }

            finally
            {
                con2.Close();
            }
        }

        private void btntot_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtunitprice.Text) * int.Parse(txtquantity.Text);
            txttotprice.Text = x.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit", "Sign Out",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                this.Hide();
            }
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into Ordering_Inventory values('" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtlocation.Text + "'," +
                "'" + cmbunitcategory.Text + "','" + txtquantity.Text + "','" + cmbdelimethod.Text + "','" + txtunitprice.Text + "','" + txttotprice.Text + "','" + dtpdate.Text + "')";
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            DialogResult result = MessageBox.Show("Your Order Submitted for Approval", "Confrimation of Submission",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            displaydetail();
            cleardetails();
            cmbsearch.Text = "";
            txttotprice.Clear();
            txtunitprice.Clear();
        }
    }
}
