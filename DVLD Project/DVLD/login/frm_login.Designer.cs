namespace DVLD.login
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_User = new System.Windows.Forms.Label();
            this.Txb_User_Name = new System.Windows.Forms.TextBox();
            this.pic_User = new System.Windows.Forms.PictureBox();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(886, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 53);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login to your account";
            // 
            // Lb_User
            // 
            this.Lb_User.AutoSize = true;
            this.Lb_User.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_User.Location = new System.Drawing.Point(516, 235);
            this.Lb_User.Name = "Lb_User";
            this.Lb_User.Size = new System.Drawing.Size(125, 27);
            this.Lb_User.TabIndex = 3;
            this.Lb_User.Text = "User Name";
            this.Lb_User.Click += new System.EventHandler(this.Lb_User_Click);
            // 
            // Txb_User_Name
            // 
            this.Txb_User_Name.Location = new System.Drawing.Point(699, 240);
            this.Txb_User_Name.Name = "Txb_User_Name";
            this.Txb_User_Name.Size = new System.Drawing.Size(233, 22);
            this.Txb_User_Name.TabIndex = 4;
            this.Txb_User_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pic_User
            // 
            this.pic_User.Image = ((System.Drawing.Image)(resources.GetObject("pic_User.Image")));
            this.pic_User.Location = new System.Drawing.Point(650, 230);
            this.pic_User.Name = "pic_User";
            this.pic_User.Size = new System.Drawing.Size(32, 32);
            this.pic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_User.TabIndex = 5;
            this.pic_User.TabStop = false;
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(516, 287);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(108, 27);
            this.Lb_Password.TabIndex = 6;
            this.Lb_Password.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(650, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Txb_Password
            // 
            this.Txb_Password.Location = new System.Drawing.Point(699, 297);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.Size = new System.Drawing.Size(233, 22);
            this.Txb_Password.TabIndex = 8;
            // 
            // bt_Login
            // 
            this.bt_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Login.Image = ((System.Drawing.Image)(resources.GetObject("bt_Login.Image")));
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(699, 357);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(133, 48);
            this.bt_Login.TabIndex = 9;
            this.bt_Login.Text = "Login ";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 559);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.pic_User);
            this.Controls.Add(this.Txb_User_Name);
            this.Controls.Add(this.Lb_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_User;
        private System.Windows.Forms.TextBox Txb_User_Name;
        private System.Windows.Forms.PictureBox pic_User;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.Button bt_Login;
    }
}