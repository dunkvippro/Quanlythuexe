namespace Quanlythuexe
{
    partial class FormHopdong
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
            this.cB_idcar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_biensoxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_idnguoithue = new System.Windows.Forms.ComboBox();
            this.dTP_ngaythue = new System.Windows.Forms.DateTimePicker();
            this.dTB_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.tB_phithue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_idchuxe = new System.Windows.Forms.TextBox();
            this.BT_reset = new System.Windows.Forms.Button();
            this.BT_xoa = new System.Windows.Forms.Button();
            this.BT_sua = new System.Windows.Forms.Button();
            this.BT_them = new System.Windows.Forms.Button();
            this.GridHopdong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_traxe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHopdong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(23, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(96, 40);
            this.bt_back.TabIndex = 18;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // cB_idcar
            // 
            this.cB_idcar.FormattingEnabled = true;
            this.cB_idcar.Location = new System.Drawing.Point(14, 34);
            this.cB_idcar.Name = "cB_idcar";
            this.cB_idcar.Size = new System.Drawing.Size(168, 24);
            this.cB_idcar.TabIndex = 20;
            this.cB_idcar.SelectionChangeCommitted += new System.EventHandler(this.cB_idcar_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Car ID";
            // 
            // tB_biensoxe
            // 
            this.tB_biensoxe.Location = new System.Drawing.Point(188, 36);
            this.tB_biensoxe.Name = "tB_biensoxe";
            this.tB_biensoxe.ReadOnly = true;
            this.tB_biensoxe.Size = new System.Drawing.Size(170, 22);
            this.tB_biensoxe.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Biển số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "ID chủ xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID người thuê";
            // 
            // cB_idnguoithue
            // 
            this.cB_idnguoithue.FormattingEnabled = true;
            this.cB_idnguoithue.Location = new System.Drawing.Point(14, 92);
            this.cB_idnguoithue.Name = "cB_idnguoithue";
            this.cB_idnguoithue.Size = new System.Drawing.Size(167, 24);
            this.cB_idnguoithue.TabIndex = 27;
            // 
            // dTP_ngaythue
            // 
            this.dTP_ngaythue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ngaythue.Location = new System.Drawing.Point(11, 152);
            this.dTP_ngaythue.Name = "dTP_ngaythue";
            this.dTP_ngaythue.Size = new System.Drawing.Size(170, 22);
            this.dTP_ngaythue.TabIndex = 29;
            // 
            // dTB_ngaytra
            // 
            this.dTB_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTB_ngaytra.Location = new System.Drawing.Point(188, 152);
            this.dTB_ngaytra.Name = "dTB_ngaytra";
            this.dTB_ngaytra.Size = new System.Drawing.Size(168, 22);
            this.dTB_ngaytra.TabIndex = 30;
            // 
            // tB_phithue
            // 
            this.tB_phithue.Location = new System.Drawing.Point(14, 209);
            this.tB_phithue.Name = "tB_phithue";
            this.tB_phithue.ReadOnly = true;
            this.tB_phithue.Size = new System.Drawing.Size(168, 22);
            this.tB_phithue.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ngày thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Phí thuê";
            // 
            // tB_idchuxe
            // 
            this.tB_idchuxe.Location = new System.Drawing.Point(188, 92);
            this.tB_idchuxe.Name = "tB_idchuxe";
            this.tB_idchuxe.ReadOnly = true;
            this.tB_idchuxe.Size = new System.Drawing.Size(170, 22);
            this.tB_idchuxe.TabIndex = 25;
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(199, 66);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(102, 32);
            this.BT_reset.TabIndex = 38;
            this.BT_reset.Text = "RESET";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // BT_xoa
            // 
            this.BT_xoa.Location = new System.Drawing.Point(65, 65);
            this.BT_xoa.Name = "BT_xoa";
            this.BT_xoa.Size = new System.Drawing.Size(98, 32);
            this.BT_xoa.TabIndex = 37;
            this.BT_xoa.Text = "XÓA";
            this.BT_xoa.UseVisualStyleBackColor = true;
            this.BT_xoa.Click += new System.EventHandler(this.BT_xoa_Click);
            // 
            // BT_sua
            // 
            this.BT_sua.Location = new System.Drawing.Point(199, 21);
            this.BT_sua.Name = "BT_sua";
            this.BT_sua.Size = new System.Drawing.Size(102, 39);
            this.BT_sua.TabIndex = 36;
            this.BT_sua.Text = "CẬP NHẬT";
            this.BT_sua.UseVisualStyleBackColor = true;
            this.BT_sua.Click += new System.EventHandler(this.BT_sua_Click);
            // 
            // BT_them
            // 
            this.BT_them.Location = new System.Drawing.Point(65, 21);
            this.BT_them.Name = "BT_them";
            this.BT_them.Size = new System.Drawing.Size(98, 38);
            this.BT_them.TabIndex = 35;
            this.BT_them.Text = "THÊM";
            this.BT_them.UseVisualStyleBackColor = true;
            this.BT_them.Click += new System.EventHandler(this.BT_them_Click);
            // 
            // GridHopdong
            // 
            this.GridHopdong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHopdong.GridColor = System.Drawing.SystemColors.Window;
            this.GridHopdong.Location = new System.Drawing.Point(477, 79);
            this.GridHopdong.Name = "GridHopdong";
            this.GridHopdong.RowHeadersWidth = 51;
            this.GridHopdong.RowTemplate.Height = 24;
            this.GridHopdong.Size = new System.Drawing.Size(675, 546);
            this.GridHopdong.TabIndex = 39;
            this.GridHopdong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHopdong_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BT_traxe);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 546);
            this.panel1.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tB_phithue);
            this.panel3.Controls.Add(this.dTB_ngaytra);
            this.panel3.Controls.Add(this.dTP_ngaythue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cB_idnguoithue);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tB_idchuxe);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tB_biensoxe);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cB_idcar);
            this.panel3.Location = new System.Drawing.Point(25, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 252);
            this.panel3.TabIndex = 44;
            // 
            // BT_traxe
            // 
            this.BT_traxe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_traxe.Location = new System.Drawing.Point(24, 447);
            this.BT_traxe.Name = "BT_traxe";
            this.BT_traxe.Size = new System.Drawing.Size(373, 77);
            this.BT_traxe.TabIndex = 42;
            this.BT_traxe.Text = "Trả xe";
            this.BT_traxe.UseVisualStyleBackColor = true;
            this.BT_traxe.Click += new System.EventHandler(this.BT_traxe_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BT_reset);
            this.panel2.Controls.Add(this.BT_xoa);
            this.panel2.Controls.Add(this.BT_sua);
            this.panel2.Controls.Add(this.BT_them);
            this.panel2.Location = new System.Drawing.Point(25, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 119);
            this.panel2.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(638, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 41);
            this.label8.TabIndex = 41;
            this.label8.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // FormHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridHopdong);
            this.Controls.Add(this.bt_back);
            this.Name = "FormHopdong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopdong";
            this.Load += new System.EventHandler(this.Hopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHopdong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.ComboBox cB_idcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_biensoxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_idnguoithue;
        private System.Windows.Forms.DateTimePicker dTP_ngaythue;
        private System.Windows.Forms.DateTimePicker dTB_ngaytra;
        private System.Windows.Forms.TextBox tB_phithue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_idchuxe;
        private System.Windows.Forms.Button BT_reset;
        private System.Windows.Forms.Button BT_xoa;
        private System.Windows.Forms.Button BT_sua;
        private System.Windows.Forms.Button BT_them;
        private System.Windows.Forms.DataGridView GridHopdong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_traxe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}