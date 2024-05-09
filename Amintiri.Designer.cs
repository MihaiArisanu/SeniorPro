
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
<<<<<<< Updated upstream:Amintiri.Designer.cs
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amintiri));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vorbim));
            this.btn_back = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
>>>>>>> Stashed changes:Vorbim.Designer.cs
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
<<<<<<< Updated upstream:Amintiri.Designer.cs
            // Amintiri
=======
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(194, 532);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(545, 22);
            this.txtChat.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_send.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(750, 523);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(138, 38);
            this.btn_send.TabIndex = 31;
            this.btn_send.Text = "Trimite";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // Vorbim
>>>>>>> Stashed changes:Vorbim.Designer.cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
<<<<<<< Updated upstream:Amintiri.Designer.cs
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            this.ClientSize = new System.Drawing.Size(1008, 585);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btn_back);
>>>>>>> Stashed changes:Vorbim.Designer.cs
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amintiri";
            this.Text = "Amintiri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< Updated upstream:Amintiri.Designer.cs
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
=======
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btn_send;
>>>>>>> Stashed changes:Vorbim.Designer.cs
    }
}