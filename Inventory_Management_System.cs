using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inventory_Management_System : Form
    {
        private int childFormNumber = 0;

        public Inventory_Management_System()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to Exit", "Exit",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                this.Hide();
            }
           // this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addAndEditUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management um = new User_Management();
            um.Show();


        }

        private void inventoryOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Management pm = new Product_Management();
            pm.Show();
        }

        private void inventoryBalncingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanced_Inventory bi = new Balanced_Inventory();
            bi.Show();
        }

        private void supervisorApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Approve oa = new Order_Approve();
            oa.Show();
        }

        private void sPDApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SVS_Approval sa = new SVS_Approval();
            sa.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            this.Hide();
            lf.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Report pr = new Purchase_Report();
            pr.Show();
        }

        private void balncedInventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanced_Inventory_Report br = new Balanced_Inventory_Report();
            br.Show();
        }

        private void removeObsolateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Obsolate_Invetory ro = new Remove_Obsolate_Invetory();
            ro.Show();
        }

        private void viewAvailableInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Availble_Inventory ai = new Availble_Inventory();
            ai.Show();
        }

        private void viewObsolateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Obsolate_Inventory vo = new View_Obsolate_Inventory();
            vo.Show();
        }

        private void approveObsolateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Approve_Obsolate_Inventory ao = new Approve_Obsolate_Inventory();
            ao.Show();
        }
    }
}
