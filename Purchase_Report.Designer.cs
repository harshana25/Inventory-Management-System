
namespace WindowsFormsApp1
{
    partial class Purchase_Report
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
            this.dgvviewpurchses = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnviewpurchases = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewpurchses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvviewpurchses);
            this.panel1.Location = new System.Drawing.Point(112, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 433);
            this.panel1.TabIndex = 2;
            // 
            // dgvviewpurchses
            // 
            this.dgvviewpurchses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewpurchses.Location = new System.Drawing.Point(0, 3);
            this.dgvviewpurchses.Name = "dgvviewpurchses";
            this.dgvviewpurchses.RowHeadersWidth = 51;
            this.dgvviewpurchses.RowTemplate.Height = 24;
            this.dgvviewpurchses.Size = new System.Drawing.Size(1398, 360);
            this.dgvviewpurchses.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartdate.Location = new System.Drawing.Point(337, 120);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(200, 34);
            this.dtpstartdate.TabIndex = 4;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(879, 120);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(200, 34);
            this.dtpenddate.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(1142, 120);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(158, 34);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnviewpurchases
            // 
            this.btnviewpurchases.Location = new System.Drawing.Point(898, 209);
            this.btnviewpurchases.Name = "btnviewpurchases";
            this.btnviewpurchases.Size = new System.Drawing.Size(229, 34);
            this.btnviewpurchases.TabIndex = 7;
            this.btnviewpurchases.Text = "View All Purchases";
            this.btnviewpurchases.UseVisualStyleBackColor = true;
            this.btnviewpurchases.Click += new System.EventHandler(this.btnviewpurchases_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(663, 209);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(155, 33);
            this.btnprint.TabIndex = 8;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1186, 209);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 33);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Purchase_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1636, 1055);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnviewpurchases);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.dtpstartdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Purchase_Report";
            this.Text = "Purchase_Report";
            this.Load += new System.EventHandler(this.Purchase_Report_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewpurchses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvviewpurchses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnviewpurchases;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexit;
    }
}