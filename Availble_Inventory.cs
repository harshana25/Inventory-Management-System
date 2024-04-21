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
    public partial class Availble_Inventory : Form
    {
        public Availble_Inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd5 = new SqlCommand();
        SqlDataAdapter da5 = new SqlDataAdapter();
        private void Availble_Inventory_Load(object sender, EventArgs e)
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
            dgvavailableinventory.DataSource = dt5;
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
