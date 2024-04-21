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
    public partial class Purchase_Report : Form
    {
        public Purchase_Report()
        {
            InitializeComponent();
        }
        SqlConnection con6 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd6 = new SqlCommand();
        SqlDataAdapter da6 = new SqlDataAdapter();
        string query = "";
        private void btnviewpurchases_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = con6.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select * from Purchased_Inventory";
            con6.Open();
            cmd6.ExecuteNonQuery();
            con6.Close();
            DataTable dt6 = new DataTable();

            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);
            dgvviewpurchses.DataSource = dt6;
            query = "select * from Purchased_Inventory";
        }

        private void Purchase_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string startdate;
            string enddate;
            startdate = dtpstartdate.Value.ToString("dd/MMM/yyy");
            enddate = dtpenddate.Value.ToString("dd/MMM/yyy");
            SqlCommand cmd6 = con6.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select * from Purchased_Inventory where Date_of_Order>='"+startdate.ToString()+ "' AND Date_of_Order<='" + enddate.ToString()+"'";
            con6.Open();
            cmd6.ExecuteNonQuery();
            con6.Close();
            DataTable dt6 = new DataTable();

            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);
            dgvviewpurchses.DataSource = dt6;
            query = "select * from Purchased_Inventory where Date_of_Order>='" + startdate.ToString() + "' AND Date_of_Order<='" + enddate.ToString() + "'";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Generate_Purchase_Report gpr = new Generate_Purchase_Report();
            gpr.get_value(query.ToString());
            gpr.Show();
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
