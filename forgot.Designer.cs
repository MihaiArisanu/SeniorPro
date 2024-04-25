
namespace SeniorPro
{
    partial class forgot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgot));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_inregistrare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.txt_set = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(96, 130);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(606, 22);
            this.txt_email.TabIndex = 0;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(70, 295);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(606, 22);
            this.txt_code.TabIndex = 1;
            // 
            // btn_email
            // 
            this.btn_email.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Italic);
            this.btn_email.Location = new System.Drawing.Point(302, 158);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(209, 44);
            this.btn_email.TabIndex = 2;
            this.btn_email.Text = "Trimite";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Italic);
            this.btn_check.Location = new System.Drawing.Point(302, 326);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(209, 44);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "Verifica";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scrie adresa de email";
            // 
            // lbl_inregistrare
            // 
            this.lbl_inregistrare.AutoSize = true;
            this.lbl_inregistrare.Font = new System.Drawing.Font("Constantia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lbl_inregistrare.Location = new System.Drawing.Point(132, 406);
            this.lbl_inregistrare.Name = "lbl_inregistrare";
            this.lbl_inregistrare.Size = new System.Drawing.Size(544, 35);
            this.lbl_inregistrare.TabIndex = 5;
            this.lbl_inregistrare.Text = "Daca nu ai cont, trebuie sa se te inregistrezi";
            this.lbl_inregistrare.Click += new System.EventHandler(this.lbl_inregistrare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scrie codul primit pe email";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Italic);
            this.btn_reset.Location = new System.Drawing.Point(302, 326);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(209, 44);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reseteaza";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(138, 252);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(538, 22);
            this.txt_confirm.TabIndex = 8;
            // 
            // txt_set
            // 
            this.txt_set.Location = new System.Drawing.Point(138, 170);
            this.txt_set.Name = "txt_set";
            this.txt_set.Size = new System.Drawing.Size(538, 22);
            this.txt_set.TabIndex = 9;
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(517, 295);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(147, 33);
            this.btn_show.TabIndex = 10;
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(96, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Intro o noua parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(96, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirma noua parola";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(149, 296);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(147, 35);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Sterge";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.label5.Location = new System.Drawing.Point(703, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inapoi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.txt_set);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_inregistrare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_email);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgot";
            this.Text = "Forgot your passworld";
            this.Load += new System.EventHandler(this.forgot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_inregistrare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_confirm;
        private System.Windows.Forms.TextBox txt_set;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
    }
}