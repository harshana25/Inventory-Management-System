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
    public partial class View_Obsolate_Inventory : Form
    {
        public View_Obsolate_Inventory()
        {
            InitializeComponent();
        }
        SqlConnection con12 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        private void View_Obsolate_Inventory_Load(object sender, EventArgs e)
        {
            SqlCommand cmd12 = con12.CreateCommand();
            cmd12.CommandType = CommandType.Text;
            cmd12.CommandText = "select * from Obsolate_Inventories";
            con12.Open();
            cmd12.ExecuteNonQuery();
            con12.Close();
            DataTable dt12 = new DataTable();

            SqlDataAdapter da12 = new SqlDataAdapter(cmd12);
            da12.Fill(dt12);
            dgvviewobsinventory.DataSource = dt12;
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
