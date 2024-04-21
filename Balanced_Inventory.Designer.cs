
namespace WindowsFormsApp1
{
    partial class Balanced_Inventory
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvrunninginventry = new System.Windows.Forms.DataGridView();
            this.dgvbalancedinventory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpselectdate = new System.Windows.Forms.DateTimePicker();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtbalinventot = new System.Windows.Forms.TextBox();
            this.btnbaltotal = new System.Windows.Forms.Button();
            this.btnbalance = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtunitcategory = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrunninginventry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalancedinventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balancing Inventories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dgvrunninginventry);
            this.panel1.Controls.Add(this.dgvbalancedinventory);
            this.panel1.Location = new System.Drawing.Point(53, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 382);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 40);
            this.label9.TabIndex = 9;
            this.label9.Text = "Display Running Inventories";
            // 
            // dgvrunninginventry
            // 
            this.dgvrunninginventry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrunninginventry.Location = new System.Drawing.Point(3, 218);
            this.dgvrunninginventry.Name = "dgvrunninginventry";
            this.dgvrunninginventry.RowHeadersWidth = 51;
            this.dgvrunninginventry.RowTemplate.Height = 24;
            this.dgvrunninginventry.Size = new System.Drawing.Size(1206, 161);
            this.dgvrunninginventry.TabIndex = 8;
            // 
            // dgvbalancedinventory
            // 
            this.dgvbalancedinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbalancedinventory.Location = new System.Drawing.Point(0, 3);
            this.dgvbalancedinventory.Name = "dgvbalancedinventory";
            this.dgvbalancedinventory.RowHeadersWidth = 51;
            this.dgvbalancedinventory.RowTemplate.Height = 24;
            this.dgvbalancedinventory.Size = new System.Drawing.Size(1209, 158);
            this.dgvbalancedinventory.TabIndex = 7;
            this.dgvbalancedinventory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbalancedinventory_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Input Remaining Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 695);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balanced Inventory Total";
            // 
            // dtpselectdate
            // 
            this.dtpselectdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpselectdate.Location = new System.Drawing.Point(252, 520);
            this.dtpselectdate.Name = "dtpselectdate";
            this.dtpselectdate.Size = new System.Drawing.Size(244, 33);
            this.dtpselectdate.TabIndex = 7;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(252, 589);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.ReadOnly = true;
            this.txtitemcode.Size = new System.Drawing.Size(244, 33);
            this.txtitemcode.TabIndex = 8;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(252, 672);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(244, 33);
            this.txtitemname.TabIndex = 9;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(835, 569);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.ReadOnly = true;
            this.txtunitprice.Size = new System.Drawing.Size(244, 33);
            this.txtunitprice.TabIndex = 10;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(835, 635);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(244, 33);
            this.txtquantity.TabIndex = 11;
            // 
            // txtbalinventot
            // 
            this.txtbalinventot.Location = new System.Drawing.Point(835, 689);
            this.txtbalinventot.Name = "txtbalinventot";
            this.txtbalinventot.Size = new System.Drawing.Size(244, 33);
            this.txtbalinventot.TabIndex = 12;
            // 
            // btnbaltotal
            // 
            this.btnbaltotal.Location = new System.Drawing.Point(1111, 528);
            this.btnbaltotal.Name = "btnbaltotal";
            this.btnbaltotal.Size = new System.Drawing.Size(177, 31);
            this.btnbaltotal.TabIndex = 13;
            this.btnbaltotal.Text = "Balance Total";
            this.btnbaltotal.UseVisualStyleBackColor = true;
            this.btnbaltotal.Click += new System.EventHandler(this.btnbaltotal_Click);
            // 
            // btnbalance
            // 
            this.btnbalance.Location = new System.Drawing.Point(1111, 595);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(177, 31);
            this.btnbalance.TabIndex = 14;
            this.btnbalance.Text = "Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unit Category";
            // 
            // txtunitcategory
            // 
            this.txtunitcategory.Location = new System.Drawing.Point(835, 502);
            this.txtunitcategory.Name = "txtunitcategory";
            this.txtunitcategory.ReadOnly = true;
            this.txtunitcategory.Size = new System.Drawing.Size(244, 33);
            this.txtunitcategory.TabIndex = 16;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1111, 658);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(177, 31);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(1111, 708);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(177, 29);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Balanced_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtunitcategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbalance);
            this.Controls.Add(this.btnbaltotal);
            this.Controls.Add(this.txtbalinventot);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.dtpselectdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Balanced_Inventory";
            this.Text = "Balanced_Inventory";
            this.Load += new System.EventHandler(this.Balanced_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrunninginventry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalancedinventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvbalancedinventory;
        private System.Windows.Forms.DateTimePicker dtpselectdate;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtbalinventot;
        private System.Windows.Forms.Button btnbaltotal;
        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtunitcategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvrunninginventry;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
    }
}