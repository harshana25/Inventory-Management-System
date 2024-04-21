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
    public partial class Approve_Obsolate_Inventory : Form
    {
        public Approve_Obsolate_Inventory()
        {
            InitializeComponent();
        }
        SqlConnection con11 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd11 = new SqlCommand();
        SqlDataAdapter da11 = new SqlDataAdapter();
        private void btnapprove_Click(object sender, EventArgs e)
        {
            string sql7 = "insert into Obsolate_Inventories values('" + txtdateofremove.Text + "','" + txtitemcode.Text + "','" + txtitemname.Text + "'," +
                "'" + txtunitprice.Text + "','" + txtunitcategory.Text + "','" + txtquantity.Text + "','" + txtobsinvenamount.Text + "')";
            cmd11 = new SqlCommand(sql7, con11);
            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            DialogResult result = MessageBox.Show("Successfully Removed", "Transfer as Obsolate Items",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            string sql8 = "delete from Approved_Inventory where itemcode='" + txtitemcode.Text + "'";
            cmd11 = new SqlCommand(sql8, con11);
            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            display_details3();
            display_details4();
            txtdateofremove.Clear();
            txtitemcode.Clear();
            txtitemname.Clear();
            txtunitprice.Clear();
            txtunitcategory.Clear();
            txtquantity.Clear();
            txtobsinvenamount.Clear();
        }
        public void display_details3()
        {
            SqlCommand cmd10 = con11.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "select * from Obsolate_Inventories";
            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            da11.Fill(dt11);
           dgvviewobsolateinven.DataSource = dt11;
        }
        public void display_details4()
        {
            SqlCommand cmd10 = con11.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "select * from Approved_Inventory";
            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            da11.Fill(dt11);
            dgvapproveobsinven.DataSource = dt11;
        }
        private void dgvapproveobsinven_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {txtdateofremove.Text=dgvapproveobsinven.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtitemcode.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtitemname.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtunitprice.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtunitcategory.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtquantity.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[6].Value.ToString();

           
            txtobsinvenamount.Text = dgvapproveobsinven.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Approve_Obsolate_Inventory_Load(object sender, EventArgs e)
        {
            SqlCommand cmd11 = con11.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "select * from Approve_Obsolate_Inventories";
            con11.Open();
            cmd11.ExecuteNonQuery();
            con11.Close();
            DataTable dt11 = new DataTable();

            SqlDataAdapter da11 = new SqlDataAdapter(cmd11);
            da11.Fill(dt11);
            dgvapproveobsinven.DataSource = dt11;
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
