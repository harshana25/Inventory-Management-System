
namespace WindowsFormsApp1
{
    partial class Product_Management
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
            this.btnorder = new System.Windows.Forms.Button();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btntot = new System.Windows.Forms.Button();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.txttotprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmbdelimethod = new System.Windows.Forms.ComboBox();
            this.cmbunitcategory = new System.Windows.Forms.ComboBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvdisplaydetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplaydetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnorder);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btntot);
            this.panel1.Controls.Add(this.txtunitprice);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbsearch);
            this.panel1.Controls.Add(this.txttotprice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.cmbdelimethod);
            this.panel1.Controls.Add(this.cmbunitcategory);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.txtlocation);
            this.panel1.Controls.Add(this.txtitemname);
            this.panel1.Controls.Add(this.txtitemcode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 379);
            this.panel1.TabIndex = 0;
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(1004, 129);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(124, 35);
            this.btnorder.TabIndex = 25;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(184, 11);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(229, 34);
            this.dtpdate.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ordering Date";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1004, 288);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(124, 34);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(1004, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(124, 34);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btntot
            // 
            this.btntot.Location = new System.Drawing.Point(1004, 17);
            this.btntot.Name = "btntot";
            this.btntot.Size = new System.Drawing.Size(124, 37);
            this.btntot.TabIndex = 20;
            this.btntot.Text = "Total";
            this.btntot.UseVisualStyleBackColor = true;
            this.btntot.Click += new System.EventHandler(this.btntot_Click);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(270, 261);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(229, 34);
            this.txtunitprice.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Unit Price Rs.";
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "A4",
            "Computer Papers",
            "Rubber Bands",
            "Red-Pen",
            "Blue-Pen",
            "Gum Bottle",
            "Cello Tape",
            "Deposit Slip",
            "Withdrawal Slip\t",
            "GL-Credit",
            "GL-Debit",
            "CS Printer Ribon",
            "Epson Printer Ribon",
            "Ink Pad",
            "Ink Bottle",
            "Pencil",
            "Ruler",
            "Paper Pastners",
            "File Clips",
            "Envelope-Window",
            "Envelope-non Window",
            "Cash Tags",
            "Cash Bags",
            "Passbook Covers",
            "ATM Card Covers",
            "Ledger Sheets",
            "ATM Machine Roll",
            "Cash Bunddle Straps",
            "Stepler Pins",
            "Funds Trasnfers",
            "Twin",
            "Batch Headers"});
            this.cmbsearch.Location = new System.Drawing.Point(728, 10);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(229, 35);
            this.cmbsearch.TabIndex = 17;
            this.cmbsearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbsearch_MouseDoubleClick);
            // 
            // txttotprice
            // 
            this.txttotprice.Location = new System.Drawing.Point(791, 321);
            this.txttotprice.Name = "txttotprice";
            this.txttotprice.Size = new System.Drawing.Size(166, 34);
            this.txttotprice.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search by Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Price Rs.";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(1004, 237);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 34);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cmbdelimethod
            // 
            this.cmbdelimethod.FormattingEnabled = true;
            this.cmbdelimethod.Items.AddRange(new object[] {
            "Routine",
            "Courier"});
            this.cmbdelimethod.Location = new System.Drawing.Point(791, 260);
            this.cmbdelimethod.Name = "cmbdelimethod";
            this.cmbdelimethod.Size = new System.Drawing.Size(166, 35);
            this.cmbdelimethod.TabIndex = 12;
            // 
            // cmbunitcategory
            // 
            this.cmbunitcategory.FormattingEnabled = true;
            this.cmbunitcategory.Items.AddRange(new object[] {
            "PKTS",
            "Pads",
            "Boxes",
            "Units"});
            this.cmbunitcategory.Location = new System.Drawing.Point(791, 121);
            this.cmbunitcategory.Name = "cmbunitcategory";
            this.cmbunitcategory.Size = new System.Drawing.Size(166, 35);
            this.cmbunitcategory.TabIndex = 11;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(791, 191);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(166, 34);
            this.txtquantity.TabIndex = 10;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(270, 328);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(229, 34);
            this.txtlocation.TabIndex = 9;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(270, 187);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(229, 34);
            this.txtitemname.TabIndex = 8;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(270, 122);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(229, 34);
            this.txtitemcode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delivery Method";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(1004, 187);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(124, 34);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location Remark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgvdisplaydetail);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1149, 339);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dgvdisplaydetail
            // 
            this.dgvdisplaydetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplaydetail.Location = new System.Drawing.Point(3, 3);
            this.dgvdisplaydetail.Name = "dgvdisplaydetail";
            this.dgvdisplaydetail.RowHeadersWidth = 51;
            this.dgvdisplaydetail.RowTemplate.Height = 24;
            this.dgvdisplaydetail.Size = new System.Drawing.Size(1146, 333);
            this.dgvdisplaydetail.TabIndex = 13;
            this.dgvdisplaydetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplaydetail_CellContentClick);
            this.dgvdisplaydetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdisplaydetail_RowHeaderMouseClick);
            // 
            // Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Product_Management";
            this.Text = "Product_Management";
            this.Load += new System.EventHandler(this.Product_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplaydetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvdisplaydetail;
        private System.Windows.Forms.ComboBox cmbdelimethod;
        private System.Windows.Forms.ComboBox cmbunitcategory;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btntot;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.TextBox txttotprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnorder;
    }
}