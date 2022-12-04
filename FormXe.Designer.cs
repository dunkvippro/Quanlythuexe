namespace Quanlythuexe
{
    partial class FormXe
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
            this.GridXe = new System.Windows.Forms.DataGridView();
            this.BT_sua = new System.Windows.Forms.Button();
            this.BT_reset = new System.Windows.Forms.Button();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_hangxe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_giathue = new System.Windows.Forms.TextBox();
            this.cB_tinhtrangxe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_tinhtrangthue = new System.Windows.Forms.ComboBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_biensoxe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_them = new System.Windows.Forms.Button();
            this.BT_xoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridXe
            // 
            this.GridXe.AllowUserToAddRows = false;
            this.GridXe.AllowUserToDeleteRows = false;
            this.GridXe.AllowUserToResizeColumns = false;
            this.GridXe.AllowUserToResizeRows = false;
            this.GridXe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridXe.ColumnHeadersHeight = 29;
            this.GridXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridXe.EnableHeadersVisualStyles = false;
            this.GridXe.Location = new System.Drawing.Point(351, 68);
            this.GridXe.Name = "GridXe";
            this.GridXe.RowHeadersVisible = false;
            this.GridXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.GridXe.RowTemplate.Height = 24;
            this.GridXe.Size = new System.Drawing.Size(807, 556);
            this.GridXe.TabIndex = 0;
            this.GridXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridXe_CellContentClick);
            // 
            // BT_sua
            // 
            this.BT_sua.Location = new System.Drawing.Point(136, 11);
            this.BT_sua.Name = "BT_sua";
            this.BT_sua.Size = new System.Drawing.Size(102, 39);
            this.BT_sua.TabIndex = 2;
            this.BT_sua.Text = "CẬP NHẬT";
            this.BT_sua.UseVisualStyleBackColor = true;
            this.BT_sua.Click += new System.EventHandler(this.BT_sua_Click);
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(136, 68);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(102, 32);
            this.BT_reset.TabIndex = 4;
            this.BT_reset.Text = "RESET";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // tB_id
            // 
            this.tB_id.Location = new System.Drawing.Point(29, 45);
            this.tB_id.Name = "tB_id";
            this.tB_id.Size = new System.Drawing.Size(195, 22);
            this.tB_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID xe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hãng xe";
            // 
            // tB_hangxe
            // 
            this.tB_hangxe.Location = new System.Drawing.Point(29, 105);
            this.tB_hangxe.Name = "tB_hangxe";
            this.tB_hangxe.Size = new System.Drawing.Size(197, 22);
            this.tB_hangxe.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá thuê";
            // 
            // tB_giathue
            // 
            this.tB_giathue.Location = new System.Drawing.Point(29, 216);
            this.tB_giathue.Name = "tB_giathue";
            this.tB_giathue.Size = new System.Drawing.Size(197, 22);
            this.tB_giathue.TabIndex = 11;
            // 
            // cB_tinhtrangxe
            // 
            this.cB_tinhtrangxe.FormattingEnabled = true;
            this.cB_tinhtrangxe.Items.AddRange(new object[] {
            "Bình thường",
            "Hư hỏng",
            ""});
            this.cB_tinhtrangxe.Location = new System.Drawing.Point(29, 270);
            this.cB_tinhtrangxe.Name = "cB_tinhtrangxe";
            this.cB_tinhtrangxe.Size = new System.Drawing.Size(199, 24);
            this.cB_tinhtrangxe.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tình trạng xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tình trạng thuê";
            // 
            // cB_tinhtrangthue
            // 
            this.cB_tinhtrangthue.FormattingEnabled = true;
            this.cB_tinhtrangthue.Items.AddRange(new object[] {
            "Chưa cho thuê",
            "Đang cho thuê"});
            this.cB_tinhtrangthue.Location = new System.Drawing.Point(29, 326);
            this.cB_tinhtrangthue.Name = "cB_tinhtrangthue";
            this.cB_tinhtrangthue.Size = new System.Drawing.Size(197, 24);
            this.cB_tinhtrangthue.TabIndex = 15;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(23, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(73, 23);
            this.bt_back.TabIndex = 17;
            this.bt_back.Text = "<---";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Biển số xe";
            // 
            // tB_biensoxe
            // 
            this.tB_biensoxe.Location = new System.Drawing.Point(29, 159);
            this.tB_biensoxe.Name = "tB_biensoxe";
            this.tB_biensoxe.Size = new System.Drawing.Size(197, 22);
            this.tB_biensoxe.TabIndex = 18;
            this.tB_biensoxe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tB_biensoxe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cB_tinhtrangthue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cB_tinhtrangxe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_giathue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_hangxe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tB_id);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 377);
            this.panel1.TabIndex = 20;
            // 
            // BT_them
            // 
            this.BT_them.Location = new System.Drawing.Point(22, 11);
            this.BT_them.Name = "BT_them";
            this.BT_them.Size = new System.Drawing.Size(98, 39);
            this.BT_them.TabIndex = 1;
            this.BT_them.Text = "THÊM";
            this.BT_them.UseVisualStyleBackColor = true;
            this.BT_them.Click += new System.EventHandler(this.BT_them_Click);
            // 
            // BT_xoa
            // 
            this.BT_xoa.Location = new System.Drawing.Point(22, 68);
            this.BT_xoa.Name = "BT_xoa";
            this.BT_xoa.Size = new System.Drawing.Size(98, 32);
            this.BT_xoa.TabIndex = 3;
            this.BT_xoa.Text = "XÓA";
            this.BT_xoa.UseVisualStyleBackColor = true;
            this.BT_xoa.Click += new System.EventHandler(this.BT_xoa_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BT_reset);
            this.panel2.Controls.Add(this.BT_xoa);
            this.panel2.Controls.Add(this.BT_sua);
            this.panel2.Controls.Add(this.BT_them);
            this.panel2.Location = new System.Drawing.Point(23, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 117);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(26, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 555);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.GridXe);
            this.KeyPreview = true;
            this.Name = "Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridXe;
        private System.Windows.Forms.Button BT_sua;
        private System.Windows.Forms.Button BT_reset;
        private System.Windows.Forms.TextBox tB_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_hangxe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_giathue;
        private System.Windows.Forms.ComboBox cB_tinhtrangxe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_tinhtrangthue;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_biensoxe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_them;
        private System.Windows.Forms.Button BT_xoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}