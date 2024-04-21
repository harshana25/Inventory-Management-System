
namespace WindowsFormsApp1
{
    partial class Order_Approve
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
            this.dgvdisplayorders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtdelimethod = new System.Windows.Forms.TextBox();
            this.btnnewtot = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnapprove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdateoforder = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplayorders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdisplayorders
            // 
            this.dgvdisplayorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplayorders.Location = new System.Drawing.Point(202, 12);
            this.dgvdisplayorders.Name = "dgvdisplayorders";
            this.dgvdisplayorders.RowHeadersWidth = 51;
            this.dgvdisplayorders.RowTemplate.Height = 24;
            this.dgvdisplayorders.Size = new System.Drawing.Size(888, 324);
            this.dgvdisplayorders.TabIndex = 0;
            this.dgvdisplayorders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdisplayorders_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Price";
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(337, 422);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.ReadOnly = true;
            this.txtitemcode.Size = new System.Drawing.Size(200, 30);
            this.txtitemcode.TabIndex = 6;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(337, 497);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(200, 30);
            this.txtitemname.TabIndex = 7;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(825, 363);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(181, 30);
            this.txtquantity.TabIndex = 8;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(825, 500);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(181, 30);
            this.txtunitprice.TabIndex = 9;
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(825, 560);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(181, 30);
            this.txttotalprice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Delivery Method";
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(337, 564);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.ReadOnly = true;
            this.txtlocation.Size = new System.Drawing.Size(200, 30);
            this.txtlocation.TabIndex = 16;
            // 
            // txtdelimethod
            // 
            this.txtdelimethod.Location = new System.Drawing.Point(825, 419);
            this.txtdelimethod.Name = "txtdelimethod";
            this.txtdelimethod.ReadOnly = true;
            this.txtdelimethod.Size = new System.Drawing.Size(181, 30);
            this.txtdelimethod.TabIndex = 17;
            // 
            // btnnewtot
            // 
            this.btnnewtot.Location = new System.Drawing.Point(611, 615);
            this.btnnewtot.Name = "btnnewtot";
            this.btnnewtot.Size = new System.Drawing.Size(135, 32);
            this.btnnewtot.TabIndex = 18;
            this.btnnewtot.Text = "New Total";
            this.btnnewtot.UseVisualStyleBackColor = true;
            this.btnnewtot.Click += new System.EventHandler(this.btnnewtot_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(804, 614);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 33);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(981, 614);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(94, 32);
            this.btnapprove.TabIndex = 20;
            this.btnapprove.Text = "Approved";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Date of Order";
            // 
            // txtdateoforder
            // 
            this.txtdateoforder.Location = new System.Drawing.Point(337, 367);
            this.txtdateoforder.Name = "txtdateoforder";
            this.txtdateoforder.ReadOnly = true;
            this.txtdateoforder.Size = new System.Drawing.Size(200, 30);
            this.txtdateoforder.TabIndex = 22;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1109, 614);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(98, 32);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Order_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1314, 676);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtdateoforder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnnewtot);
            this.Controls.Add(this.txtdelimethod);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdisplayorders);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order_Approve";
            this.Text = "Order Approve";
            this.Load += new System.EventHandler(this.Order_Approve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplayorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdisplayorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtdelimethod;
        private System.Windows.Forms.Button btnnewtot;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdateoforder;
        private System.Windows.Forms.Button btnexit;
    }
}