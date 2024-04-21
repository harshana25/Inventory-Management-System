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
    public partial class Generate_Purchase_Report : Form
    {
        public Generate_Purchase_Report()
        {
            InitializeComponent();
        }
        string j;
        SqlConnection con7 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd7 = new SqlCommand();
        SqlDataAdapter da7 = new SqlDataAdapter();
        public void get_value(string i)
        {
            j = i;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            DataSet1 ds = new DataSet1();
            SqlCommand cmd7 = con7.CreateCommand();
            cmd7.CommandType = CommandType.Text;
            cmd7.CommandText = j;
            con7.Open();
            cmd7.ExecuteNonQuery();
            con7.Close();
            SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
            da7.Fill(ds.DataTable1);
            CrystalReport3 myreport = new CrystalReport3();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
        }
    }
}
