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
    public partial class Remove_Obsolate_Invetory : Form
    {
        public Remove_Obsolate_Invetory()
        {
            InitializeComponent();
        }
        SqlConnection con10 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd10 = new SqlCommand();
        SqlDataAdapter da10= new SqlDataAdapter();
        private void btnremove_Click(object sender, EventArgs e)
        {
            int id3;
            id3 = Convert.ToInt32(dgvrunninginventory.SelectedCells[0].Value.ToString());
            SqlCommand cmd10 = con10.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "delete from Approved_Inventory where id=" + id3 + "";
            con10.Open();
            cmd10.ExecuteNonQuery();
            con10.Close();
            DialogResult result = MessageBox.Show("Submited To Supervisor ", "Submit",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }
        public void display_details()
        {
            SqlCommand cmd10 = con10.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "select * from Approved_Inventory";
            con10.Open();
            cmd10.ExecuteNonQuery();
            con10.Close();
            DataTable dt10 = new DataTable();
            SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
            da10.Fill(dt10);
            dgvrunninginventory.DataSource = dt10;
        }
        private void Remove_Obsolate_Invetory_Load(object sender, EventArgs e)
        {
            SqlCommand cmd10 = con10.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "select * from Approved_Inventory";
            con10.Open();
            cmd10.ExecuteNonQuery();
            con10.Close();
            DataTable dt10 = new DataTable();

            SqlDataAdapter da10 = new SqlDataAdapter(cmd10);
            da10.Fill(dt10);
            dgvrunninginventory.DataSource = dt10;
            
        }

        private void dgvrunninginventory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtitemcode.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtitemname.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            txtunitcategory.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtquantity.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            txtunitprice.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtobsprice.Text = dgvrunninginventory.Rows[e.RowIndex].Cells[8].Value.ToString();
            
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

        private void btninsert_Click(object sender, EventArgs e)
        {
            
           string sql6 = "insert into Approve_Obsolate_Inventories values('" + dtpremovedate.Text + "','" + txtitemcode.Text + "','" + txtitemname.Text + "'," +
                "'" + txtunitprice.Text + "','" + txtunitcategory.Text + "','" + txtquantity.Text + "','" + txtobsprice.Text + "')";
            cmd10 = new SqlCommand(sql6, con10);
            con10.Open();
            cmd10.ExecuteNonQuery();
            con10.Close();
            DialogResult result = MessageBox.Show("Successfully Insert", "Insert Details",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            display_details();
            txtitemcode.Clear();
            txtitemname.Clear();
            txtquantity.Clear();
            txtunitcategory.Clear();
            txtunitprice.Clear();
            txtobsprice.Clear();

        }
    }
}
