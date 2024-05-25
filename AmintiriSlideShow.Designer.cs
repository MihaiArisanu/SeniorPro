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
            this.btn_inapoi = new System.Windows.Forms.Button();
            this.btn_inainte = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTratament = new System.Windows.Forms.Button();
            this.btnVorbim = new System.Windows.Forms.Button();
            this.btnAmintiri = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 722);
            this.panel1.TabIndex = 0;
            // 
            // btn_inapoi
            // 
            this.btn_inapoi.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inapoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_inapoi.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inapoi.Location = new System.Drawing.Point(0, 0);
            this.btn_inapoi.Name = "btn_inapoi";
            this.btn_inapoi.Size = new System.Drawing.Size(131, 45);
            this.btn_inapoi.TabIndex = 2;
            this.btn_inapoi.Text = "Înapoi";
            this.btn_inapoi.UseVisualStyleBackColor = false;
            this.btn_inapoi.Click += new System.EventHandler(this.btn_inapoi_Click);
            // 
            // btn_inainte
            // 
            this.btn_inainte.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_inainte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_inainte.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Bold);
            this.btn_inainte.Location = new System.Drawing.Point(930, 0);
            this.btn_inainte.Name = "btn_inainte";
            this.btn_inainte.Size = new System.Drawing.Size(131, 45);
            this.btn_inainte.TabIndex = 6;
            this.btn_inainte.Text = "Înainte";
            this.btn_inainte.UseVisualStyleBackColor = false;
            this.btn_inainte.Click += new System.EventHandler(this.btn_inainte_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Cyan;
            this.panelMenu.Controls.Add(this.btnBack);
            this.panelMenu.Controls.Add(this.btnTratament);
            this.panelMenu.Controls.Add(this.btnVorbim);
            this.panelMenu.Controls.Add(this.btnAmintiri);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 722);
            this.panelMenu.TabIndex = 38;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cyan;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnBack.Location = new System.Drawing.Point(0, 677);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(217, 45);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTratament
            // 
            this.btnTratament.BackColor = System.Drawing.Color.Cyan;
            this.btnTratament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTratament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratament.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTratament.Location = new System.Drawing.Point(0, 264);
            this.btnTratament.Name = "btnTratament";
            this.btnTratament.Size = new System.Drawing.Size(217, 45);
            this.btnTratament.TabIndex = 6;
            this.btnTratament.Text = "Tratament";
            this.btnTratament.UseVisualStyleBackColor = false;
            this.btnTratament.Click += new System.EventHandler(this.btnTratament_Click);
            // 
            // btnVorbim
            // 
            this.btnVorbim.BackColor = System.Drawing.Color.Cyan;
            this.btnVorbim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVorbim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVorbim.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnVorbim.Location = new System.Drawing.Point(0, 219);
            this.btnVorbim.Name = "btnVorbim";
            this.btnVorbim.Size = new System.Drawing.Size(217, 45);
            this.btnVorbim.TabIndex = 5;
            this.btnVorbim.Text = "Hai să vorbim";
            this.btnVorbim.UseVisualStyleBackColor = false;
            this.btnVorbim.Click += new System.EventHandler(this.btnVorbim_Click);
            // 
            // btnAmintiri
            // 
            this.btnAmintiri.BackColor = System.Drawing.Color.Cyan;
            this.btnAmintiri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmintiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmintiri.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAmintiri.Location = new System.Drawing.Point(0, 174);
            this.btnAmintiri.Name = "btnAmintiri";
            this.btnAmintiri.Size = new System.Drawing.Size(217, 45);
            this.btnAmintiri.TabIndex = 1;
            this.btnAmintiri.Text = "Amintiri";
            this.btnAmintiri.UseVisualStyleBackColor = false;
            this.btnAmintiri.Click += new System.EventHandler(this.btnAmintiri_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 174);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_inapoi);
            this.panel2.Controls.Add(this.btn_inainte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(217, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 45);
            this.panel2.TabIndex = 39;
            // 
            // Amintiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1278, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amintiri";
            this.Text = "AmintiriSlideShow";
            this.Load += new System.EventHandler(this.Amintiri_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_inapoi;
        private System.Windows.Forms.Button btn_inainte;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTratament;
        private System.Windows.Forms.Button btnVorbim;
        private System.Windows.Forms.Button btnAmintiri;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
    }
}