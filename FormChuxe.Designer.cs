namespace Quanlythuexe
{
    partial class FormChuxe
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
            this.GridChuxe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_tenchuxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_idcar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_sodienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_idchuxe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_reset = new System.Windows.Forms.Button();
            this.BT_xoa = new System.Windows.Forms.Button();
            this.BT_sua = new System.Windows.Forms.Button();
            this.BT_them = new System.Windows.Forms.Button();
            this.tB_biensoxe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridChuxe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(21, 23);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(73, 23);
            this.bt_back.TabIndex = 18;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // GridChuxe
            // 
            this.GridChuxe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridChuxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridChuxe.Location = new System.Drawing.Point(418, 72);
            this.GridChuxe.Name = "GridChuxe";
            this.GridChuxe.RowHeadersWidth = 51;
            this.GridChuxe.RowTemplate.Height = 24;
            this.GridChuxe.Size = new System.Drawing.Size(712, 546);
            this.GridChuxe.TabIndex = 19;
            this.GridChuxe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridChuxe_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên ";
            // 
            // tB_tenchuxe
            // 
            this.tB_tenchuxe.Location = new System.Drawing.Point(30, 222);
            this.tB_tenchuxe.Name = "tB_tenchuxe";
            this.tB_tenchuxe.Size = new System.Drawing.Size(227, 22);
            this.tB_tenchuxe.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID car";
            // 
            // cB_idcar
            // 
            this.cB_idcar.FormattingEnabled = true;
            this.cB_idcar.Location = new System.Drawing.Point(30, 48);
            this.cB_idcar.Name = "cB_idcar";
            this.cB_idcar.Size = new System.Drawing.Size(227, 24);
            this.cB_idcar.TabIndex = 23;
            this.cB_idcar.SelectionChangeCommitted += new System.EventHandler(this.cB_idcar_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Biển số xe";
            // 
            // tB_sodienthoai
            // 
            this.tB_sodienthoai.Location = new System.Drawing.Point(30, 282);
            this.tB_sodienthoai.Name = "tB_sodienthoai";
            this.tB_sodienthoai.Size = new System.Drawing.Size(227, 22);
            this.tB_sodienthoai.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "SĐT";
            // 
            // tB_idchuxe
            // 
            this.tB_idchuxe.Location = new System.Drawing.Point(30, 168);
            this.tB_idchuxe.Name = "tB_idchuxe";
            this.tB_idchuxe.Size = new System.Drawing.Size(227, 22);
            this.tB_idchuxe.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID chủ xe";
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(156, 69);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(102, 32);
            this.BT_reset.TabIndex = 34;
            this.BT_reset.Text = "RESET";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // BT_xoa
            // 
            this.BT_xoa.Location = new System.Drawing.Point(31, 69);
            this.BT_xoa.Name = "BT_xoa";
            this.BT_xoa.Size = new System.Drawing.Size(98, 32);
            this.BT_xoa.TabIndex = 33;
            this.BT_xoa.Text = "XÓA";
            this.BT_xoa.UseVisualStyleBackColor = true;
            this.BT_xoa.Click += new System.EventHandler(this.BT_xoa_Click);
            // 
            // BT_sua
            // 
            this.BT_sua.Location = new System.Drawing.Point(156, 13);
            this.BT_sua.Name = "BT_sua";
            this.BT_sua.Size = new System.Drawing.Size(102, 39);
            this.BT_sua.TabIndex = 32;
            this.BT_sua.Text = "CẬP NHẬT";
            this.BT_sua.UseVisualStyleBackColor = true;
            this.BT_sua.Click += new System.EventHandler(this.BT_sua_Click);
            // 
            // BT_them
            // 
            this.BT_them.Location = new System.Drawing.Point(31, 13);
            this.BT_them.Name = "BT_them";
            this.BT_them.Size = new System.Drawing.Size(98, 38);
            this.BT_them.TabIndex = 31;
            this.BT_them.Text = "THÊM";
            this.BT_them.UseVisualStyleBackColor = true;
            this.BT_them.Click += new System.EventHandler(this.BT_them_Click);
            // 
            // tB_biensoxe
            // 
            this.tB_biensoxe.Location = new System.Drawing.Point(30, 112);
            this.tB_biensoxe.Name = "tB_biensoxe";
            this.tB_biensoxe.ReadOnly = true;
            this.tB_biensoxe.Size = new System.Drawing.Size(227, 22);
            this.tB_biensoxe.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tB_biensoxe);
            this.panel1.Controls.Add(this.tB_idchuxe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tB_sodienthoai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cB_idcar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_tenchuxe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 347);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BT_reset);
            this.panel2.Controls.Add(this.BT_xoa);
            this.panel2.Controls.Add(this.BT_sua);
            this.panel2.Controls.Add(this.BT_them);
            this.panel2.Location = new System.Drawing.Point(33, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 117);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(51, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 546);
            this.panel3.TabIndex = 39;
            // 
            // FormChuxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GridChuxe);
            this.Controls.Add(this.bt_back);
            this.Name = "FormChuxe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuxe";
            this.Load += new System.EventHandler(this.Chuxe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridChuxe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.DataGridView GridChuxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_tenchuxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_idcar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_sodienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_idchuxe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_reset;
        private System.Windows.Forms.Button BT_xoa;
        private System.Windows.Forms.Button BT_sua;
        private System.Windows.Forms.Button BT_them;
        private System.Windows.Forms.TextBox tB_biensoxe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}