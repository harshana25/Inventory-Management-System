
namespace WindowsFormsApp1
{
    partial class View_Obsolate_Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvviewobsinventory = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewobsinventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Obsolate Inventories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvviewobsinventory);
            this.panel1.Location = new System.Drawing.Point(54, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 344);
            this.panel1.TabIndex = 1;
            // 
            // dgvviewobsinventory
            // 
            this.dgvviewobsinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewobsinventory.Location = new System.Drawing.Point(0, 0);
            this.dgvviewobsinventory.Name = "dgvviewobsinventory";
            this.dgvviewobsinventory.RowHeadersWidth = 51;
            this.dgvviewobsinventory.RowTemplate.Height = 24;
            this.dgvviewobsinventory.Size = new System.Drawing.Size(1231, 296);
            this.dgvviewobsinventory.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(552, 554);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(121, 44);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // View_Obsolate_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "View_Obsolate_Inventory";
            this.Text = "View_Obsolate_Inventory";
            this.Load += new System.EventHandler(this.View_Obsolate_Inventory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewobsinventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvviewobsinventory;
        private System.Windows.Forms.Button btnexit;
    }
}