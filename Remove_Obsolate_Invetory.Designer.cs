
namespace WindowsFormsApp1
{
    partial class Remove_Obsolate_Invetory
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvrunninginventory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtobsprice = new System.Windows.Forms.TextBox();
            this.dtpremovedate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtunitcategory = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrunninginventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Obsolate Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remove Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvrunninginventory);
            this.panel1.Location = new System.Drawing.Point(34, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 270);
            this.panel1.TabIndex = 2;
            // 
            // dgvrunninginventory
            // 
            this.dgvrunninginventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrunninginventory.Location = new System.Drawing.Point(0, 0);
            this.dgvrunninginventory.Name = "dgvrunninginventory";
            this.dgvrunninginventory.RowHeadersWidth = 51;
            this.dgvrunninginventory.RowTemplate.Height = 24;
            this.dgvrunninginventory.Size = new System.Drawing.Size(1274, 226);
            this.dgvrunninginventory.TabIndex = 0;
            this.dgvrunninginventory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvrunninginventory_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Name";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(891, 600);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(105, 35);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1146, 600);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 35);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unit Price Rs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Obsolate Inventoy Price Rs.";
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(335, 465);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(200, 34);
            this.txtitemcode.TabIndex = 9;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(335, 552);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(200, 34);
            this.txtitemname.TabIndex = 10;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(335, 625);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(200, 34);
            this.txtunitprice.TabIndex = 11;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(990, 458);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(200, 34);
            this.txtquantity.TabIndex = 12;
            // 
            // txtobsprice
            // 
            this.txtobsprice.Location = new System.Drawing.Point(990, 544);
            this.txtobsprice.Name = "txtobsprice";
            this.txtobsprice.Size = new System.Drawing.Size(200, 34);
            this.txtobsprice.TabIndex = 13;
            // 
            // dtpremovedate
            // 
            this.dtpremovedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpremovedate.Location = new System.Drawing.Point(335, 389);
            this.dtpremovedate.Name = "dtpremovedate";
            this.dtpremovedate.Size = new System.Drawing.Size(200, 34);
            this.dtpremovedate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unit Category";
            // 
            // txtunitcategory
            // 
            this.txtunitcategory.Location = new System.Drawing.Point(990, 388);
            this.txtunitcategory.Name = "txtunitcategory";
            this.txtunitcategory.Size = new System.Drawing.Size(200, 34);
            this.txtunitcategory.TabIndex = 16;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(1022, 600);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(99, 35);
            this.btninsert.TabIndex = 17;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // Remove_Obsolate_Invetory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1370, 682);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtunitcategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpremovedate);
            this.Controls.Add(this.txtobsprice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Remove_Obsolate_Invetory";
            this.Text = "Remove_Obsolate_Inventory";
            this.Load += new System.EventHandler(this.Remove_Obsolate_Invetory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrunninginventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvrunninginventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtobsprice;
        private System.Windows.Forms.DateTimePicker dtpremovedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtunitcategory;
        private System.Windows.Forms.Button btninsert;
    }
}