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

        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";

        public Thanhtoan()
        {
        }
        public Thanhtoan(string idkhachhang,long tongtien,string idhopdong)
        {
            this.idKhachhang = idkhachhang;
            this.tongTien  = tongtien;
            this.idHopdong = idhopdong;
        }
        public Thanhtoan(string idhopdong)
        {
            this.idHopdong =  idhopdong;
        }
        public void XacNhanTT()
        {
            FormXacNhanThanhToan xacnhanthanhtoan = new FormXacNhanThanhToan(idKhachhang, tongTien, idHopdong);
            xacnhanthanhtoan.ShowDialog();

        }
        public void XoaHopdong()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Quanlythanhtoan WHERE IDhopdong = N'" + idHopdong + "' ";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    
}
