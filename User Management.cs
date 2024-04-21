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
    public partial class User_Management : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\BIT 2nd Semester\ICT Projects\Assignment 3\Project\WindowsFormsApp1\Inventorydb.mdf';Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public User_Management()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
       
        private void btnregnow_Click(object sender, EventArgs e)
        {

            
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Registration where username='" + txtnewusername.Text + "' ";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into Registration values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtdeporbranch.Text + "'," +
                        "'" + txtnewusername.Text + "','" + txtnewpassword.Text + "','" + txtemailid.Text + "')";

                    cmd1.ExecuteNonQuery();

                    clear();
                    display();
                
                    DialogResult result = MessageBox.Show("You have Successfully Registerd", "Register Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //else
                //{
                //    DialogResult result = MessageBox.Show("Please Provide relavant details", "Error",
                //                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}  

                }
                else
                {
                    DialogResult result = MessageBox.Show("This user Name has already used, Plese Provide another", "Registration Confrim",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnewusername.Clear();

                }
               
            
           

            
        }
        public void clear() {


            txtfname.Clear();
            txtlname.Clear();
            txtdeporbranch.Clear();
            txtnewusername.Clear();
            txtnewpassword.Clear();
            txtemailid.Clear();
        }
        public void display() 
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvdisplay.DataSource = dt;

        }
        private void User_Management_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dgvdisplay.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Registration where id="+id+"";
            cmd.ExecuteNonQuery();
            DialogResult result = MessageBox.Show("You have Successfully Deleted the user", "User Deletion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            display();
            clear();
        }

        private void btngotologin_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Do You Want to go back", "Previous",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Login_Form lform = new Login_Form();
            //lform.Show();
            //this.Hide();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id2;
                id2 = Convert.ToInt32(dgvdisplay.SelectedCells[0].Value.ToString());
                string sql = "UPDATE Registration SET firstname='" + txtfname.Text + "',lastname='" + txtlname.Text + "',departmentname='" + txtdeporbranch.Text + "',username=" +
                    "'" + txtnewusername.Text + "',password='" + txtnewpassword.Text + "',emailuserid='" + txtemailid.Text + "' WHERE id='"+id2+"'";
                cmd = new SqlCommand(sql, con);
              
                cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show(" Successfully Updated", "Detail Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
                clear();
            }
            catch (Exception ex1)
            {

                MessageBox.Show(ex1.Message);
            }
            
        }

        private void dgvdisplay_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtfname.Text= dgvdisplay.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlname.Text= dgvdisplay.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdeporbranch.Text = dgvdisplay.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnewusername.Text = dgvdisplay.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtnewpassword.Text = dgvdisplay.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtemailid.Text = dgvdisplay.Rows[e.RowIndex].Cells[6].Value.ToString();
           

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to go back", "Previous",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login_Form lform = new Login_Form();
            lform.Show();
            this.Hide();
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

        private void txtfname_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtfname, "");
            if (txtfname.Text == "")
            {
                errorProvider1.SetError(txtfname, "Enter a Value");
            }
        }

        private void txtlname_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtlname, "");
            if (txtlname.Text == "")
            {
                errorProvider1.SetError(txtlname, "Enter a Value");
            }
        }

        private void txtdeporbranch_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtdeporbranch, "");
            if (txtdeporbranch.Text == "")
            {
                errorProvider1.SetError(txtdeporbranch, "Enter a Value");
            }
        }

        private void txtnewusername_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtnewusername, "");
            if (txtnewusername.Text == "")
            {
                errorProvider1.SetError(txtnewusername, "Enter a Value");
            }
        }

        private void txtnewpassword_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtnewpassword, "");
            if (txtnewpassword.Text == "")
            {
                errorProvider1.SetError(txtnewpassword, "Enter a Value");
            }
        }

        private void txtemailid_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtemailid, "");
            if (txtemailid.Text == "")
            {
                errorProvider1.SetError(txtemailid, "Enter a Value");
            }
        }
    }
}