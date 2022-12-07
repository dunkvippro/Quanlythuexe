namespace Quanlythuexe
{
    partial class FormChiphiphatsinh
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
            this.BT_hoantat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_tongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lB_cacvande = new System.Windows.Forms.ListBox();
            this.BT_xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_chiphi = new System.Windows.Forms.TextBox();
            this.cB_vandephatsinh = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_hoantat
            // 
            this.BT_hoantat.Location = new System.Drawing.Point(307, 22);
            this.BT_hoantat.Name = "BT_hoantat";
            this.BT_hoantat.Size = new System.Drawing.Size(176, 36);
            this.BT_hoantat.TabIndex = 1;
            this.BT_hoantat.Text = "Hoàn tất";
            this.BT_hoantat.UseVisualStyleBackColor = true;
            this.BT_hoantat.Click += new System.EventHandler(this.BT_hoantat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÁC VẤN ĐỀ PHÁT SINH";
            // 
            // tB_tongtien
            // 
            this.tB_tongtien.Location = new System.Drawing.Point(48, 36);
            this.tB_tongtien.Name = "tB_tongtien";
            this.tB_tongtien.Size = new System.Drawing.Size(154, 22);
            this.tB_tongtien.TabIndex = 7;
            this.tB_tongtien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "TỔNG TIỀN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "VNĐ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tB_tongtien);
            this.panel3.Controls.Add(this.BT_hoantat);
            this.panel3.Location = new System.Drawing.Point(39, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 74);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 220);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lB_cacvande);
            this.panel4.Controls.Add(this.BT_xoa);
            this.panel4.Location = new System.Drawing.Point(313, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 172);
            this.panel4.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Vấn đề đã thêm";
            // 
            // lB_cacvande
            // 
            this.lB_cacvande.FormattingEnabled = true;
            this.lB_cacvande.HorizontalScrollbar = true;
            this.lB_cacvande.ItemHeight = 16;
            this.lB_cacvande.Location = new System.Drawing.Point(17, 27);
            this.lB_cacvande.Name = "lB_cacvande";
            this.lB_cacvande.Size = new System.Drawing.Size(212, 100);
            this.lB_cacvande.TabIndex = 15;
            // 
            // BT_xoa
            // 
            this.BT_xoa.Location = new System.Drawing.Point(64, 133);
            this.BT_xoa.Name = "BT_xoa";
            this.BT_xoa.Size = new System.Drawing.Size(119, 27);
            this.BT_xoa.TabIndex = 14;
            this.BT_xoa.Text = "Xóa";
            this.BT_xoa.UseVisualStyleBackColor = true;
            this.BT_xoa.Click += new System.EventHandler(this.BT_xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BT_them);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tB_chiphi);
            this.panel1.Controls.Add(this.cB_vandephatsinh);
            this.panel1.Location = new System.Drawing.Point(26, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 173);
            this.panel1.TabIndex = 17;
            // 
            // BT_them
            // 
            this.BT_them.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_them.Location = new System.Drawing.Point(70, 131);
            this.BT_them.Name = "BT_them";
            this.BT_them.Size = new System.Drawing.Size(119, 29);
            this.BT_them.TabIndex = 13;
            this.BT_them.Text = "Thêm";
            this.BT_them.UseVisualStyleBackColor = true;
            this.BT_them.Click += new System.EventHandler(this.BT_them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Chi phí phải trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Vấn đề";
            // 
            // tB_chiphi
            // 
            this.tB_chiphi.Location = new System.Drawing.Point(24, 83);
            this.tB_chiphi.Name = "tB_chiphi";
            this.tB_chiphi.Size = new System.Drawing.Size(176, 22);
            this.tB_chiphi.TabIndex = 3;
            // 
            // cB_vandephatsinh
            // 
            this.cB_vandephatsinh.FormattingEnabled = true;
            this.cB_vandephatsinh.Location = new System.Drawing.Point(24, 30);
            this.cB_vandephatsinh.Name = "cB_vandephatsinh";
            this.cB_vandephatsinh.Size = new System.Drawing.Size(218, 24);
            this.cB_vandephatsinh.TabIndex = 0;
            this.cB_vandephatsinh.SelectionChangeCommitted += new System.EventHandler(this.cB_vandephatsinh_SelectionChangeCommitted);
            // 
            // FormChiphiphatsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Name = "FormChiphiphatsinh";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiphiphatsinh";
            this.Load += new System.EventHandler(this.Chiphiphatsinh_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button BT_hoantat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_tongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lB_cacvande;
        private System.Windows.Forms.Button BT_xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_chiphi;
        private System.Windows.Forms.ComboBox cB_vandephatsinh;
    }
}