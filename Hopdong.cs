using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Quanlythuexe
{
    public class Hopdong
    {
        private string idCar;
        private string bienSoxe;
        private string idChuxe;
        private string idKhachhang;
        private string ngayThue;
        private string ngayTra;
        private long phiThue;

        public DataProvider dataProvider = new DataProvider();     
        public Hopdong()
        {

        }
        public Hopdong(string idcar,string biensoxe,string idchuxe,string idkhachhang,string ngaythue,string ngaytra,long phithue)
        {
            this.idCar = idcar;
            this.bienSoxe = biensoxe;
            this.idChuxe = idchuxe;
            this.idKhachhang = idkhachhang;
            this.ngayThue = ngaythue;
            this.ngayTra = ngaytra;
            this.phiThue = phithue;
        }
        public Hopdong(string idcar)
        {
            this.idCar = idcar;
        }
        public void ThemHD()
        {
            string query = "insert into Quanlyhopdong values('" + idCar + "','" + bienSoxe + "','" + idChuxe + "', '" + idKhachhang + "','" + ngayThue + "','" + ngayTra + "', '" + phiThue + "')";

            dataProvider.ExecuteQuery(query);         
        }
        public void XoaHD()
        {           
            string query = "DELETE FROM Quanlyhopdong WHERE IDcar = '" + idCar + "' ";

            dataProvider.ExecuteQuery(query);           
        }
        public void SuaHD()
        {
            string query = "UPDATE Quanlyhopdong SET Biensoxe = N'" + bienSoxe + "' , IDchuxe = N'" + idChuxe + "' ,IDkhachhang= N'" + idKhachhang + "' ,Ngaythue =  '" + ngayThue + "' , Ngaytra = N'" + ngayTra + "',Phithue =  N'" + phiThue + "' WHERE IDcar = '" + idCar + "' ";

            dataProvider.ExecuteQuery(query);           
        }
    }
}
