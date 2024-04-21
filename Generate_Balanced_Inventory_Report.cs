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
    public partial class Generate_Balanced_Inventory_Report : Form
    {
        public Generate_Balanced_Inventory_Report()
        {
            InitializeComponent();
        }
        string k;
        SqlConnection con9 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        
        public void get_va1ue1(string a)
        {
            k = a;
        }
        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            
            DataSet2 ds1 = new DataSet2();
            SqlCommand cmd9 = con9.CreateCommand();
            cmd9.CommandType = CommandType.Text;
            cmd9.CommandText = k;
            con9.Open();
            cmd9.ExecuteNonQuery();
            con9.Close();
            SqlDataAdapter da9 = new SqlDataAdapter(cmd9);
            da9.Fill(ds1.DataTable1);
            CrystalReport2 myreport = new CrystalReport2();
            myreport.SetDataSource(ds1);
            crystalReportViewer2.ReportSource = myreport;
        }
    }
}
