
namespace WindowsFormsApp1
{
    partial class Balanced_Inventory_Report
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
            this.dgvbalancedinventory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.btnviewbalinven = new System.Windows.Forms.Button();
            this.btnprintreport = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalancedinventory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balanced Inventory Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvbalancedinventory);
            this.panel1.Location = new System.Drawing.Point(78, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 410);
            this.panel1.TabIndex = 2;
            // 
            // dgvbalancedinventory
            // 
            this.dgvbalancedinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbalancedinventory.Location = new System.Drawing.Point(0, 0);
            this.dgvbalancedinventory.Name = "dgvbalancedinventory";
            this.dgvbalancedinventory.RowHeadersWidth = 51;
            this.dgvbalancedinventory.RowTemplate.Height = 24;
            this.dgvbalancedinventory.Size = new System.Drawing.Size(1159, 322);
            this.dgvbalancedinventory.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartdate.Location = new System.Drawing.Point(453, 142);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(200, 34);
            this.dtpstartdate.TabIndex = 4;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(960, 142);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(200, 34);
            this.dtpenddate.TabIndex = 5;
            // 
            // btnviewbalinven
            // 
            this.btnviewbalinven.Location = new System.Drawing.Point(378, 202);
            this.btnviewbalinven.Name = "btnviewbalinven";
            this.btnviewbalinven.Size = new System.Drawing.Size(275, 51);
            this.btnviewbalinven.TabIndex = 6;
            this.btnviewbalinven.Text = "View Balanced Inventory";
            this.btnviewbalinven.UseVisualStyleBackColor = true;
            this.btnviewbalinven.Click += new System.EventHandler(this.btnviewbalinven_Click);
            // 
            // btnprintreport
            // 
            this.btnprintreport.Location = new System.Drawing.Point(748, 202);
            this.btnprintreport.Name = "btnprintreport";
            this.btnprintreport.Size = new System.Drawing.Size(179, 51);
            this.btnprintreport.TabIndex = 7;
            this.btnprintreport.Text = "Print Report";
            this.btnprintreport.UseVisualStyleBackColor = true;
            this.btnprintreport.Click += new System.EventHandler(this.btnprintreport_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(960, 202);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(107, 51);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Balanced_Inventory_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnprintreport);
            this.Controls.Add(this.btnviewbalinven);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.dtpstartdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Balanced_Inventory_Report";
            this.Text = "Balanced_Inventory_Report";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbalancedinventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.Button btnviewbalinven;
        private System.Windows.Forms.Button btnprintreport;
        private System.Windows.Forms.DataGridView dgvbalancedinventory;
        private System.Windows.Forms.Button btnexit;
    }
}