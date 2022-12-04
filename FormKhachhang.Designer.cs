namespace Quanlythuexe
{
    partial class FormKhachhang
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
            this.GridKhachhang = new System.Windows.Forms.DataGridView();
            this.bt_back = new System.Windows.Forms.Button();
            this.tB_idkhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_sdt = new System.Windows.Forms.TextBox();
            this.BT_reset = new System.Windows.Forms.Button();
            this.BT_xoa = new System.Windows.Forms.Button();
            this.BT_sua = new System.Windows.Forms.Button();
            this.BT_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridKhachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridKhachhang
            // 
            this.GridKhachhang.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKhachhang.GridColor = System.Drawing.SystemColors.WindowText;
            this.GridKhachhang.Location = new System.Drawing.Point(417, 102);
            this.GridKhachhang.Name = "GridKhachhang";
            this.GridKhachhang.RowHeadersWidth = 51;
            this.GridKhachhang.RowTemplate.Height = 24;
            this.GridKhachhang.Size = new System.Drawing.Size(724, 512);
            this.GridKhachhang.TabIndex = 3;
            this.GridKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(24, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(73, 23);
            this.bt_back.TabIndex = 18;
            this.bt_back.Text = "<---";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // tB_idkhachhang
            // 
            this.tB_idkhachhang.Location = new System.Drawing.Point(33, 52);
            this.tB_idkhachhang.Name = "tB_idkhachhang";
            this.tB_idkhachhang.Size = new System.Drawing.Size(247, 22);
            this.tB_idkhachhang.TabIndex = 19;
            this.tB_idkhachhang.TextChanged += new System.EventHandler(this.tB_idkhachhang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(33, 111);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(247, 22);
            this.tB_name.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Địa chỉ";
            // 
            // tB_diachi
            // 
            this.tB_diachi.Location = new System.Drawing.Point(33, 173);
            this.tB_diachi.Name = "tB_diachi";
            this.tB_diachi.Size = new System.Drawing.Size(247, 22);
            this.tB_diachi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số điện thoại";
            // 
            // tB_sdt
            // 
            this.tB_sdt.Location = new System.Drawing.Point(33, 243);
            this.tB_sdt.Name = "tB_sdt";
            this.tB_sdt.Size = new System.Drawing.Size(247, 22);
            this.tB_sdt.TabIndex = 25;
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(170, 71);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(102, 32);
            this.BT_reset.TabIndex = 30;
            this.BT_reset.Text = "RESET";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // BT_xoa
            // 
            this.BT_xoa.Location = new System.Drawing.Point(36, 71);
            this.BT_xoa.Name = "BT_xoa";
            this.BT_xoa.Size = new System.Drawing.Size(98, 32);
            this.BT_xoa.TabIndex = 29;
            this.BT_xoa.Text = "XÓA";
            this.BT_xoa.UseVisualStyleBackColor = true;
            this.BT_xoa.Click += new System.EventHandler(this.BT_xoa_Click);
            // 
            // BT_sua
            // 
            this.BT_sua.Location = new System.Drawing.Point(170, 14);
            this.BT_sua.Name = "BT_sua";
            this.BT_sua.Size = new System.Drawing.Size(102, 39);
            this.BT_sua.TabIndex = 28;
            this.BT_sua.Text = "CẬP NHẬT";
            this.BT_sua.UseVisualStyleBackColor = true;
            this.BT_sua.Click += new System.EventHandler(this.BT_sua_Click);
            // 
            // BT_them
            // 
            this.BT_them.Location = new System.Drawing.Point(36, 14);
            this.BT_them.Name = "BT_them";
            this.BT_them.Size = new System.Drawing.Size(98, 38);
            this.BT_them.TabIndex = 27;
            this.BT_them.Text = "THÊM";
            this.BT_them.UseVisualStyleBackColor = true;
            this.BT_them.Click += new System.EventHandler(this.BT_them_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_sdt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_diachi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tB_idkhachhang);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 307);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BT_reset);
            this.panel2.Controls.Add(this.BT_xoa);
            this.panel2.Controls.Add(this.BT_sua);
            this.panel2.Controls.Add(this.BT_them);
            this.panel2.Location = new System.Drawing.Point(22, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 126);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(39, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 512);
            this.panel3.TabIndex = 33;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.GridKhachhang);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridKhachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GridKhachhang;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.TextBox tB_idkhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_sdt;
        private System.Windows.Forms.Button BT_reset;
        private System.Windows.Forms.Button BT_xoa;
        private System.Windows.Forms.Button BT_sua;
        private System.Windows.Forms.Button BT_them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}