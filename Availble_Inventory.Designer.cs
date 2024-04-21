
namespace WindowsFormsApp1
{
    partial class Availble_Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvavailableinventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvavailableinventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvavailableinventory);
            this.panel1.Location = new System.Drawing.Point(128, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 414);
            this.panel1.TabIndex = 0;
            // 
            // dgvavailableinventory
            // 
            this.dgvavailableinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvavailableinventory.Location = new System.Drawing.Point(0, 0);
            this.dgvavailableinventory.Name = "dgvavailableinventory";
            this.dgvavailableinventory.RowHeadersWidth = 51;
            this.dgvavailableinventory.RowTemplate.Height = 24;
            this.dgvavailableinventory.Size = new System.Drawing.Size(1080, 411);
            this.dgvavailableinventory.TabIndex = 0;
            this.dgvavailableinventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Inventory";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(525, 624);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 42);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Availble_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Availble_Inventory";
            this.Text = "Availble_Inventory";
            this.Load += new System.EventHandler(this.Availble_Inventory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvavailableinventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvavailableinventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
    }
}