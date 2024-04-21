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
    public partial class Balanced_Inventory_Report : Form
    {
        public Balanced_Inventory_Report()
        {
            InitializeComponent();
        }
        SqlConnection con8 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd8 = new SqlCommand();
        SqlDataAdapter da8 = new SqlDataAdapter();
        string query1 = "";
        private void btnviewbalinven_Click(object sender, EventArgs e)
        {
            string startdate;
            string enddate;
            startdate = dtpstartdate.Value.ToString("dd/MMM/yyy");
            enddate = dtpenddate.Value.ToString("dd/MMM/yyy");
            SqlCommand cmd8 = con8.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = "select * from Running_Inventory where BalancedDate>='" + startdate.ToString() + "' AND BalancedDate<='" + enddate.ToString() + "'";
            con8.Open();
            cmd8.ExecuteNonQuery();
            con8.Close();
            DataTable dt8 = new DataTable();

            SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
            da8.Fill(dt8);
            dgvbalancedinventory.DataSource = dt8;
            query1 = "select * from Running_Inventory where BalancedDate>='" + startdate.ToString() + "' AND BalancedDate<='" + enddate.ToString() + "'";
        }

        private void btnprintreport_Click(object sender, EventArgs e)
        {
            Generate_Balanced_Inventory_Report gbi = new Generate_Balanced_Inventory_Report();
            gbi.get_va1ue1(query1.ToString());
            gbi.Show();
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
