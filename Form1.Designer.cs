
namespace WindowsFormsApp1
{
    partial class Login_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnsignout = new System.Windows.Forms.Button();
            this.btnsignin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(468, 197);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(186, 34);
            this.txtuname.TabIndex = 2;
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(468, 297);
            this.txtpword.Name = "txtpword";
            this.txtpword.PasswordChar = '*';
            this.txtpword.Size = new System.Drawing.Size(186, 34);
            this.txtpword.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Category";
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "User",
            "SPD_Admin"});
            this.cmbcategory.Location = new System.Drawing.Point(468, 399);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(186, 35);
            this.cmbcategory.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Avast_Passwords_logo;
            this.pictureBox3.Location = new System.Drawing.Point(149, 297);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.gm_user1;
            this.pictureBox2.Location = new System.Drawing.Point(152, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnsignout
            // 
            this.btnsignout.Location = new System.Drawing.Point(505, 522);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(116, 39);
            this.btnsignout.TabIndex = 9;
            this.btnsignout.Text = "Sign Out";
            this.btnsignout.UseVisualStyleBackColor = true;
            this.btnsignout.Click += new System.EventHandler(this.btnsignout_Click);
            // 
            // btnsignin
            // 
            this.btnsignin.Location = new System.Drawing.Point(243, 522);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(107, 39);
            this.btnsignin.TabIndex = 10;
            this.btnsignin.Text = "Sign In";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 50);
            this.label8.TabIndex = 11;
            this.label8.Text = "Login";
            // 
            // Login_Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(830, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.btnsignout);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpword);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox cmbusercategory;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Label label8;
    }
}

