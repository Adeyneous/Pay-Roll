namespace PayRoll
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbShowpassword = new System.Windows.Forms.CheckBox();
            this.linkChangepassword = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblclose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEOUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(150, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "TImeSheet Management";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Azure;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtUsername.Location = new System.Drawing.Point(248, 197);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(196, 38);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "User Name ";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPassword.Location = new System.Drawing.Point(248, 265);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 38);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(267, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            // 
            // chbShowpassword
            // 
            this.chbShowpassword.AutoSize = true;
            this.chbShowpassword.BackColor = System.Drawing.Color.Transparent;
            this.chbShowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowpassword.ForeColor = System.Drawing.Color.Azure;
            this.chbShowpassword.Location = new System.Drawing.Point(416, 335);
            this.chbShowpassword.Name = "chbShowpassword";
            this.chbShowpassword.Size = new System.Drawing.Size(152, 22);
            this.chbShowpassword.TabIndex = 5;
            this.chbShowpassword.Text = "Show Password";
            this.chbShowpassword.UseVisualStyleBackColor = false;
            this.chbShowpassword.CheckedChanged += new System.EventHandler(this.chbShowpassword_CheckedChanged);
            // 
            // linkChangepassword
            // 
            this.linkChangepassword.AutoSize = true;
            this.linkChangepassword.BackColor = System.Drawing.Color.Transparent;
            this.linkChangepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangepassword.ForeColor = System.Drawing.Color.Azure;
            this.linkChangepassword.LinkColor = System.Drawing.Color.Azure;
            this.linkChangepassword.Location = new System.Drawing.Point(154, 334);
            this.linkChangepassword.Name = "linkChangepassword";
            this.linkChangepassword.Size = new System.Drawing.Size(145, 18);
            this.linkChangepassword.TabIndex = 6;
            this.linkChangepassword.TabStop = true;
            this.linkChangepassword.Text = "Change Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.Location = new System.Drawing.Point(177, 388);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(130, 40);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btncancel.Location = new System.Drawing.Point(369, 388);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(124, 40);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(568, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.ForeColor = System.Drawing.Color.Red;
            this.lblclose.Location = new System.Drawing.Point(771, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(15, 16);
            this.lblclose.TabIndex = 10;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 534);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.linkChangepassword);
            this.Controls.Add(this.chbShowpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbShowpassword;
        private System.Windows.Forms.LinkLabel linkChangepassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblclose;
    }
}