using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quanlythuexe
{
    public class Chuxe
    {
        private string idCar;
        private string bienSoxe;
        private string idChuxe;
        private string tenChuxe;
        private string soDienthoai;

        public DataProvider dataProvider = new DataProvider();
        public Chuxe()
        {
        }
        public Chuxe(string idcar,string biensoxe,string idchuxe,string tenchuxe,string sdt)
        {
            this.idCar = idcar;
            this.bienSoxe = biensoxe;
            this.idChuxe = idchuxe; 
            this.tenChuxe = tenchuxe;
            this.soDienthoai = sdt;
        }

        public void ThemCX()
        {
            string query = "insert into Quanlychuxe values('" + idCar + "',N'" + bienSoxe + "',N'" + idChuxe + "', N'" + tenChuxe + "',N'" + soDienthoai + "' )";

            dataProvider.ExecuteQuery(query);           
        }
        public void XoaCX()
        {
            string query = "DELETE FROM Quanlychuxe WHERE IDchuxe = N'" + idChuxe + "' ";
            dataProvider.ExecuteQuery(query);           
        }
        public void SuaCX()
        {
            string query = "UPDATE Quanlychuxe SET  Biensoxe= N'" + bienSoxe + "' ,IDchuxe =  N'" + idChuxe + "', Tenchuxe = N'" + tenChuxe + "',Sdt = N'" + soDienthoai + "' WHERE IDcar= N'" + idCar + "' ";

            dataProvider.ExecuteQuery(query);           
        }
    }
}
