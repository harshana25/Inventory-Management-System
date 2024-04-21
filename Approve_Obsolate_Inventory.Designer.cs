
namespace WindowsFormsApp1
{
    partial class Approve_Obsolate_Inventory
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
            this.dgvapproveobsinven = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvviewobsolateinven = new System.Windows.Forms.DataGridView();
            this.txtdateofremove = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtunitcategory = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtobsinvenamount = new System.Windows.Forms.TextBox();
            this.btnapprove = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvapproveobsinven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewobsolateinven)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approve Obsolate Inventories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvviewobsolateinven);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvapproveobsinven);
            this.panel1.Location = new System.Drawing.Point(89, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 426);
            this.panel1.TabIndex = 1;
            // 
            // dgvapproveobsinven
            // 
            this.dgvapproveobsinven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvapproveobsinven.Location = new System.Drawing.Point(3, 0);
            this.dgvapproveobsinven.Name = "dgvapproveobsinven";
            this.dgvapproveobsinven.RowHeadersWidth = 51;
            this.dgvapproveobsinven.RowTemplate.Height = 24;
            this.dgvapproveobsinven.Size = new System.Drawing.Size(1336, 172);
            this.dgvapproveobsinven.TabIndex = 0;
            this.dgvapproveobsinven.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvapproveobsinven_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Unit Price Rs.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(907, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 27);
            this.label8.TabIndex = 8;
            this.label8.Text = "Obsolate Inventoy Amount Rs.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "View Obsolate Inventories";
            // 
            // dgvviewobsolateinven
            // 
            this.dgvviewobsolateinven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewobsolateinven.Location = new System.Drawing.Point(0, 243);
            this.dgvviewobsolateinven.Name = "dgvviewobsolateinven";
            this.dgvviewobsolateinven.RowHeadersWidth = 51;
            this.dgvviewobsolateinven.RowTemplate.Height = 24;
            this.dgvviewobsolateinven.Size = new System.Drawing.Size(1339, 180);
            this.dgvviewobsolateinven.TabIndex = 2;
            // 
            // txtdateofremove
            // 
            this.txtdateofremove.Location = new System.Drawing.Point(294, 507);
            this.txtdateofremove.Name = "txtdateofremove";
            this.txtdateofremove.ReadOnly = true;
            this.txtdateofremove.Size = new System.Drawing.Size(192, 34);
            this.txtdateofremove.TabIndex = 3;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(294, 590);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.ReadOnly = true;
            this.txtitemcode.Size = new System.Drawing.Size(192, 34);
            this.txtitemcode.TabIndex = 9;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(294, 677);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(192, 34);
            this.txtitemname.TabIndex = 10;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(696, 504);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.ReadOnly = true;
            this.txtunitprice.Size = new System.Drawing.Size(192, 34);
            this.txtunitprice.TabIndex = 11;
            // 
            // txtunitcategory
            // 
            this.txtunitcategory.Location = new System.Drawing.Point(696, 593);
            this.txtunitcategory.Name = "txtunitcategory";
            this.txtunitcategory.ReadOnly = true;
            this.txtunitcategory.Size = new System.Drawing.Size(192, 34);
            this.txtunitcategory.TabIndex = 12;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(696, 677);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(192, 34);
            this.txtquantity.TabIndex = 13;
            // 
            // txtobsinvenamount
            // 
            this.txtobsinvenamount.Location = new System.Drawing.Point(1234, 496);
            this.txtobsinvenamount.Name = "txtobsinvenamount";
            this.txtobsinvenamount.ReadOnly = true;
            this.txtobsinvenamount.Size = new System.Drawing.Size(192, 34);
            this.txtobsinvenamount.TabIndex = 14;
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(992, 613);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(108, 34);
            this.btnapprove.TabIndex = 15;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1184, 613);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 34);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Approve_Obsolate_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1479, 774);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.txtobsinvenamount);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtunitcategory);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.txtdateofremove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Approve_Obsolate_Inventory";
            this.Text = "Approve_Obsolate_Inventory";
            this.Load += new System.EventHandler(this.Approve_Obsolate_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvapproveobsinven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewobsolateinven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvapproveobsinven;
        private System.Windows.Forms.DataGridView dgvviewobsolateinven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdateofremove;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtunitcategory;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtobsinvenamount;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Button btnexit;
    }
}