using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public class Khachhang
    {
        private string idCus;
        private string tenKhachhang;
        private string diaChi;
        private string sdt;

        public DataProvider dataProvider = new DataProvider();
        public Khachhang()
        {
        }
        public Khachhang(string idCus,string tenKhachhang,string diaChi,string sdt)
        {
            this.idCus = idCus;
            this.tenKhachhang = tenKhachhang;   
            this.diaChi = diaChi;
            this.sdt = sdt;
        }
        public void ThemKH()
        {
            string query = "insert into Quanlykhachhang values('" + idCus + "',N'" + tenKhachhang + "',N'" + diaChi + "', N'" + sdt + "' )";
            dataProvider.ExecuteQuery(query);           
        }
        public void XoaKH()
        {
            string query = "DELETE FROM Quanlykhachhang WHERE IDcus = N'" + idCus + "' ";
            dataProvider.ExecuteQuery(query);           
        }
        public void SuaThongTinKH()
        {
            string query = "UPDATE Quanlykhachhang SET Tenkhachhang= N'" + tenKhachhang + "' ,Diachi= N'" + diaChi + "' ,Sdt =  N'" + sdt + "' WHERE IDcus = N'" + idCus + "'";
            dataProvider.ExecuteQuery(query);           
        }
    }
}
