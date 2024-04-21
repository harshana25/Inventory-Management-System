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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {


        }
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (con1.State == ConnectionState.Open)
            {
                con1.Close();
            }
            con1.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Do you want to Exit", "Sign Out",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                
                this.Hide();
            }
            
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            
            //    string sql2 = "select * from admin_supervisor where type='" + cmbcategory.SelectedItem + "'";
            //    SqlCommand cmd = new SqlCommand(sql2, con1);
            //    con1.Open();
            //    SqlDataReader r = cmd.ExecuteReader();
                 
            //if (r.Read())
            //    {

            //       cmbcategory.Text = r["type"].ToString();
                   

            //    }
            //    else
            //    {
            //        DialogResult result = MessageBox.Show("This action is restricted for you", "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            //    }
       

            try
            {

                if (cmbcategory.Text == "Administrator")
                {
                    int b = 0;
                    SqlCommand cmd2 = con1.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from admin_supervisor where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'and type='" + cmbcategory.Text + "'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt);
                    b = Convert.ToInt32(dt.Rows.Count.ToString());



                    if (b == 0)
                    {
                        DialogResult result = MessageBox.Show("Please Enter Correcrt Username or Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    

                    else
                    {
                        DialogResult result = MessageBox.Show("You are Logging as an Admin", "Loging Confirmation",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inventory_Management_System ims = new Inventory_Management_System();
                        ims.Show();
                        this.Hide();

                    }
                    
                }

                else if (cmbcategory.Text == "Supervisor")
                {
                    int c = 0;
                    SqlCommand cmd2 = con1.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from admin_supervisor where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'and type='" + cmbcategory.Text + "'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt);
                    c = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (c == 0)
                    {
                        DialogResult result = MessageBox.Show("Please Enter Correct Username or Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("You are Logging as a Supervisor", "Loging Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inventory_Management_System ims = new Inventory_Management_System();
                        ims.Show();
                        this.Hide();
                    }
                    

                }

                 else if (cmbcategory.Text == "SPD_Admin")
                {
                    int d = 0;
                    SqlCommand cmd2 = con1.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from admin_supervisor where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'and type='" + cmbcategory.Text + "'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt);
                    d = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (d == 0)
                    {
                        DialogResult result = MessageBox.Show("Please Enter Correct  Username or Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        
                    }

                    else
                    {
                        DialogResult result = MessageBox.Show("You are Logging as a Spd_Admin", "Loging Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Inventory_Management_System ims = new Inventory_Management_System();
                        ims.Show();
                        this.Hide();
                    }
                               

                }
                else if(txtuname.Text==""|| txtpword.Text == "")
                {
                    DialogResult result = MessageBox.Show("Please Enter Your Username or Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbcategory.Text=="")
                {
                    DialogResult result = MessageBox.Show("Please Select Your User Type", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               else if(cmbcategory.Text=="User")
                {
                    int a = 0;
                    SqlCommand cmd2 = con1.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from  Registration where username='" + txtuname.Text + "' and password='" + txtpword.Text + "'";
                    cmd2.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adap = new SqlDataAdapter(cmd2);
                    adap.Fill(dt1);
                    a = Convert.ToInt32(dt1.Rows.Count.ToString());
                    if (a == 0)
                    {
                        DialogResult result = MessageBox.Show("Please Provide Correct User Name and the Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                      

                    }
                    else
                    {
                        Inventory_Management_System ims = new Inventory_Management_System();
                        ims.Show();
                        this.Hide();
                    }
                }
                //else
                //{
                //    DialogResult result = MessageBox.Show("This action is restricted for you", "Error",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
    }

}
