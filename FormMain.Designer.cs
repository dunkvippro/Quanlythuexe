namespace Quanlythuexe
{
    partial class FormMain
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
            this.lb1 = new System.Windows.Forms.Label();
            this.Quanlichuxe_bt = new System.Windows.Forms.Button();
            this.Quanlihopdong_bt = new System.Windows.Forms.Button();
            this.Quanlixe_bt = new System.Windows.Forms.Button();
            this.Quanliuser_bt = new System.Windows.Forms.Button();
            this.Thanhtoan_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Gray;
            this.lb1.Location = new System.Drawing.Point(-45, 49);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(1310, 135);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Phần mềm Quản lý thuê xe";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quanlichuxe_bt
            // 
            this.Quanlichuxe_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanlichuxe_bt.Location = new System.Drawing.Point(756, 226);
            this.Quanlichuxe_bt.Name = "Quanlichuxe_bt";
            this.Quanlichuxe_bt.Size = new System.Drawing.Size(337, 185);
            this.Quanlichuxe_bt.TabIndex = 0;
            this.Quanlichuxe_bt.TabStop = false;
            this.Quanlichuxe_bt.Text = "Quản lí chủ xe";
            this.Quanlichuxe_bt.UseVisualStyleBackColor = true;
            this.Quanlichuxe_bt.Click += new System.EventHandler(this.Quanlichuxe_bt_Click);
            // 
            // Quanlihopdong_bt
            // 
            this.Quanlihopdong_bt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Quanlihopdong_bt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Quanlihopdong_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanlihopdong_bt.Location = new System.Drawing.Point(102, 230);
            this.Quanlihopdong_bt.Name = "Quanlihopdong_bt";
            this.Quanlihopdong_bt.Size = new System.Drawing.Size(309, 368);
            this.Quanlihopdong_bt.TabIndex = 0;
            this.Quanlihopdong_bt.TabStop = false;
            this.Quanlihopdong_bt.Text = "Quản lí hợp đồng";
            this.Quanlihopdong_bt.UseVisualStyleBackColor = false;
            this.Quanlihopdong_bt.Click += new System.EventHandler(this.Quanlihopdong_bt_Click);
            // 
            // Quanlixe_bt
            // 
            this.Quanlixe_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanlixe_bt.Location = new System.Drawing.Point(428, 421);
            this.Quanlixe_bt.Name = "Quanlixe_bt";
            this.Quanlixe_bt.Size = new System.Drawing.Size(309, 177);
            this.Quanlixe_bt.TabIndex = 0;
            this.Quanlixe_bt.TabStop = false;
            this.Quanlixe_bt.Text = "Quản lí xe";
            this.Quanlixe_bt.UseVisualStyleBackColor = true;
            this.Quanlixe_bt.Click += new System.EventHandler(this.Quanlixe_bt_Click);
            // 
            // Quanliuser_bt
            // 
            this.Quanliuser_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanliuser_bt.Location = new System.Drawing.Point(428, 226);
            this.Quanliuser_bt.Name = "Quanliuser_bt";
            this.Quanliuser_bt.Size = new System.Drawing.Size(309, 185);
            this.Quanliuser_bt.TabIndex = 0;
            this.Quanliuser_bt.TabStop = false;
            this.Quanliuser_bt.Text = "Quản lí người thuê";
            this.Quanliuser_bt.UseVisualStyleBackColor = true;
            this.Quanliuser_bt.Click += new System.EventHandler(this.Quanliuser_bt_Click);
            // 
            // Thanhtoan_bt
            // 
            this.Thanhtoan_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thanhtoan_bt.Location = new System.Drawing.Point(756, 421);
            this.Thanhtoan_bt.Name = "Thanhtoan_bt";
            this.Thanhtoan_bt.Size = new System.Drawing.Size(337, 177);
            this.Thanhtoan_bt.TabIndex = 1;
            this.Thanhtoan_bt.Text = "Thanh toán";
            this.Thanhtoan_bt.UseVisualStyleBackColor = true;
            this.Thanhtoan_bt.Click += new System.EventHandler(this.Thanhtoan_bt_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.Thanhtoan_bt);
            this.Controls.Add(this.Quanliuser_bt);
            this.Controls.Add(this.Quanlixe_bt);
            this.Controls.Add(this.Quanlihopdong_bt);
            this.Controls.Add(this.Quanlichuxe_bt);
            this.Controls.Add(this.lb1);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button Quanlichuxe_bt;
        private System.Windows.Forms.Button Quanlihopdong_bt;
        private System.Windows.Forms.Button Quanlixe_bt;
        private System.Windows.Forms.Button Quanliuser_bt;
        private System.Windows.Forms.Button Thanhtoan_bt;
    }
}

