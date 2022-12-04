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

        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";
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
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "insert into Quanlykhachhang values('" + idCus + "',N'" + tenKhachhang + "',N'" + diaChi + "', N'" + sdt + "' )";

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void XoaKH()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "DELETE FROM Quanlykhachhang WHERE IDcus = N'" + idCus + "' ";

            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SuaThongTinKH()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "UPDATE Quanlykhachhang SET Tenkhachhang= N'" + tenKhachhang + "' ,Diachi= N'" + diaChi + "' ,Sdt =  N'" + sdt + "' WHERE IDcus = N'" + idCus + "'";

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
