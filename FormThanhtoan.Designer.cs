namespace Quanlythuexe
{
    partial class FormThanhtoan
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
            this.bt_back = new System.Windows.Forms.Button();
            this.cB_idnguoithue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_idxe = new System.Windows.Forms.ComboBox();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_uudai = new System.Windows.Forms.ComboBox();
            this.BT_add = new System.Windows.Forms.Button();
            this.BT_thanhtoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_search = new System.Windows.Forms.Button();
            this.Grid2 = new System.Windows.Forms.DataGridView();
            this.tB_idhopdong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_idxe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_idkhachhang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_ngaytraxe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_uudai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_tongtien = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(27, 21);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(73, 23);
            this.bt_back.TabIndex = 19;
            this.bt_back.Text = "<---";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // cB_idnguoithue
            // 
            this.cB_idnguoithue.FormattingEnabled = true;
            this.cB_idnguoithue.Location = new System.Drawing.Point(26, 37);
            this.cB_idnguoithue.Name = "cB_idnguoithue";
            this.cB_idnguoithue.Size = new System.Drawing.Size(200, 24);
            this.cB_idnguoithue.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID người thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID xe";
            // 
            // cB_idxe
            // 
            this.cB_idxe.FormattingEnabled = true;
            this.cB_idxe.Location = new System.Drawing.Point(26, 96);
            this.cB_idxe.Name = "cB_idxe";
            this.cB_idxe.Size = new System.Drawing.Size(200, 24);
            this.cB_idxe.TabIndex = 22;
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.AllowUserToResizeColumns = false;
            this.Grid1.AllowUserToResizeRows = false;
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Enabled = false;
            this.Grid1.Location = new System.Drawing.Point(36, 83);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.RowHeadersWidth = 51;
            this.Grid1.RowTemplate.Height = 24;
            this.Grid1.Size = new System.Drawing.Size(543, 226);
            this.Grid1.TabIndex = 24;
            this.Grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cB_uudai);
            this.panel1.Controls.Add(this.BT_add);
            this.panel1.Location = new System.Drawing.Point(875, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 132);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Thêm ưu đãi";
            // 
            // cB_uudai
            // 
            this.cB_uudai.FormattingEnabled = true;
            this.cB_uudai.Location = new System.Drawing.Point(40, 39);
            this.cB_uudai.Name = "cB_uudai";
            this.cB_uudai.Size = new System.Drawing.Size(171, 24);
            this.cB_uudai.TabIndex = 1;
            // 
            // BT_add
            // 
            this.BT_add.Location = new System.Drawing.Point(90, 92);
            this.BT_add.Name = "BT_add";
            this.BT_add.Size = new System.Drawing.Size(75, 23);
            this.BT_add.TabIndex = 0;
            this.BT_add.Text = "thêm";
            this.BT_add.UseVisualStyleBackColor = true;
            this.BT_add.Click += new System.EventHandler(this.BT_add_Click);
            // 
            // BT_thanhtoan
            // 
            this.BT_thanhtoan.Location = new System.Drawing.Point(875, 488);
            this.BT_thanhtoan.Name = "BT_thanhtoan";
            this.BT_thanhtoan.Size = new System.Drawing.Size(255, 138);
            this.BT_thanhtoan.TabIndex = 26;
            this.BT_thanhtoan.Text = "Thanh toán";
            this.BT_thanhtoan.UseVisualStyleBackColor = true;
            this.BT_thanhtoan.Click += new System.EventHandler(this.BT_thanhtoan_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(50, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 245);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BT_search);
            this.panel3.Controls.Add(this.cB_idxe);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cB_idnguoithue);
            this.panel3.Location = new System.Drawing.Point(13, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 194);
            this.panel3.TabIndex = 28;
            // 
            // BT_search
            // 
            this.BT_search.Location = new System.Drawing.Point(73, 142);
            this.BT_search.Name = "BT_search";
            this.BT_search.Size = new System.Drawing.Size(102, 31);
            this.BT_search.TabIndex = 27;
            this.BT_search.Text = "Tìm kiếm";
            this.BT_search.UseVisualStyleBackColor = true;
            this.BT_search.Click += new System.EventHandler(this.BT_search_Click);
            // 
            // Grid2
            // 
            this.Grid2.AllowUserToAddRows = false;
            this.Grid2.AllowUserToDeleteRows = false;
            this.Grid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid2.Location = new System.Drawing.Point(613, 83);
            this.Grid2.Name = "Grid2";
            this.Grid2.RowHeadersWidth = 51;
            this.Grid2.RowTemplate.Height = 24;
            this.Grid2.Size = new System.Drawing.Size(531, 226);
            this.Grid2.TabIndex = 28;
            this.Grid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid2_CellContentClick);
            // 
            // tB_idhopdong
            // 
            this.tB_idhopdong.Location = new System.Drawing.Point(30, 42);
            this.tB_idhopdong.Name = "tB_idhopdong";
            this.tB_idhopdong.ReadOnly = true;
            this.tB_idhopdong.Size = new System.Drawing.Size(188, 22);
            this.tB_idhopdong.TabIndex = 29;
            this.tB_idhopdong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID hợp đồng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID xe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tB_idxe
            // 
            this.tB_idxe.Location = new System.Drawing.Point(250, 42);
            this.tB_idxe.Name = "tB_idxe";
            this.tB_idxe.ReadOnly = true;
            this.tB_idxe.Size = new System.Drawing.Size(188, 22);
            this.tB_idxe.TabIndex = 31;
            this.tB_idxe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID khách hàng";
            // 
            // tB_idkhachhang
            // 
            this.tB_idkhachhang.Location = new System.Drawing.Point(30, 105);
            this.tB_idkhachhang.Name = "tB_idkhachhang";
            this.tB_idkhachhang.ReadOnly = true;
            this.tB_idkhachhang.Size = new System.Drawing.Size(188, 22);
            this.tB_idkhachhang.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tên khách hàng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tB_tenkhachhang
            // 
            this.tB_tenkhachhang.Location = new System.Drawing.Point(250, 105);
            this.tB_tenkhachhang.Name = "tB_tenkhachhang";
            this.tB_tenkhachhang.ReadOnly = true;
            this.tB_tenkhachhang.Size = new System.Drawing.Size(188, 22);
            this.tB_tenkhachhang.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ngày trả xe";
            // 
            // tB_ngaytraxe
            // 
            this.tB_ngaytraxe.Location = new System.Drawing.Point(30, 164);
            this.tB_ngaytraxe.Name = "tB_ngaytraxe";
            this.tB_ngaytraxe.ReadOnly = true;
            this.tB_ngaytraxe.Size = new System.Drawing.Size(188, 22);
            this.tB_ngaytraxe.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ưu đãi";
            // 
            // tB_uudai
            // 
            this.tB_uudai.Location = new System.Drawing.Point(250, 164);
            this.tB_uudai.Name = "tB_uudai";
            this.tB_uudai.ReadOnly = true;
            this.tB_uudai.Size = new System.Drawing.Size(57, 22);
            this.tB_uudai.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Tổng tiền cần thanh toán";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tB_tongtien
            // 
            this.tB_tongtien.Location = new System.Drawing.Point(113, 221);
            this.tB_tongtien.Multiline = true;
            this.tB_tongtien.Name = "tB_tongtien";
            this.tB_tongtien.ReadOnly = true;
            this.tB_tongtien.Size = new System.Drawing.Size(250, 53);
            this.tB_tongtien.TabIndex = 41;
            this.tB_tongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_tongtien.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.tB_tongtien);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.tB_uudai);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tB_ngaytraxe);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tB_tenkhachhang);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tB_idkhachhang);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tB_idxe);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tB_idhopdong);
            this.panel4.Location = new System.Drawing.Point(369, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 284);
            this.panel4.TabIndex = 43;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "VNĐ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Grid2);
            this.Controls.Add(this.BT_thanhtoan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.bt_back);
            this.Name = "Thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanhtoan";
            this.Load += new System.EventHandler(this.Thanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.ComboBox cB_idnguoithue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_idxe;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_uudai;
        private System.Windows.Forms.Button BT_add;
        private System.Windows.Forms.Button BT_thanhtoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView Grid2;
        private System.Windows.Forms.TextBox tB_idhopdong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_idxe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_idkhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_tenkhachhang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_ngaytraxe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_uudai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_tongtien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}