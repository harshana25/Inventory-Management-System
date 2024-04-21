
namespace WindowsFormsApp1
{
    partial class User_Management
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnregnow = new System.Windows.Forms.Button();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtnewusername = new System.Windows.Forms.TextBox();
            this.txtdeporbranch = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.btndeleteuser = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department or Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnregnow);
            this.panel1.Controls.Add(this.txtemailid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtnewpassword);
            this.panel1.Controls.Add(this.txtnewusername);
            this.panel1.Controls.Add(this.txtdeporbranch);
            this.panel1.Controls.Add(this.txtlname);
            this.panel1.Controls.Add(this.txtfname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 617);
            this.panel1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(531, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 27);
            this.label13.TabIndex = 18;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(531, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 27);
            this.label12.TabIndex = 17;
            this.label12.Text = "*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(531, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 27);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(531, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(531, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(531, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "*";
            // 
            // btnregnow
            // 
            this.btnregnow.Location = new System.Drawing.Point(211, 563);
            this.btnregnow.Name = "btnregnow";
            this.btnregnow.Size = new System.Drawing.Size(175, 33);
            this.btnregnow.TabIndex = 13;
            this.btnregnow.Text = "Register Now";
            this.btnregnow.UseVisualStyleBackColor = true;
            this.btnregnow.Click += new System.EventHandler(this.btnregnow_Click);
            // 
            // txtemailid
            // 
            this.txtemailid.Location = new System.Drawing.Point(327, 483);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(193, 34);
            this.txtemailid.TabIndex = 12;
            this.txtemailid.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtemailid.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailid_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email User ID";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(327, 408);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(193, 34);
            this.txtnewpassword.TabIndex = 10;
            this.txtnewpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtnewpassword_Validating);
            // 
            // txtnewusername
            // 
            this.txtnewusername.Location = new System.Drawing.Point(327, 313);
            this.txtnewusername.Name = "txtnewusername";
            this.txtnewusername.Size = new System.Drawing.Size(193, 34);
            this.txtnewusername.TabIndex = 9;
            this.txtnewusername.Validated += new System.EventHandler(this.txtnewusername_Validated);
            // 
            // txtdeporbranch
            // 
            this.txtdeporbranch.Location = new System.Drawing.Point(327, 215);
            this.txtdeporbranch.Name = "txtdeporbranch";
            this.txtdeporbranch.Size = new System.Drawing.Size(193, 34);
            this.txtdeporbranch.TabIndex = 8;
            this.txtdeporbranch.Validating += new System.ComponentModel.CancelEventHandler(this.txtdeporbranch_Validating);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(327, 132);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(193, 34);
            this.txtlname.TabIndex = 7;
            this.txtlname.Validating += new System.ComponentModel.CancelEventHandler(this.txtlname_Validating);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(327, 46);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(193, 34);
            this.txtfname.TabIndex = 6;
            this.txtfname.Validated += new System.EventHandler(this.txtfname_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "New Password";
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(608, 82);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.RowHeadersWidth = 51;
            this.dgvdisplay.RowTemplate.Height = 24;
            this.dgvdisplay.Size = new System.Drawing.Size(857, 277);
            this.dgvdisplay.TabIndex = 6;
            this.dgvdisplay.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdisplay_RowHeaderMouseClick);
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.Location = new System.Drawing.Point(898, 444);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(166, 51);
            this.btndeleteuser.TabIndex = 19;
            this.btndeleteuser.Text = "Delete User";
            this.btndeleteuser.UseVisualStyleBackColor = true;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(1128, 444);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(157, 51);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1310, 444);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 51);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(704, 444);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 51);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1477, 759);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndeleteuser);
            this.Controls.Add(this.dgvdisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "User_Management";
            this.Text = "User_Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtnewusername;
        private System.Windows.Forms.TextBox txtdeporbranch;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnregnow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.Button btndeleteuser;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}