using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public class Thanhtoan 
    {
        private string idKhachhang;
        private long tongTien;
        private string idHopdong;
        private string idCar;
        public Thanhtoan()
        {
        }
        public Thanhtoan(string idkhachhang,long tongtien,string idhopdong,string idcar)
        {
            this.idKhachhang = idkhachhang;
            this.tongTien  = tongtien;
            this.idHopdong = idhopdong;
            this.idCar = idcar;
        }
        public Thanhtoan(string idhopdong)
        {
            this.idHopdong =  idhopdong;
        }
        public void XacNhanTT()
        {
            FormXacNhanThanhToan xacnhanthanhtoan = new FormXacNhanThanhToan(idKhachhang, tongTien, idHopdong,idCar);
            xacnhanthanhtoan.ShowDialog();

        }
        public void XoaHopdong()
        {
            DataProvider dataProvider = new DataProvider();

            string query = "DELETE FROM Quanlythanhtoan WHERE IDhopdong = N'" + idHopdong + "' ";

            dataProvider.ExecuteQuery(query);           
        }
    }   
}
