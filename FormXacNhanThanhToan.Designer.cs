namespace Quanlythuexe
{
    partial class FormXacNhanThanhToan
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
            this.tB_idkhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_sotien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_hoantat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_danhgia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB_idkhachhang
            // 
            this.tB_idkhachhang.Location = new System.Drawing.Point(203, 116);
            this.tB_idkhachhang.Name = "tB_idkhachhang";
            this.tB_idkhachhang.Size = new System.Drawing.Size(126, 22);
            this.tB_idkhachhang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "XÁC NHẬN THANH TOÁN!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền : ";
            // 
            // tB_sotien
            // 
            this.tB_sotien.Location = new System.Drawing.Point(203, 147);
            this.tB_sotien.Name = "tB_sotien";
            this.tB_sotien.Size = new System.Drawing.Size(126, 22);
            this.tB_sotien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "VNĐ";
            // 
            // BT_hoantat
            // 
            this.BT_hoantat.BackColor = System.Drawing.Color.Gainsboro;
            this.BT_hoantat.Location = new System.Drawing.Point(149, 226);
            this.BT_hoantat.Name = "BT_hoantat";
            this.BT_hoantat.Size = new System.Drawing.Size(121, 23);
            this.BT_hoantat.TabIndex = 6;
            this.BT_hoantat.Text = "HOÀN TẤT";
            this.BT_hoantat.UseVisualStyleBackColor = false;
            this.BT_hoantat.Click += new System.EventHandler(this.BT_hoantat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thêm đánh giá";
            // 
            // tB_danhgia
            // 
            this.tB_danhgia.Location = new System.Drawing.Point(203, 185);
            this.tB_danhgia.Name = "tB_danhgia";
            this.tB_danhgia.Size = new System.Drawing.Size(126, 22);
            this.tB_danhgia.TabIndex = 7;
            // 
            // FormXacNhanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_danhgia);
            this.Controls.Add(this.BT_hoantat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_sotien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_idkhachhang);
            this.Name = "FormXacNhanThanhToan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXacNhanThanhToan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormXacNhanThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_idkhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_sotien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_hoantat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_danhgia;
    }
}