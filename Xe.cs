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
           
        public DataProvider dataProvider = new DataProvider();
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
        public Xe(string idCar)
        {
            this.idCar = idCar;
        }
        public string IdCar { get; set; }
        public void ThemXe()
        {          
            string query = "insert into Quanlyxe values('" + idCar + "',N'" + bienSoxe + "', N'" + hangXe + "','" + giaThue + "',N'" + tinhTrangxe + "',N'" + tinhTrangthue + "')";

            dataProvider.ExecuteQuery(query);        
        }
        public void XoaXe()
        {
            string query = "DELETE FROM Quanlyxe WHERE IDcar = '" + IdCar + "' ";

            dataProvider.ExecuteQuery(query);           
        }
        public void SuaThongTinXe()
        {
            string query = "UPDATE Quanlyxe SET Hangxe= N'" + hangXe + "' ,Biensoxe= N'" + bienSoxe + "' ,Giathue =  '" + giaThue + "' , Tinhtrangxe = N'" + tinhTrangxe + "',Tinhtrangthue =  N'" + tinhTrangthue + "' WHERE IDcar = '" + idCar + "' ";

            dataProvider.ExecuteQuery(query);
            
        }
        public void CapnhatTrangthaiXe(bool trangThai)
        {
            string query1 = "update Quanlyxe set Tinhtrangthue = N'" + "Đang cho thuê" + "' where IDcar = '" + idCar + "'";
            string query2 = "update Quanlyxe set Tinhtrangthue = N'" + "Chưa cho thuê" + "' where IDcar = '" + idCar + "'";

            if (trangThai == true)
            {
                dataProvider.ExecuteQuery(query1);
            }
            else
            {
                dataProvider.ExecuteQuery(query2);
            }                                 
        }
    }
}
