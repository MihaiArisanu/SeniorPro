namespace SeniorPro
{
    partial class Amintiri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amintiri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_inapoi = new System.Windows.Forms.Button();
            this.btn_automat = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.btn_inainte = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 411);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(984, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // btn_inapoi
            // 
            this.btn_inapoi.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inapoi.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic);
            this.btn_inapoi.Location = new System.Drawing.Point(12, 514);
            this.btn_inapoi.Name = "btn_inapoi";
            this.btn_inapoi.Size = new System.Drawing.Size(112, 34);
            this.btn_inapoi.TabIndex = 2;
            this.btn_inapoi.Text = "Inapoi";
            this.btn_inapoi.UseVisualStyleBackColor = false;
            this.btn_inapoi.Click += new System.EventHandler(this.btn_inapoi_Click);
            // 
            // btn_automat
            // 
            this.btn_automat.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_automat.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic);
            this.btn_automat.Location = new System.Drawing.Point(448, 514);
            this.btn_automat.Name = "btn_automat";
            this.btn_automat.Size = new System.Drawing.Size(112, 34);
            this.btn_automat.TabIndex = 3;
            this.btn_automat.Text = "Automat";
            this.btn_automat.UseVisualStyleBackColor = false;
            this.btn_automat.Click += new System.EventHandler(this.btn_automat_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_manual.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic);
            this.btn_manual.Location = new System.Drawing.Point(448, 514);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(112, 34);
            this.btn_manual.TabIndex = 5;
            this.btn_manual.Text = "Manual";
            this.btn_manual.UseVisualStyleBackColor = false;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_inainte
            // 
            this.btn_inainte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inainte.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic);
            this.btn_inainte.Location = new System.Drawing.Point(884, 514);
            this.btn_inainte.Name = "btn_inainte";
            this.btn_inainte.Size = new System.Drawing.Size(112, 34);
            this.btn_inainte.TabIndex = 6;
            this.btn_inainte.Text = "Inainte";
            this.btn_inainte.UseVisualStyleBackColor = false;
            this.btn_inainte.Click += new System.EventHandler(this.btn_inainte_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(946, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 39);
            this.btn_back.TabIndex = 7;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Amintiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1008, 585);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_inainte);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.btn_automat);
            this.Controls.Add(this.btn_inapoi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amintiri";
            this.Text = "AmintiriSlideShow";
            this.Load += new System.EventHandler(this.Amintiri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_inapoi;
        private System.Windows.Forms.Button btn_automat;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Button btn_inainte;
        private System.Windows.Forms.Button btn_back;
    }
}