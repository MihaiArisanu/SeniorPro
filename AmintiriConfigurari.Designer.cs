namespace SeniorPro
{
    partial class AmintiriConfigurari
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_inainte = new System.Windows.Forms.Button();
            this.btn_inapoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câteva fotografii, amintiri de suflet pentru ";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_add.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(366, 432);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Adaugă";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_delete.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Location = new System.Drawing.Point(248, 432);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 34);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Șterge";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_inainte
            // 
            this.btn_inainte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inainte.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btn_inainte.Location = new System.Drawing.Point(597, 432);
            this.btn_inainte.Name = "btn_inainte";
            this.btn_inainte.Size = new System.Drawing.Size(112, 34);
            this.btn_inainte.TabIndex = 13;
            this.btn_inainte.Text = "Înainte";
            this.btn_inainte.UseVisualStyleBackColor = false;
            this.btn_inainte.Click += new System.EventHandler(this.btn_inainte_Click);
            // 
            // btn_inapoi
            // 
            this.btn_inapoi.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inapoi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inapoi.Location = new System.Drawing.Point(12, 432);
            this.btn_inapoi.Name = "btn_inapoi";
            this.btn_inapoi.Size = new System.Drawing.Size(112, 34);
            this.btn_inapoi.TabIndex = 14;
            this.btn_inapoi.Text = "Înapoi";
            this.btn_inapoi.UseVisualStyleBackColor = false;
            this.btn_inapoi.Click += new System.EventHandler(this.btn_inapoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(10, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 399);
            this.panel1.TabIndex = 15;
            // 
            // AmintiriConfigurari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(734, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_inapoi);
            this.Controls.Add(this.btn_inainte);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmintiriConfigurari";
            this.Text = "Amintiri";
            this.Load += new System.EventHandler(this.AmintiriConfigurari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_inainte;
        private System.Windows.Forms.Button btn_inapoi;
        private System.Windows.Forms.Panel panel1;
    }
}