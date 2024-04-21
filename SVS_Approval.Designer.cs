
namespace WindowsFormsApp1
{
    partial class SVS_Approval
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
            this.dgvsvsapproval = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtdateoforderd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtunitcategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnrefreshtotal = new System.Windows.Forms.Button();
            this.btnapprove = new System.Windows.Forms.Button();
            this.btnamend = new System.Windows.Forms.Button();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtdelimethod = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsvsapproval)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsvsapproval
            // 
            this.dgvsvsapproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsvsapproval.Location = new System.Drawing.Point(12, 39);
            this.dgvsvsapproval.Name = "dgvsvsapproval";
            this.dgvsvsapproval.RowHeadersWidth = 51;
            this.dgvsvsapproval.RowTemplate.Height = 24;
            this.dgvsvsapproval.Size = new System.Drawing.Size(1258, 300);
            this.dgvsvsapproval.TabIndex = 0;
            this.dgvsvsapproval.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsvsapproval_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Department Approval";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Controls.Add(this.txtdateoforderd);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtunitcategory);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnrefreshtotal);
            this.panel1.Controls.Add(this.btnapprove);
            this.panel1.Controls.Add(this.btnamend);
            this.panel1.Controls.Add(this.txttotalprice);
            this.panel1.Controls.Add(this.txtunitprice);
            this.panel1.Controls.Add(this.txtdelimethod);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.txtlocation);
            this.panel1.Controls.Add(this.txtitemname);
            this.panel1.Controls.Add(this.txtitemcode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 333);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(1026, 286);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(107, 34);
            this.btnremove.TabIndex = 24;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // txtdateoforderd
            // 
            this.txtdateoforderd.Location = new System.Drawing.Point(241, 9);
            this.txtdateoforderd.Name = "txtdateoforderd";
            this.txtdateoforderd.ReadOnly = true;
            this.txtdateoforderd.Size = new System.Drawing.Size(186, 34);
            this.txtdateoforderd.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 27);
            this.label10.TabIndex = 22;
            this.label10.Text = "Date of Orderd";
            // 
            // txtunitcategory
            // 
            this.txtunitcategory.Location = new System.Drawing.Point(844, 20);
            this.txtunitcategory.Name = "txtunitcategory";
            this.txtunitcategory.ReadOnly = true;
            this.txtunitcategory.Size = new System.Drawing.Size(186, 34);
            this.txtunitcategory.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "Unit Category";
            // 
            // btnrefreshtotal
            // 
            this.btnrefreshtotal.Location = new System.Drawing.Point(543, 286);
            this.btnrefreshtotal.Name = "btnrefreshtotal";
            this.btnrefreshtotal.Size = new System.Drawing.Size(157, 34);
            this.btnrefreshtotal.TabIndex = 19;
            this.btnrefreshtotal.Text = "Refesh Total";
            this.btnrefreshtotal.UseVisualStyleBackColor = true;
            this.btnrefreshtotal.Click += new System.EventHandler(this.btnrefreshtotal_Click);
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(895, 286);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(106, 34);
            this.btnapprove.TabIndex = 18;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // btnamend
            // 
            this.btnamend.Location = new System.Drawing.Point(742, 286);
            this.btnamend.Name = "btnamend";
            this.btnamend.Size = new System.Drawing.Size(114, 34);
            this.btnamend.TabIndex = 17;
            this.btnamend.Text = "Amend";
            this.btnamend.UseVisualStyleBackColor = true;
            this.btnamend.Click += new System.EventHandler(this.btnamend_Click);
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(844, 218);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(186, 34);
            this.txttotalprice.TabIndex = 16;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(844, 159);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.ReadOnly = true;
            this.txtunitprice.Size = new System.Drawing.Size(186, 34);
            this.txtunitprice.TabIndex = 15;
            // 
            // txtdelimethod
            // 
            this.txtdelimethod.Location = new System.Drawing.Point(844, 89);
            this.txtdelimethod.Name = "txtdelimethod";
            this.txtdelimethod.ReadOnly = true;
            this.txtdelimethod.Size = new System.Drawing.Size(186, 34);
            this.txtdelimethod.TabIndex = 14;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(241, 274);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(186, 34);
            this.txtquantity.TabIndex = 13;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(241, 198);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.ReadOnly = true;
            this.txtlocation.Size = new System.Drawing.Size(186, 34);
            this.txtlocation.TabIndex = 12;
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(241, 131);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(186, 34);
            this.txtitemname.TabIndex = 11;
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(241, 64);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.ReadOnly = true;
            this.txtitemcode.Size = new System.Drawing.Size(186, 34);
            this.txtitemcode.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Delivery Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Code";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1157, 286);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(88, 34);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // SVS_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvsvsapproval);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SVS_Approval";
            this.Text = "SVS_Approval";
            this.Load += new System.EventHandler(this.SVS_Approval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsvsapproval)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsvsapproval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Button btnamend;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtdelimethod;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrefreshtotal;
        private System.Windows.Forms.TextBox txtunitcategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtdateoforderd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnexit;
    }
}