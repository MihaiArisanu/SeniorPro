﻿namespace SeniorPro
{
    partial class Vorbim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vorbim));
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cu ce te pot ajuta?";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(245, 542);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(545, 22);
            this.txtChat.TabIndex = 2;
            // 
            // btn_send
            // label2
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

            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1008, 585);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);

            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vorbim";
            this.Text = "Vorbim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btn_send;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}