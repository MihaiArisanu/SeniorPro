
namespace SeniorPro
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_show_hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_password = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_show_hide
            // 
            this.btn_show_hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_show_hide.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_hide.Location = new System.Drawing.Point(457, 217);
            this.btn_show_hide.Name = "btn_show_hide";
            this.btn_show_hide.Size = new System.Drawing.Size(130, 33);
            this.btn_show_hide.TabIndex = 9;
            this.btn_show_hide.UseVisualStyleBackColor = true;
            this.btn_show_hide.Click += new System.EventHandler(this.btn_show_hide_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(187, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_email.Location = new System.Drawing.Point(302, 137);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(285, 34);
            this.txt_email.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_pass.Location = new System.Drawing.Point(302, 177);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(285, 34);
            this.txt_pass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "Să verificăm cine ești?";
            // 
            // btn_password
            // 
            this.btn_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_password.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_password.Location = new System.Drawing.Point(599, 342);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(189, 96);
            this.btn_password.TabIndex = 5;
            this.btn_password.Text = "Am uitat parola";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_register.Location = new System.Drawing.Point(12, 342);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(189, 96);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Nu m-am înregistrat";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_login.Location = new System.Drawing.Point(283, 268);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(250, 51);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Să începem!";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_show_hide);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_show_hide;
    }
}