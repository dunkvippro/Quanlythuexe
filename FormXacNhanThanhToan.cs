using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public partial class FormXacNhanThanhToan : Form
    {

        private string idKhachhang;
        private string idhopdong;
        private long sotien;
        private string idCar;
        public FormXacNhanThanhToan(string idKhachhang,long sotien,string idhopdong,string idcar)
        {
            InitializeComponent();
            this.idKhachhang = idKhachhang;
            this.sotien = sotien;
            this.idhopdong = idhopdong;
            this.idCar = idcar;
        }
        private void FormXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            tB_idkhachhang.Text = idKhachhang;
            tB_sotien.Text = sotien.ToString();
        }
        private void BT_hoantat_Click(object sender, EventArgs e)
        {
            Thanhtoan tt =new Thanhtoan(idhopdong);
            tt.XoaHopdong();
            Danhgia dg = new Danhgia(idKhachhang,tB_danhgia.Text,idCar);
            dg.ThemDG();
            this.Hide();
        }      
    }
}
