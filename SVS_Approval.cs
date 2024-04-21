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
    public partial class SVS_Approval : Form
    {
        public SVS_Approval()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd4 = new SqlCommand();
        SqlDataAdapter da4 = new SqlDataAdapter();
        private void SVS_Approval_Load(object sender, EventArgs e)
        {
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select * from Ordering_Inventory";
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            DataTable dt4 = new DataTable();

            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt4);
            dgvsvsapproval.DataSource = dt4;
        }
        public void svs_approved_dispaly()
        {
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select * from Ordering_Inventory";
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            DataTable dt4 = new DataTable();

            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            da4.Fill(dt4);
            dgvsvsapproval.DataSource = dt4;

        }
        public void approved_detail()
        {
            

        }
        private void btnamend_Click(object sender, EventArgs e)
        {
            string sql4 = "UPDATE  Ordering_Inventory SET itemcode='" + txtitemcode.Text + "',itemname='" + txtitemname.Text + "',location='" + txtlocation.Text + "',unitcategory='"+txtunitcategory.Text+"',quantity='" + txtquantity.Text + "'," +
                    "deliverymethod='" + txtdelimethod.Text + "',unitprice='" + txtunitprice.Text + "',totalprice='" + txttotalprice.Text + "',dateoforder='"+txtdateoforderd.Text+"'WHERE itemcode='" + txtitemcode.Text + "'";


            cmd4 = new SqlCommand(sql4, con4);
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            DialogResult result = MessageBox.Show(" Successfully Updated", " Update",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            //string sql9 = "UPDATE Purchased_Inventory SET Date_of_Order='" + txtdateoforderd.Text + "',Item_Code='" + txtitemcode.Text + "'," +
            //    "Item_Name='" + txtitemname.Text + "',Location='" + txtlocation.Text + "',Quantity='" + txtquantity.Text + "',Unit_Category='" + txtunitcategory.Text + "',Delivery_Method='" + txtdelimethod.Text + "',Unit_Price='" + txtunitprice.Text + "'," +
            //    "Total_Price='" + txttotalprice.Text + "' WHERE Item_Code='" + txtitemcode.Text + "'";
            //cmd4 = new SqlCommand(sql9, con4);
            //con4.Open();
            //cmd4.ExecuteNonQuery();
            //con4.Close();
            svs_approved_dispaly();
            clearfields();
        }

        private void dgvsvsapproval_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtitemcode.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtitemname.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtlocation.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[3].Value.ToString();
           txtunitcategory.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtquantity.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtdelimethod.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtunitprice.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttotalprice.Text = dgvsvsapproval.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtdateoforderd.Text= dgvsvsapproval.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnrefreshtotal_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtunitprice.Text) * int.Parse(txtquantity.Text);
            txttotalprice.Text = x.ToString();
        }
        public void clearfields()
        {

            txtdateoforderd.Clear();
            txtitemcode.Clear();
            txtitemname.Clear();
            txtlocation.Clear();
            txtquantity.Clear();
            txtunitcategory.Clear();
            txtdelimethod.Clear();
            txtunitprice.Clear();
            txttotalprice.Clear();

        }
        private void btnapprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Successfully Approved", "Approval",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText="insert into Approved_Inventory values('"+txtitemcode.Text+"','"+txtitemname.Text+ "','" + txtlocation.Text + "','" +txtunitcategory.Text + "','" + txtquantity.Text + "','" + txtdelimethod.Text + "','" + txtunitprice.Text + "','" + txttotalprice.Text + "','"+txtdateoforderd.Text+"')";
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            string sql3 = "delete from Ordering_Inventory where itemcode='" + txtitemcode.Text + "'";
            cmd4 = new SqlCommand(sql3, con4);
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            string sql5 = "insert into Purchased_Inventory values('" + txtdateoforderd.Text + "','" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtlocation.Text + "','" + txtquantity.Text + "','" + txtunitcategory.Text + "','" + txtdelimethod.Text + "','" + txtunitprice.Text + "','" + txttotalprice.Text + "')";
            cmd4 = new SqlCommand(sql5, con4);
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();

            clearfields();

          
        
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int id2;
            id2 = Convert.ToInt32(dgvsvsapproval.SelectedCells[1].Value.ToString());
            SqlCommand cmd4 = con4.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "delete from Ordering_Inventory where itemcode=" + id2 + "";
            con4.Open();
            cmd4.ExecuteNonQuery();
            con4.Close();
            DialogResult result = MessageBox.Show("You have Successfully Deleted ", " Deletion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            svs_approved_dispaly();
            clearfields();
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
