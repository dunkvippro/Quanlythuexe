using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public class Xe
    {
        private string idCar;
        private string hangXe;
        private string bienSoxe;
        private long giaThue;
        private string tinhTrangthue;
        private string tinhTrangxe;
       
        string chuoiketnoi = @"Data Source=DUNK\SQLEXPRESS;Initial Catalog=Quanlythuexe;Integrated Security=True";

        public Xe()
        {

        }

        public Xe(string idCar,string hangXe,string bienSoxe,long giaThue,string tinhTrangxe,string tinhTrangthue)
        {
            this.idCar = idCar;
            this.hangXe = hangXe;
            this.bienSoxe = bienSoxe;   
            this.giaThue = giaThue;
            this.tinhTrangxe = tinhTrangxe;
            this.tinhTrangthue = tinhTrangthue;
        }

        public string IdCar { get; set; }

        public void ThemXe()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "insert into Quanlyxe values('" + idCar + "',N'" + bienSoxe  + "', N'" + hangXe + "','" + giaThue + "',N'" + tinhTrangxe + "',N'" + tinhTrangthue + "')";

            command.ExecuteNonQuery();
            connection.Close();          
        }

        public void XoaXe()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "DELETE FROM Quanlyxe WHERE IDcar = '" + IdCar + "' ";

            command.ExecuteNonQuery();       
            connection.Close();
        }

        public void SuaThongTinXe()
        {
            SqlConnection connection = new SqlConnection(chuoiketnoi);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();

            command.CommandText = "UPDATE Quanlyxe SET Hangxe= N'" + hangXe + "' ,Biensoxe= N'" + bienSoxe + "' ,Giathue =  '" + giaThue + "' , Tinhtrangxe = N'" + tinhTrangxe + "',Tinhtrangthue =  N'" + tinhTrangthue + "' WHERE IDcar = '" + idCar + "' ";

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
