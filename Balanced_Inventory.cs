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
    public partial class Balanced_Inventory : Form
    {
        public Balanced_Inventory()
        {
            InitializeComponent();
        }
        SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd5 = new SqlCommand();
        SqlDataAdapter da5 = new SqlDataAdapter();
        public void dispaly_balanced_inventory()
        {

            SqlCommand cmd5 = con5.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from Running_Inventory";
            con5.Open();
            cmd5.ExecuteNonQuery();
            con5.Close();
            DataTable dt5 = new DataTable();

            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
           dgvrunninginventry.DataSource = dt5;

        }
        public void display_remove()
        {
            SqlCommand cmd5 = con5.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from Approved_Inventory";
            con5.Open();
            cmd5.ExecuteNonQuery();
            con5.Close();
            DataTable dt5 = new DataTable();

            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            dgvbalancedinventory.DataSource = dt5;
        }
        private void Balanced_Inventory_Load(object sender, EventArgs e)
        {
            SqlCommand cmd5 = con5.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from Approved_Inventory";
            con5.Open();
            cmd5.ExecuteNonQuery();
            con5.Close();
            DataTable dt5 = new DataTable();

            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            dgvbalancedinventory.DataSource = dt5;
            dispaly_balanced_inventory();
        }

        private void dgvbalancedinventory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtitemcode.Text = dgvbalancedinventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtitemname.Text = dgvbalancedinventory.Rows[e.RowIndex].Cells[2].Value.ToString();
           txtunitcategory.Text = dgvbalancedinventory.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtquantity.Text = dgvbalancedinventory.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtunitprice.Text = dgvbalancedinventory.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnbaltotal_Click(object sender, EventArgs e)
        {
            int tot = int.Parse(txtunitprice.Text) * int.Parse(txtquantity.Text);
            txtbalinventot.Text = tot.ToString();

        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            string sql5 = "insert into  Running_Inventory values('" + dtpselectdate.Text + "','" + txtitemcode.Text + "','" + txtitemname.Text + "','" + txtunitcategory.Text + "','" + txtunitprice.Text + "'," +
                   "'" + txtquantity.Text + "','" + txtbalinventot.Text + "' )";


            cmd5 = new SqlCommand(sql5, con5);
            con5.Open();
            cmd5.ExecuteNonQuery();
            con5.Close();
            DialogResult result = MessageBox.Show(" Successfully Balnced", " Balance Confirmation",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            string sql6 = "delete from Approved_Inventory where itemcode='" + txtitemcode.Text + "'";
            cmd5 = new SqlCommand(sql6, con5);
            con5.Open();
            cmd5.ExecuteNonQuery();
            con5.Close();

            display_remove();
            dispaly_balanced_inventory();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            //int id2;
            //id2 = Convert.ToInt32(dgvbalancedinventory.SelectedCells[0].Value.ToString());
            //SqlCommand cmd5 = con5.CreateCommand();
            //cmd5.CommandType = CommandType.Text;
            //cmd5.CommandText = "delete from Approved_Inventory where id=" + id2 + "";
            //con5.Open();
            //cmd5.ExecuteNonQuery();
            //con5.Close();
            //DialogResult result = MessageBox.Show("You have Successfully Deleted ", "User Deletion",
            //       MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
