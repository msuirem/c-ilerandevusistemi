﻿
namespace hastanefinal
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 76);
            this.label1.TabIndex = 21;
            this.label1.Text = "SEKRETER GİRİŞ";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(104, 174);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(132, 30);
            this.TxtSifre.TabIndex = 20;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(104, 112);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(132, 30);
            this.MskTC.TabIndex = 19;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(104, 222);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(128, 31);
            this.BtnGiris.TabIndex = 18;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.Location = new System.Drawing.Point(28, 174);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(70, 22);
            this.LblSifre.TabIndex = 17;
            this.LblSifre.Text = "ŞİFRE:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(28, 123);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(70, 22);
            this.LblTC.TabIndex = 16;
            this.LblTC.Text = "TC NO:";
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "Sekreter Giriş";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label LblTC;
    }
}